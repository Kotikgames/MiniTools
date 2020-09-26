namespace MiniTools
{
    partial class HttpRequestSender
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
            this.urlText = new System.Windows.Forms.TextBox();
            this.sendRequestButton = new System.Windows.Forms.Button();
            this.requestType = new System.Windows.Forms.ComboBox();
            this.responseGroup = new System.Windows.Forms.GroupBox();
            this.prettifyJSON = new System.Windows.Forms.CheckBox();
            this.responseTabs = new System.Windows.Forms.TabControl();
            this.bodyPage = new System.Windows.Forms.TabPage();
            this.responseText = new System.Windows.Forms.RichTextBox();
            this.headersPage = new System.Windows.Forms.TabPage();
            this.statusLabel = new System.Windows.Forms.Label();
            this.previewTab = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.headersList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.responseGroup.SuspendLayout();
            this.responseTabs.SuspendLayout();
            this.bodyPage.SuspendLayout();
            this.headersPage.SuspendLayout();
            this.previewTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(59, 12);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(402, 20);
            this.urlText.TabIndex = 1;
            this.urlText.Text = "https://example.com";
            // 
            // sendRequestButton
            // 
            this.sendRequestButton.Location = new System.Drawing.Point(468, 39);
            this.sendRequestButton.Name = "sendRequestButton";
            this.sendRequestButton.Size = new System.Drawing.Size(96, 23);
            this.sendRequestButton.TabIndex = 2;
            this.sendRequestButton.Text = "Отправить";
            this.sendRequestButton.UseVisualStyleBackColor = true;
            this.sendRequestButton.Click += new System.EventHandler(this.sendRequestButton_Click);
            // 
            // requestType
            // 
            this.requestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requestType.FormattingEnabled = true;
            this.requestType.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "PATCH",
            "DELETE",
            "HEAD"});
            this.requestType.Location = new System.Drawing.Point(468, 12);
            this.requestType.Name = "requestType";
            this.requestType.Size = new System.Drawing.Size(96, 21);
            this.requestType.TabIndex = 3;
            // 
            // responseGroup
            // 
            this.responseGroup.Controls.Add(this.prettifyJSON);
            this.responseGroup.Controls.Add(this.responseTabs);
            this.responseGroup.Controls.Add(this.statusLabel);
            this.responseGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.responseGroup.Location = new System.Drawing.Point(0, 114);
            this.responseGroup.Name = "responseGroup";
            this.responseGroup.Size = new System.Drawing.Size(568, 264);
            this.responseGroup.TabIndex = 4;
            this.responseGroup.TabStop = false;
            this.responseGroup.Text = "Ответ";
            this.responseGroup.Visible = false;
            // 
            // prettifyJSON
            // 
            this.prettifyJSON.AutoSize = true;
            this.prettifyJSON.Checked = true;
            this.prettifyJSON.CheckState = System.Windows.Forms.CheckState.Checked;
            this.prettifyJSON.Location = new System.Drawing.Point(9, 16);
            this.prettifyJSON.Name = "prettifyJSON";
            this.prettifyJSON.Size = new System.Drawing.Size(89, 17);
            this.prettifyJSON.TabIndex = 2;
            this.prettifyJSON.Text = "Prettify JSON";
            this.prettifyJSON.UseVisualStyleBackColor = true;
            this.prettifyJSON.Visible = false;
            this.prettifyJSON.CheckedChanged += new System.EventHandler(this.prettifyJSON_CheckedChanged);
            // 
            // responseTabs
            // 
            this.responseTabs.Controls.Add(this.bodyPage);
            this.responseTabs.Controls.Add(this.headersPage);
            this.responseTabs.Controls.Add(this.previewTab);
            this.responseTabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.responseTabs.Location = new System.Drawing.Point(3, 35);
            this.responseTabs.Name = "responseTabs";
            this.responseTabs.SelectedIndex = 0;
            this.responseTabs.Size = new System.Drawing.Size(562, 226);
            this.responseTabs.TabIndex = 1;
            // 
            // bodyPage
            // 
            this.bodyPage.Controls.Add(this.responseText);
            this.bodyPage.Location = new System.Drawing.Point(4, 22);
            this.bodyPage.Name = "bodyPage";
            this.bodyPage.Padding = new System.Windows.Forms.Padding(3);
            this.bodyPage.Size = new System.Drawing.Size(537, 200);
            this.bodyPage.TabIndex = 0;
            this.bodyPage.Text = "Body";
            this.bodyPage.UseVisualStyleBackColor = true;
            // 
            // responseText
            // 
            this.responseText.Location = new System.Drawing.Point(6, 6);
            this.responseText.Name = "responseText";
            this.responseText.Size = new System.Drawing.Size(525, 191);
            this.responseText.TabIndex = 0;
            this.responseText.Text = "";
            // 
            // headersPage
            // 
            this.headersPage.Controls.Add(this.headersList);
            this.headersPage.Location = new System.Drawing.Point(4, 22);
            this.headersPage.Name = "headersPage";
            this.headersPage.Padding = new System.Windows.Forms.Padding(3);
            this.headersPage.Size = new System.Drawing.Size(554, 200);
            this.headersPage.TabIndex = 1;
            this.headersPage.Text = "Headers";
            this.headersPage.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(104, 17);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(44, 13);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Статус:";
            // 
            // previewTab
            // 
            this.previewTab.Controls.Add(this.webBrowser);
            this.previewTab.Location = new System.Drawing.Point(4, 22);
            this.previewTab.Name = "previewTab";
            this.previewTab.Padding = new System.Windows.Forms.Padding(3);
            this.previewTab.Size = new System.Drawing.Size(554, 200);
            this.previewTab.TabIndex = 2;
            this.previewTab.Text = "Просмотр HTML";
            this.previewTab.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(548, 194);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // headersList
            // 
            this.headersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.value});
            this.headersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headersList.HideSelection = false;
            this.headersList.Location = new System.Drawing.Point(3, 3);
            this.headersList.Name = "headersList";
            this.headersList.Size = new System.Drawing.Size(548, 194);
            this.headersList.TabIndex = 0;
            this.headersList.UseCompatibleStateImageBehavior = false;
            this.headersList.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Название";
            this.name.Width = 254;
            // 
            // value
            // 
            this.value.Text = "Значение";
            this.value.Width = 269;
            // 
            // HttpRequestSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 378);
            this.Controls.Add(this.responseGroup);
            this.Controls.Add(this.requestType);
            this.Controls.Add(this.sendRequestButton);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.label1);
            this.Name = "HttpRequestSender";
            this.responseGroup.ResumeLayout(false);
            this.responseGroup.PerformLayout();
            this.responseTabs.ResumeLayout(false);
            this.bodyPage.ResumeLayout(false);
            this.headersPage.ResumeLayout(false);
            this.previewTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Button sendRequestButton;
        private System.Windows.Forms.ComboBox requestType;
        private System.Windows.Forms.GroupBox responseGroup;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TabControl responseTabs;
        private System.Windows.Forms.TabPage bodyPage;
        private System.Windows.Forms.RichTextBox responseText;
        private System.Windows.Forms.TabPage headersPage;
        private System.Windows.Forms.CheckBox prettifyJSON;
        private System.Windows.Forms.TabPage previewTab;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ListView headersList;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader value;
    }
}