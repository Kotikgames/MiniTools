using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTools
{
    public partial class UnusualFolder : Form
    {
        private const string DESKTOP_INI_START = "[.ShellClassInfo]\n";
        private const string DESKTOP_INI_CLSID = "CLSID=%\n";
        //private const string RECYCLE_BIN_ID = "{645FF040-5081-101B-9F08-00AA002F954E}\n";
        private const string DESKTOP_INI_LOCNAME = "LocalizedResourceName=%\n";

        private Dictionary<int, uint> ShellStrings = new Dictionary<int, uint>();
        private Dictionary<int, string> CLSIDs = new Dictionary<int, string>();

        public UnusualFolder()
        {
            InitializeComponent();
            CLSIDs.Add(1, "{645FF040-5081-101B-9F08-00AA002F954E}");
            CLSIDs.Add(2, "{437ff9c0-a07f-4fa0-af80-84b6c6440a16}");
            CLSIDs.Add(3, "{DFFACDC5-679F-4156-8947-C5C76BC0B67F}");
            CLSIDs.Add(4, "{2559a1f3-21d7-11d4-bdaf-00c04f60b9f0}");
            CLSIDs.Add(5, "{E413D040-6788-4C22-957E-175D1C513A34}");
            CLSIDs.Add(6, "{59031a47-3f72-44a7-89c5-5595fe6b30ee}");
            CLSIDs.Add(7, "{d450a8a1-9568-45c7-9c0e-b4f9fb4537bd}");
            CLSIDs.Add(8, "F02C1A0D-BE21-4350-88B0-7367FC96EF3C}");
            //  hmm..
            var lib = NativeMethods.LoadLibrary("%SystemRoot%\\Windows\\System32\\shell32.dll");
            for(uint i = 0 ; i < 30000; i++)
            {
                string s = GetStringResource(lib, i);
                if(s.Length > 1)
                {
                    t.Items.Add(s);
                    ShellStrings.Add(t.Items.Count - 1, i);
                }
            }
        }

        private void createDirBtn_Click(object sender, EventArgs e)
        {
            if(createDirAt.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dir = Directory.CreateDirectory(createDirAt.SelectedPath + '\\' + dirName.Text);
                string text = DESKTOP_INI_START;
                if(dirType.SelectedIndex > 0 && customCLSID.Text.Length == 0) text += DESKTOP_INI_CLSID.Replace("%", CLSIDs[dirType.SelectedIndex] + '\n');
                else if(customCLSID.Text.Length >= 1) text += DESKTOP_INI_CLSID.Replace("%", customCLSID.Text + '\n');
                if(dirExplorerName.Text.Length > 0 && t.SelectedIndex < 1) text += DESKTOP_INI_LOCNAME.Replace("%", dirExplorerName.Text);
                else if(t.SelectedIndex > 0) text += DESKTOP_INI_LOCNAME.Replace("%", "@%SystemRoot%\\system32\\shell32.dll,-" + ShellStrings[t.SelectedIndex]);
                File.WriteAllText(dir.FullName + "\\desktop.ini", text, Encoding.UTF8);
                File.SetAttributes(dir.FullName + "\\desktop.ini", FileAttributes.System | FileAttributes.Hidden);
                dir.Attributes = FileAttributes.System;
            }
        }

        static string GetStringResource(IntPtr handle, uint resourceId)
        {
            try
            {
                StringBuilder buffer = new StringBuilder(8192);

                int length = NativeMethods.LoadString(handle, resourceId, buffer, buffer.Capacity);

                return buffer.ToString(0, length);
            }
            catch(Exception)
            {
                return string.Empty;
            }
        }
    }


    static class NativeMethods
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern IntPtr LoadLibrary(string lpLibFileName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        internal static extern int LoadString(IntPtr hInstance, uint wID, StringBuilder lpBuffer, int nBufferMax);

        [DllImport("kernel32.dll")]
        public static extern int FreeLibrary(IntPtr hLibModule);
    }
}
