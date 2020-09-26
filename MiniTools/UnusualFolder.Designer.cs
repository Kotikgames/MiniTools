namespace MiniTools
{
    partial class UnusualFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dirType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dirName = new System.Windows.Forms.TextBox();
            this.dirExplorerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createDirBtn = new System.Windows.Forms.Button();
            this.createDirAt = new System.Windows.Forms.FolderBrowserDialog();
            this.t = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customCLSID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип:";
            // 
            // dirType
            // 
            this.dirType.FormattingEnabled = true;
            this.dirType.Items.AddRange(new object[] {
            "Папка",
            "Корзина",
            "Кнопки",
            "Фейк Папка Пользователя",
            "Запустить (Run) (Окно не показывается)",
            "ConflictFolder (Окно не показывается)",
            "Папка Пользователя",
            "Удаление обновлений",
            "Сетевое обнаружение"});
            this.dirType.Location = new System.Drawing.Point(38, 5);
            this.dirType.Name = "dirType";
            this.dirType.Size = new System.Drawing.Size(280, 21);
            this.dirType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название папки:";
            // 
            // dirName
            // 
            this.dirName.Location = new System.Drawing.Point(9, 71);
            this.dirName.Name = "dirName";
            this.dirName.Size = new System.Drawing.Size(313, 20);
            this.dirName.TabIndex = 4;
            // 
            // dirExplorerName
            // 
            this.dirExplorerName.Location = new System.Drawing.Point(9, 113);
            this.dirExplorerName.Name = "dirExplorerName";
            this.dirExplorerName.Size = new System.Drawing.Size(313, 20);
            this.dirExplorerName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название папки (в проводнике):";
            // 
            // createDirBtn
            // 
            this.createDirBtn.Location = new System.Drawing.Point(256, 230);
            this.createDirBtn.Name = "createDirBtn";
            this.createDirBtn.Size = new System.Drawing.Size(75, 23);
            this.createDirBtn.TabIndex = 7;
            this.createDirBtn.Text = "Создать";
            this.createDirBtn.UseVisualStyleBackColor = true;
            this.createDirBtn.Click += new System.EventHandler(this.createDirBtn_Click);
            // 
            // createDirAt
            // 
            this.createDirAt.Description = "Где создать папку?";
            // 
            // t
            // 
            this.t.FormattingEnabled = true;
            this.t.Items.AddRange(new object[] {
            "Нету"});
            this.t.Location = new System.Drawing.Point(9, 161);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(313, 21);
            this.t.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Локализованное название (из shell32):";
            // 
            // customCLSID
            // 
            this.customCLSID.Location = new System.Drawing.Point(132, 29);
            this.customCLSID.Name = "customCLSID";
            this.customCLSID.Size = new System.Drawing.Size(186, 20);
            this.customCLSID.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Или свой CLSID:";
            // 
            // UnusualFolder
            // 
            this.ClientSize = new System.Drawing.Size(334, 256);
            this.Controls.Add(this.customCLSID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t);
            this.Controls.Add(this.createDirBtn);
            this.Controls.Add(this.dirExplorerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dirName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dirType);
            this.Controls.Add(this.label1);
            this.Name = "UnusualFolder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dirType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dirName;
        private System.Windows.Forms.TextBox dirExplorerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createDirBtn;
        private System.Windows.Forms.FolderBrowserDialog createDirAt;
        private System.Windows.Forms.ComboBox t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customCLSID;
        private System.Windows.Forms.Label label5;
    }
}