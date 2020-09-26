using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTools
{
    public partial class PasswordNeedCreator : Form
    {
        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        public static extern int PickIconDlg(IntPtr hwndOwner, StringBuilder lpstrFile, int nMaxFile, ref int lpdwIconIndex);
        [DllImport("Shell32.dll", EntryPoint = "ExtractIconExW", CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern int ExtractIconEx(string sFile, int iIndex, out IntPtr piLargeVersion, out IntPtr piSmallVersion, int amountIcons);

        private readonly PasswordNeed passwordNeed;
        public PasswordNeedCreator()
        {
            InitializeComponent();
            passwordNeed = new PasswordNeed(txt.Text, "", (Bitmap)icon.Image)
            {
                TopLevel = false,
                ControlBox = false
            };
            panel1.Controls.Add(passwordNeed);
            passwordNeed.Show();
        }

        private void icon_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("C:\\Windows\\System32\\Shell32.dll", 512);
            int i = 0;
            PickIconDlg(Handle, sb, 1024, ref i);
            IntPtr large;
            IntPtr small;
            ExtractIconEx(sb.ToString(), i, out large, out small, 2);
            try
            {
                icon.Image = Icon.FromHandle(large).ToBitmap();
                ChangeFormPreview();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ChangeFormPreview()
        {
            passwordNeed.cancelBtn.Text = cancelBtnText.Text;
            passwordNeed.loginBtn.Text = loginBtnText.Text;
            passwordNeed.cancelBtn.Enabled = cancelBtnEnabled.Checked;
            passwordNeed.loginBtn.Enabled = loginBtnEnabled.Checked;
            passwordNeed.pass.Enabled = pswdEnabled.Checked;
            passwordNeed.ControlBox = controlBoxEnabled.Checked;
            passwordNeed.Text = captionText.Text;
            passwordNeed.ChangeData(txt.Text, pswd.Text, (Bitmap)icon.Image);
        }

        private void showPN_Click(object sender, EventArgs e)
        {
            var p = new PasswordNeed(txt.Text, pswd.Text, (Bitmap)icon.Image);
            // String Settings
            p.cancelBtn.Text = cancelBtnText.Text;
            p.loginBtn.Text = loginBtnText.Text;
            p.Text = captionText.Text;
            // Bool Settings
            p.cancelBtn.Enabled = cancelBtnEnabled.Checked;
            p.loginBtn.Enabled = loginBtnEnabled.Checked; 
            p.ControlBox = controlBoxEnabled.Checked;
            p.pass.Enabled = pswdEnabled.Checked;
            p.closeEnabled = closeEnabled.Checked;
            p.ShowDialog();
        }

        private void TextBoxChanged(object sender, EventArgs e) { ChangeFormPreview(); }
    }
}
