namespace MiniTools
{
    partial class MessageBoxCreator
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
            this.title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.TextBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Загаловок:";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(70, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(264, 20);
            this.title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сообщение:";
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(3, 68);
            this.msg.Multiline = true;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(331, 140);
            this.msg.TabIndex = 3;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(250, 208);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(83, 23);
            this.ok_button.TabIndex = 4;
            this.ok_button.Text = "ОК";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None (Нету)",
            "Information (Информация)",
            "Question (Вопрос)",
            "Warning (Предупреждение)",
            "Error (Ошибка)"});
            this.comboBox1.Location = new System.Drawing.Point(70, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // MessageBoxCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 233);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Name = "MessageBoxCreator";
            this.Text = "MessageBoxCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}