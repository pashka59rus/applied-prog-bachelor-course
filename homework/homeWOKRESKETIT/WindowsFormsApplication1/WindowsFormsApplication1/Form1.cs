using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                textBox1.Text = path;
            }
            else
            {
                path = null;
            }
            var httpRequest = (HttpWebRequest)HttpWebRequest.Create("http://localhost:52012/home/Read?path=" + path);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            var reader = new StreamReader(httpResponse.GetResponseStream());
            string result = reader.ReadToEnd();
            richTextBox1.Text = result ;
            reader.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path;
            string text = richTextBox1.Text;
            if (textBox1.Text!=null)
            {
                 path = textBox1.Text;
            }
            else
            {
                path = null;
                MessageBox.Show("write path!");
            }
            var content = new Content();
            content.path = path;
            content.text = text;
            string JsonContent = JsonConvert.SerializeObject(content);
            var httpRequest = (HttpWebRequest)HttpWebRequest.Create("http://localhost:52012/home/Write?JsonContent=" + JsonContent);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            var reader = new StreamReader(httpResponse.GetResponseStream());
            MessageBox.Show("File Success rewrite");
        }
    }
    public class Content
    {
        public string path { get; set; }
        public string text { get; set; }
    }
}
