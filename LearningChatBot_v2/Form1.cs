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
using System.Xml.Serialization;

namespace LearningChatBot_v2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                MyData info = new MyData();
                info.Data1 = userInput.Text;
                info.Data2 = "Hello";
                info.Data3 = "World";
                SaveData(info, "test.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SaveData(object obj, string filename)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            sr.Serialize(writer, obj);
            writer.Close();            
        }

        public void MainBrain()
        {

        }
    }

    public class MyData
    {
        private string data1;
        private string data2;
        private string data3;

        public string Data1
        {
            get { return data1; }
            set { data1 = value; }
        }
        public string Data2
        {
            get { return data2; }
            set { data2 = value; }
        }
        public string Data3
        {
            get { return data3; }
            set { data3 = value; }
        }
    }
}


