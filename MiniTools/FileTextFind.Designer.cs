namespace MiniTools
{
    partial class FileTextFind
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addFiles = new System.Windows.Forms.Button();
            this.addDir = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.findBtn = new System.Windows.Forms.Button();
            this.findText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.foreachFiles = new System.ComponentModel.BackgroundWorker();
            this.find = new System.ComponentModel.BackgroundWorker();
            this.addDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.foreachFilesFromDir = new System.ComponentModel.BackgroundWorker();
            this.files = new System.Windows.Forms.ListView();
            this.file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addFiles
            // 
            this.addFiles.Location = new System.Drawing.Point(2, 3);
            this.addFiles.Name = "addFiles";
            this.addFiles.Size = new System.Drawing.Size(108, 24);
            this.addFiles.TabIndex = 0;
            this.addFiles.Text = "Добавить файлы";
            this.addFiles.UseVisualStyleBackColor = true;
            this.addFiles.Click += new System.EventHandler(this.addFiles_Click);
            // 
            // addDir
            // 
            this.addDir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addDir.Location = new System.Drawing.Point(2, 29);
            this.addDir.Name = "addDir";
            this.addDir.Size = new System.Drawing.Size(108, 24);
            this.addDir.TabIndex = 1;
            this.addDir.Text = "Добавить папку";
            this.addDir.UseVisualStyleBackColor = true;
            this.addDir.Click += new System.EventHandler(this.addDir_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.findBtn);
            this.panel.Controls.Add(this.findText);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.addDir);
            this.panel.Controls.Add(this.addFiles);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(399, 55);
            this.panel.TabIndex = 3;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(320, 27);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 4;
            this.findBtn.Text = "Найти";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // findText
            // 
            this.findText.Location = new System.Drawing.Point(112, 29);
            this.findText.Name = "findText";
            this.findText.Size = new System.Drawing.Size(202, 20);
            this.findText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текст для поиска:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Текстовые файлы|*.txt;*.c,*.cpp;*.h;*.cs;*.java;*.py;*.ruby;*.json;*.yml;*.yaml;*" +
    ".xml;*.html;*.htm;*.css;*.js;*.vbs;*.log;*.sql;*.hpp;*.ini|Все файлы|*.*";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Добавить файлы";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // foreachFiles
            // 
            this.foreachFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.foreachFiles_DoWork);
            // 
            // find
            // 
            this.find.DoWork += new System.ComponentModel.DoWorkEventHandler(this.find_DoWork);
            // 
            // addDirDialog
            // 
            this.addDirDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.addDirDialog.ShowNewFolderButton = false;
            // 
            // foreachFilesFromDir
            // 
            this.foreachFilesFromDir.DoWork += new System.ComponentModel.DoWorkEventHandler(this.foreachFilesFromDir_DoWork);
            // 
            // files
            // 
            this.files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.file,
            this.pos});
            this.files.HideSelection = false;
            this.files.Location = new System.Drawing.Point(1, 55);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(397, 346);
            this.files.TabIndex = 4;
            this.files.UseCompatibleStateImageBehavior = false;
            this.files.View = System.Windows.Forms.View.Details;
            // 
            // file
            // 
            this.file.Text = "Файл";
            this.file.Width = 220;
            // 
            // pos
            // 
            this.pos.Text = "Позиция";
            this.pos.Width = 110;
            // 
            // FileTextFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 400);
            this.Controls.Add(this.files);
            this.Controls.Add(this.panel);
            this.Name = "FileTextFind";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileTextFind_FormClosing);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addFiles;
        private System.Windows.Forms.Button addDir;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox findText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker foreachFiles;
        private System.ComponentModel.BackgroundWorker find;
        private System.Windows.Forms.FolderBrowserDialog addDirDialog;
        private System.ComponentModel.BackgroundWorker foreachFilesFromDir;
        private System.Windows.Forms.ListView files;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.ColumnHeader pos;
    }
}
