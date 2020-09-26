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
    public partial class MessageBoxCreator : Form
    {
        public MessageBoxCreator()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) MessageBox.Show(msg.Text, title.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
            if(comboBox1.SelectedIndex == 1) MessageBox.Show(msg.Text, title.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(comboBox1.SelectedIndex == 2) MessageBox.Show(msg.Text, title.Text, MessageBoxButtons.OK, MessageBoxIcon.Question);
            if(comboBox1.SelectedIndex == 3) MessageBox.Show(msg.Text, title.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if(comboBox1.SelectedIndex == 4) MessageBox.Show(msg.Text, title.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
