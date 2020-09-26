using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTools
{
    public partial class PasswordNeed : Form
    {
        public bool closeEnabled = false;
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

        private void PasswordNeed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing && !closeEnabled)
            {
                e.Cancel = true;
            }
        }
    }
}
