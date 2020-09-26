namespace MiniTools
{
    partial class PasswordNeed
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
            this.icon = new System.Windows.Forms.PictureBox();
            this.txt = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(12, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(47, 48);
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(66, 13);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(37, 13);
            this.txt.TabIndex = 1;
            this.txt.Text = "Текст";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(69, 40);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(194, 20);
            this.pass.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(107, 85);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Войти";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(188, 85);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // PasswordNeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 109);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordNeed";
            this.Text = "Вход в систему";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordNeed_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label txt;
        public System.Windows.Forms.Button loginBtn;
        public System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.TextBox pass;
    }
}