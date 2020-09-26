namespace MiniTools
{
    partial class PasswordNeedCreator
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
            this.txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.showPN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.closeEnabled = new System.Windows.Forms.CheckBox();
            this.controlBoxEnabled = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelBtnEnabled = new System.Windows.Forms.CheckBox();
            this.cancelBtnText = new System.Windows.Forms.TextBox();
            this.loginBtnEnabled = new System.Windows.Forms.CheckBox();
            this.loginBtnText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pswd = new System.Windows.Forms.TextBox();
            this.sc = new System.Windows.Forms.Button();
            this.pswdEnabled = new System.Windows.Forms.CheckBox();
            this.captionText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст:";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(58, 6);
            this.txt.MaxLength = 64;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(372, 20);
            this.txt.TabIndex = 1;
            this.txt.Text = "Для входа в систему, введите пароль:";
            this.txt.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 172);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Изображение:";
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.icon.Location = new System.Drawing.Point(95, 84);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(64, 64);
            this.icon.TabIndex = 4;
            this.icon.TabStop = false;
            this.icon.Click += new System.EventHandler(this.icon_Click);
            // 
            // showPN
            // 
            this.showPN.Location = new System.Drawing.Point(334, 404);
            this.showPN.Name = "showPN";
            this.showPN.Size = new System.Drawing.Size(96, 23);
            this.showPN.TabIndex = 5;
            this.showPN.Text = "Показать";
            this.showPN.UseVisualStyleBackColor = true;
            this.showPN.Click += new System.EventHandler(this.showPN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.closeEnabled);
            this.groupBox1.Controls.Add(this.controlBoxEnabled);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cancelBtnEnabled);
            this.groupBox1.Controls.Add(this.cancelBtnText);
            this.groupBox1.Controls.Add(this.loginBtnEnabled);
            this.groupBox1.Controls.Add(this.loginBtnText);
            this.groupBox1.Location = new System.Drawing.Point(165, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кнопки";
            // 
            // closeEnabled
            // 
            this.closeEnabled.AutoSize = true;
            this.closeEnabled.Checked = true;
            this.closeEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.closeEnabled.Location = new System.Drawing.Point(198, 52);
            this.closeEnabled.Name = "closeEnabled";
            this.closeEnabled.Size = new System.Drawing.Size(15, 14);
            this.closeEnabled.TabIndex = 7;
            this.closeEnabled.UseVisualStyleBackColor = true;
            this.closeEnabled.CheckedChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // controlBoxEnabled
            // 
            this.controlBoxEnabled.AutoSize = true;
            this.controlBoxEnabled.Location = new System.Drawing.Point(114, 51);
            this.controlBoxEnabled.Name = "controlBoxEnabled";
            this.controlBoxEnabled.Size = new System.Drawing.Size(15, 14);
            this.controlBoxEnabled.TabIndex = 5;
            this.controlBoxEnabled.UseVisualStyleBackColor = true;
            this.controlBoxEnabled.CheckedChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кнопка \"Закрыть\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Закрытие";
            // 
            // cancelBtnEnabled
            // 
            this.cancelBtnEnabled.AutoSize = true;
            this.cancelBtnEnabled.Checked = true;
            this.cancelBtnEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cancelBtnEnabled.Location = new System.Drawing.Point(228, 22);
            this.cancelBtnEnabled.Name = "cancelBtnEnabled";
            this.cancelBtnEnabled.Size = new System.Drawing.Size(15, 14);
            this.cancelBtnEnabled.TabIndex = 3;
            this.cancelBtnEnabled.UseVisualStyleBackColor = true;
            this.cancelBtnEnabled.CheckedChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // cancelBtnText
            // 
            this.cancelBtnText.Location = new System.Drawing.Point(138, 19);
            this.cancelBtnText.MaxLength = 10;
            this.cancelBtnText.Name = "cancelBtnText";
            this.cancelBtnText.Size = new System.Drawing.Size(84, 20);
            this.cancelBtnText.TabIndex = 2;
            this.cancelBtnText.Text = "Отмена";
            this.cancelBtnText.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // loginBtnEnabled
            // 
            this.loginBtnEnabled.AutoSize = true;
            this.loginBtnEnabled.Checked = true;
            this.loginBtnEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loginBtnEnabled.Location = new System.Drawing.Point(97, 23);
            this.loginBtnEnabled.Name = "loginBtnEnabled";
            this.loginBtnEnabled.Size = new System.Drawing.Size(15, 14);
            this.loginBtnEnabled.TabIndex = 1;
            this.loginBtnEnabled.UseVisualStyleBackColor = true;
            this.loginBtnEnabled.CheckedChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // loginBtnText
            // 
            this.loginBtnText.Location = new System.Drawing.Point(7, 20);
            this.loginBtnText.MaxLength = 10;
            this.loginBtnText.Name = "loginBtnText";
            this.loginBtnText.Size = new System.Drawing.Size(84, 20);
            this.loginBtnText.TabIndex = 0;
            this.loginBtnText.Text = "Войти";
            this.loginBtnText.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль:";
            // 
            // pswd
            // 
            this.pswd.Location = new System.Drawing.Point(58, 32);
            this.pswd.MaxLength = 16;
            this.pswd.Name = "pswd";
            this.pswd.Size = new System.Drawing.Size(350, 20);
            this.pswd.TabIndex = 9;
            this.pswd.WordWrap = false;
            this.pswd.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // sc
            // 
            this.sc.Enabled = false;
            this.sc.Location = new System.Drawing.Point(334, 193);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(96, 23);
            this.sc.TabIndex = 10;
            this.sc.Text = "Сценарий";
            this.sc.UseVisualStyleBackColor = true;
            // 
            // pswdEnabled
            // 
            this.pswdEnabled.AutoSize = true;
            this.pswdEnabled.Checked = true;
            this.pswdEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pswdEnabled.Location = new System.Drawing.Point(414, 35);
            this.pswdEnabled.Name = "pswdEnabled";
            this.pswdEnabled.Size = new System.Drawing.Size(15, 14);
            this.pswdEnabled.TabIndex = 8;
            this.pswdEnabled.UseVisualStyleBackColor = true;
            this.pswdEnabled.CheckedChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // captionText
            // 
            this.captionText.Location = new System.Drawing.Point(79, 58);
            this.captionText.MaxLength = 32;
            this.captionText.Name = "captionText";
            this.captionText.Size = new System.Drawing.Size(329, 20);
            this.captionText.TabIndex = 12;
            this.captionText.Text = "Вход в систему";
            this.captionText.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Заголовок:";
            // 
            // PasswordNeedCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 430);
            this.Controls.Add(this.captionText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pswdEnabled);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.pswd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showPN);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Name = "PasswordNeedCreator";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Button showPN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cancelBtnEnabled;
        private System.Windows.Forms.TextBox cancelBtnText;
        private System.Windows.Forms.CheckBox loginBtnEnabled;
        private System.Windows.Forms.TextBox loginBtnText;
        private System.Windows.Forms.CheckBox controlBoxEnabled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pswd;
        private System.Windows.Forms.CheckBox closeEnabled;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sc;
        private System.Windows.Forms.CheckBox pswdEnabled;
        private System.Windows.Forms.TextBox captionText;
        private System.Windows.Forms.Label label6;
    }
}