using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MiniTools
{
    public partial class HttpRequestSender : Form
    {
        private readonly HttpClient client = new HttpClient();
        private string responseBody, prettifyJSONBody;
        public HttpRequestSender()
        {
            InitializeComponent();
            requestType.SelectedIndex = 0;
        }

        private async void sendRequestButton_Click(object sender, EventArgs e)
        {
            sendRequestButton.Enabled = false;
            responseGroup.Visible = false;
            prettifyJSON.Visible = false;
            var response = new HttpResponseMessage();
            try
            {
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage(new HttpMethod(requestType.SelectedItem.ToString()), urlText.Text);
                response = await client.SendAsync(httpRequestMessage);
            }catch(Exception we) 
            {
                MessageBox.Show(we.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sendRequestButton.Enabled = true;
                return;
            }
            statusLabel.Text = "Статус: " + response.StatusCode.ToString();
            responseBody = await response.Content.ReadAsStringAsync();
            // Is JSON?
            if(responseBody.StartsWith("{") && responseBody.EndsWith("}"))
            {
                prettifyJSON.Checked = true;
                prettifyJSON.Visible = true;
                // Prettify JSON
                prettifyJSONBody = JsonPrettify(responseBody);
                responseText.Text = prettifyJSONBody;
            } else responseText.Text = responseBody;
            webBrowser.DocumentText = responseBody;
            sendRequestButton.Enabled = true;
            responseGroup.Visible = true;
            headersList.Items.Clear();
            ListViewGroup contentHGroup = new ListViewGroup("Content Headers");
            ListViewGroup responseHGroup = new ListViewGroup("Response Headers");
            headersList.Groups.AddRange(new ListViewGroup[] { contentHGroup, responseHGroup });
            // Getting headers
            foreach(var header in response.Content.Headers)
            {
                headersList.Items.Add(new ListViewItem(new string[] { header.Key, header.Value.FirstOrDefault() }, contentHGroup));
            }
            foreach(var header in response.Headers)
            {
                headersList.Items.Add(new ListViewItem(new string[] { header.Key, header.Value.FirstOrDefault() }, responseHGroup));
            }
        }
        public static string JsonPrettify(string json)
        {
            using(var stringReader = new StringReader(json))
            using(var stringWriter = new StringWriter())
            {
                var jsonReader = new JsonTextReader(stringReader);
                var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
                jsonWriter.WriteToken(jsonReader);
                return stringWriter.ToString();
            }
        }

        private void prettifyJSON_CheckedChanged(object sender, EventArgs e)
        {
            if(prettifyJSON.Checked) responseText.Text = prettifyJSONBody;
            else responseText.Text = responseBody;
        }
    }
}
