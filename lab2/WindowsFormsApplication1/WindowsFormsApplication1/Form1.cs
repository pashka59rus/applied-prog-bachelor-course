using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ControllerAndModel;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        FileContent fc = new FileContent();
        Reader Read = new Reader();
        Writer Wr = new Writer();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (fc.path!=null)
            {
                richTextBox1.Text = Controller.ProcessText(Read.SuccesResult(Controller.ProcessFilePath(fc.path)));
            }
            else
            {
                MessageBox.Show(Read.ErrorResult(fc.path));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fc.path != null)
            {
                fc.Text = richTextBox1.Text;
                Controller.ProcessWriteText(Wr.SuccesResult(Controller.ProcessFilePath(fc.path)), fc.Text);
                MessageBox.Show("Файл успешно записан");
            }
            else
            {
                MessageBox.Show(Wr.ErrorResult(fc.path));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                fc.path = openFileDialog1.FileName;
                textBox1.Text = fc.path;                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }   
}
