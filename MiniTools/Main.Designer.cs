namespace MiniTools
{
    partial class Main
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.selectTool = new System.Windows.Forms.ToolStrip();
            this.fileTextFindBtn = new System.Windows.Forms.ToolStripButton();
            this.msgBoxCreatorBtn = new System.Windows.Forms.ToolStripButton();
            this.unusualFolderBtn = new System.Windows.Forms.ToolStripButton();
            this.passNeedBtn = new System.Windows.Forms.ToolStripButton();
            this.about = new System.Windows.Forms.ToolStripButton();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.selectTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectTool
            // 
            this.selectTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTextFindBtn,
            this.msgBoxCreatorBtn,
            this.unusualFolderBtn,
            this.passNeedBtn,
            this.about});
            this.selectTool.Location = new System.Drawing.Point(0, 0);
            this.selectTool.Name = "selectTool";
            this.selectTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.selectTool.Size = new System.Drawing.Size(747, 25);
            this.selectTool.TabIndex = 0;
            this.selectTool.Text = "toolStrip1";
            // 
            // fileTextFindBtn
            // 
            this.fileTextFindBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileTextFindBtn.Image = ((System.Drawing.Image)(resources.GetObject("fileTextFindBtn.Image")));
            this.fileTextFindBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileTextFindBtn.Name = "fileTextFindBtn";
            this.fileTextFindBtn.Size = new System.Drawing.Size(168, 22);
            this.fileTextFindBtn.Text = "Поиск текста в файлах [WIP]";
            this.fileTextFindBtn.Click += new System.EventHandler(this.fileTextFindBtn_Click);
            // 
            // msgBoxCreatorBtn
            // 
            this.msgBoxCreatorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.msgBoxCreatorBtn.Image = ((System.Drawing.Image)(resources.GetObject("msgBoxCreatorBtn.Image")));
            this.msgBoxCreatorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.msgBoxCreatorBtn.Name = "msgBoxCreatorBtn";
            this.msgBoxCreatorBtn.Size = new System.Drawing.Size(135, 22);
            this.msgBoxCreatorBtn.Text = "Создатель сообщений";
            this.msgBoxCreatorBtn.ToolTipText = "Создатель ";
            this.msgBoxCreatorBtn.Click += new System.EventHandler(this.msgBoxCreatorBtn_Click);
            // 
            // unusualFolderBtn
            // 
            this.unusualFolderBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.unusualFolderBtn.Image = ((System.Drawing.Image)(resources.GetObject("unusualFolderBtn.Image")));
            this.unusualFolderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.unusualFolderBtn.Name = "unusualFolderBtn";
            this.unusualFolderBtn.Size = new System.Drawing.Size(158, 22);
            this.unusualFolderBtn.Text = "Создать необычную папку";
            this.unusualFolderBtn.Click += new System.EventHandler(this.unusualFolderBtn_Click);
            // 
            // passNeedBtn
            // 
            this.passNeedBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.passNeedBtn.Image = ((System.Drawing.Image)(resources.GetObject("passNeedBtn.Image")));
            this.passNeedBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.passNeedBtn.Name = "passNeedBtn";
            this.passNeedBtn.Size = new System.Drawing.Size(184, 22);
            this.passNeedBtn.Text = "Конструктор \"Вход по паролю\"";
            this.passNeedBtn.Click += new System.EventHandler(this.passNeedBtn_Click);
            // 
            // about
            // 
            this.about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.about.Image = ((System.Drawing.Image)(resources.GetObject("about.Image")));
            this.about.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(86, 19);
            this.about.Text = "О программе";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // Tabs
            // 
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 25);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(747, 516);
            this.Tabs.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 541);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.selectTool);
            this.Name = "Main";
            this.Text = "MiniTools";
            this.selectTool.ResumeLayout(false);
            this.selectTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip selectTool;
        private System.Windows.Forms.ToolStripButton fileTextFindBtn;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.ToolStripButton msgBoxCreatorBtn;
        private System.Windows.Forms.ToolStripButton passNeedBtn;
        private System.Windows.Forms.ToolStripButton about;
        private System.Windows.Forms.ToolStripButton unusualFolderBtn;
    }
}

