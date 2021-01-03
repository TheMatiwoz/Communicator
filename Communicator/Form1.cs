using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communicator
{
    public partial class Form1 : Form
    {
        char[] singleSign = new char[12];
        List<char[]> byteArray = new List<char[]>();
        string str;
        string filename;
        public int formNumer;

        public Form1()
        {
            InitializeComponent();
           
            singleSign[0] = '0';
            singleSign[9] = '1';
            singleSign[10] = '1';
            singleSign[11] = ' ';

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filename = String.Format("Message{0}.txt", formNumer.ToString());
            StringBuilder sb = new StringBuilder(1000);
            foreach (char k in textBox.Text)
            {
                int i = 8;
                str = Convert.ToString(k, 2).PadLeft(8, '0');
                foreach (char c in str)
                {
                    singleSign[i] = c;
                    //Console.WriteLine(singleSign[i]);
                    i--;

                }
                //byteArray.Add(singleSign);
                sb.Append(singleSign);
            }
            label1.Text = sb.ToString();

            System.IO.File.WriteAllText(filename, sb.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int formNumber = this.formNumer;
            int differentFormNumber = 0;

           

            if (formNumer == 0)
            {
                differentFormNumber = 1;
            }
            else if(formNumer == 1)
            {
                differentFormNumber = 0;
            }
            Console.WriteLine(formNumer);
            Console.WriteLine(differentFormNumber);


            Program.listOfForms[differentFormNumber].label1.Text = readMessage();
        }

        private string readMessage()
        {
            string readFileName = String.Format("Message{0}.txt", formNumer.ToString());
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(readFileName))
                {
                    // Read the stream as a string, and write the string to the console.
                    return sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return "ERROR";

            }
        }
    }
}
