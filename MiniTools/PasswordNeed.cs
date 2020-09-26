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
    public partial class PasswordNeed : Form
    {
        public bool closeEnabled = false;

        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        private int ExplorerHWND = FindWindow("Progman", "Program Manager");
        private int ExplorerBottomHWND = FindWindow("Shell_TrayWnd", "");


        public PasswordNeed(string text, string pass, Bitmap icon)
        {
            InitializeComponent();
            txt.Text = text;
            this.icon.Image = icon;
        }
        public void ChangeData(string text, string pass, Bitmap icon)
        {
            txt.Text = text;
            this.icon.Image = icon;
        }

        public void HideExplorer(bool explorer, bool explorerBottom)
        {
            ShowWindow(ExplorerHWND, explorer ? 0 : 1);
            ShowWindow(ExplorerBottomHWND, explorerBottom ? 0 : 1);
        }

        private void PasswordNeed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing && !closeEnabled)
            {
                e.Cancel = true;
            }
            if(!e.Cancel) HideExplorer(false, false);
        }
    }
}
