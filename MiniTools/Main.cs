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
    public partial class Main : Form
    {
        [DllImport("shell32.dll")]
        public static extern int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);

        public Main()
        {
            InitializeComponent();
        }

        private void fileTextFindBtn_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("Поиск текста в файлах [WIP]");
            FileTextFind form = new FileTextFind
            {
                TopLevel = false
            };
            tp.ControlRemoved += Tp_ControlRemoved;
            tp.Controls.Add(form);
            form.Show();
            Tabs.TabPages.Add(tp);
        }

        private void Tp_ControlRemoved(object sender, ControlEventArgs e)
        {
            TabPage tp = (TabPage)sender;
            if (tp.Controls.Count <= 0)
            {
                Tabs.TabPages.Remove(tp);
            }
        }

        private void msgBoxCreatorBtn_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("Создатель сообщений");
            MessageBoxCreator form = new MessageBoxCreator
            {
                TopLevel = false
            };
            tp.ControlRemoved += Tp_ControlRemoved;
            tp.Controls.Add(form);
            form.Show();
            Tabs.TabPages.Add(tp);
        }

        private void unusualFolderBtn_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("Создать необычную папку");
            UnusualFolder form = new UnusualFolder
            {
                TopLevel = false
            };
            tp.ControlRemoved += Tp_ControlRemoved;
            tp.Controls.Add(form);
            form.Show();
            Tabs.TabPages.Add(tp);
        }

        private void about_Click(object sender, EventArgs e)
        {
            ShellAbout(Handle, "MiniTools", "Всякие полезные/не понятные \"инструменты\". Разработчик: Витя Кулеш", Icon.Handle);
        }

        private void passNeedBtn_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("Конструктор \"Вход по паролю\"");
            PasswordNeedCreator form = new PasswordNeedCreator
            {
                TopLevel = false
            };
            tp.ControlRemoved += Tp_ControlRemoved;
            tp.Controls.Add(form);
            form.Show();
            Tabs.TabPages.Add(tp);
        }

        private void httpRequestSenderBtn_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("Отправить HTTP запрос");
            HttpRequestSender form = new HttpRequestSender
            {
                TopLevel = false
            };
            tp.ControlRemoved += Tp_ControlRemoved;
            tp.Controls.Add(form);
            form.Show();
            Tabs.TabPages.Add(tp);
        }
    }
}
