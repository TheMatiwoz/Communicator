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


//poprawilem nazwe funkcji na konwencje c#
//prawidlowe wyslanie zachodzi po uprzedniem konwersji

//TODO 
//zabezpieczyc przed nadawaniem polskich znakow - konwersja ą na a itd.
//dzwiek przy wysylaniu
//slownik grubianstw

namespace Communicator
{
    public partial class Form1 : Form
    {
        private static readonly int lengthOfCleanFrame = 11;
        public int formNumer;
        private char[] singleSign = new char[12];
        private char[] binaryTextWithoutSpaces = new char[lengthOfCleanFrame];
        private List<char[]> byteArray = new List<char[]>();
        private string binaryCode;
        private string filename;

        /*mine filepath, to be deleted*/
        private readonly string filepath = @"C:\\users\\micha\\Downloads\\";


        public Form1()
        {
            InitializeComponent();
            InitializeStartAndStopBits();
        }

        private void InitializeStartAndStopBits()
        {
            singleSign[0] = '0'; binaryTextWithoutSpaces[0] = '0';
            singleSign[9] = '1'; binaryTextWithoutSpaces[9] = '1';
            singleSign[10] = '1'; binaryTextWithoutSpaces[10] = '1';
            singleSign[11] = ' ';
        }

        private void ConvertText_Click(object sender, EventArgs e)
        {
            filename = String.Format("Message{0}.txt", formNumer.ToString());
            StringBuilder stringBuilderWithSpaces = new StringBuilder();
            StringBuilder stringBuilderCleanMessage = new StringBuilder();

            ConvertEveryCharInOriginalTextBox(stringBuilderWithSpaces, stringBuilderCleanMessage);
            label1.Text = stringBuilderWithSpaces.ToString();

            System.IO.File.WriteAllText(filepath + filename, stringBuilderCleanMessage.ToString());
        }

        private void ConvertEveryCharInOriginalTextBox(StringBuilder stringBuilderWithSpaces, 
            StringBuilder stringBuilderCleanMessage)
        {
            foreach (char k in textBox.Text)
            {
                int i = 8;
                binaryCode = Convert.ToString(k, 2).PadLeft(8, '0');
                foreach (char c in binaryCode)
                {
                    singleSign[i] = c;
                    binaryTextWithoutSpaces[i] = c;
                    i--;
                }
                stringBuilderWithSpaces.Append(singleSign);
                stringBuilderCleanMessage.Append(binaryTextWithoutSpaces);
            }
        }

        /*Also calls up reading message in the desination form*/
        private void SendMessage_Click(object sender, EventArgs e)
        {
            int differentFormNumber = 0;

            if (formNumer == 0)
            {
                differentFormNumber = 1;
            }
            else if (formNumer == 1)
            {
                differentFormNumber = 0;
            }
            ReadMessage(differentFormNumber);
        }

        private void ReadMessage(int differentFormNumber)
        {
            string readFileName = String.Format(filepath + "Message{0}.txt", formNumer.ToString());  //mine filepath addded
            try
            {
                using (var sr = new StreamReader(readFileName))
                {
                    string sentFile = sr.ReadToEnd();
                    DecodeMessage(sentFile, differentFormNumber);
                }
            }
            catch (IOException e)
            {
                //write down that conversion went wrong
            }
        }

        private void DecodeMessage(string fileContent, int differentFormNumber)
        {
            int messageLength = fileContent.Length;
            int currentNumberOfDecodedSign = 0;
            int endOfNSign = currentNumberOfDecodedSign + lengthOfCleanFrame;
            StringBuilder stringBuilder = new StringBuilder(messageLength);

            for (int i=0; i<messageLength/lengthOfCleanFrame; i++)
            {
                string substring = fileContent.Substring(currentNumberOfDecodedSign, endOfNSign);
                int bytesNumber = 11;
                char[] result = new char[8];

                bytesNumber = WriteBytesInProperOrderToDecode(substring, bytesNumber, result);
                currentNumberOfDecodedSign += lengthOfCleanFrame;
                stringBuilder.Append(result);
            }

            Encoding ascii = Encoding.ASCII;
            String decodedString = ascii.GetString(GetBytesFromBinaryString(stringBuilder.ToString()));
            Program.listOfForms[differentFormNumber].label1.Text = decodedString;
        }

        private static int WriteBytesInProperOrderToDecode(string substring, int bytesNumber, char[] result)
        {
            foreach (char c in substring)
            {
                if (bytesNumber % lengthOfCleanFrame == 0 || bytesNumber % lengthOfCleanFrame == 1
                    || bytesNumber % lengthOfCleanFrame == 2)
                {
                }
                else
                {
                    result[bytesNumber - 3] = c;
                }
                bytesNumber--;
            }

            return bytesNumber;
        }

        private Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);

                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }
    }
}
