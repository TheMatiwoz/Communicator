using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


//DONE
//poprawilem nazwe funkcji na konwencje c#
//prawidlowe wyslanie zachodzi po uprzedniem konwersji, mozna skonwertowac puste pole, 
//wtedy jest wysylane puste pole (tak powinno byc)
//zabezpieczenie przed nadawaniem polskich znakow - konwersja ą na a itd.
//sprawdzenie czy slowo nie jest wulgarne
//dzwiek przy wysylaniu

//TODO 
//LADNIE ZEBY WYGLADALO

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
        private Boolean isTextConverted = false;
        private SoundPlayer messageIsSent;

        private readonly string filepath = @"";

        public Form1()
        {
            InitializeComponent();
            InitializeStartAndStopBits();
            InitializeSoundPlayer();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button
        }

        private void InitializeStartAndStopBits()
        {
            singleSign[0] = '0'; binaryTextWithoutSpaces[0] = '0';
            singleSign[9] = '1'; binaryTextWithoutSpaces[9] = '1';
            singleSign[10] = '1'; binaryTextWithoutSpaces[10] = '1';
            singleSign[11] = ' ';
        }

        private void InitializeSoundPlayer()
        {
            messageIsSent = new SoundPlayer(Properties.Resources.messageSent);
        }

        private void ConvertText_Click(object sender, EventArgs e)
        {
            filename = String.Format("Message{0}.txt", formNumer.ToString());
            StringBuilder stringBuilderWithSpaces = new StringBuilder();
            StringBuilder stringBuilderCleanMessage = new StringBuilder();

            ConvertEveryCharInOriginalTextBox(stringBuilderWithSpaces, stringBuilderCleanMessage);
            readBox.Text = stringBuilderWithSpaces.ToString();

            System.IO.File.WriteAllText(filepath + filename, stringBuilderCleanMessage.ToString());
            isTextConverted = true;
        }

        private void ConvertEveryCharInOriginalTextBox(StringBuilder stringBuilderWithSpaces,
            StringBuilder stringBuilderCleanMessage)
        {
            foreach (char k in textBox.Text)
            {
                int i = 8;
                char normalizedChar = NormalizeChar(k);
                binaryCode = Convert.ToString(normalizedChar, 2).PadLeft(8, '0');
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
            if (isTextConverted)
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
                messageIsSent.Play();
                ReadMessage(differentFormNumber);
                isTextConverted = false;
            }
            else
            {
                EmptyMessageError ErrorMessage = new EmptyMessageError();
                ErrorMessage.ShowDialog();
            }
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
                Program.listOfForms[differentFormNumber].readBox.Text = "ERROR";
            }
        }

        private void DecodeMessage(string fileContent, int differentFormNumber)
        {
            int messageLength = fileContent.Length;
            int currentNumberOfDecodedSign = 0;
            int endOfNSign = currentNumberOfDecodedSign + lengthOfCleanFrame;
            StringBuilder stringBuilder = new StringBuilder(messageLength);

            for (int i = 0; i < messageLength / lengthOfCleanFrame; i++)
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
            string finalText = CheckIfWordIsNotVulgar(decodedString);
            Program.listOfForms[differentFormNumber].readBox.Text = finalText;
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

        private char NormalizeChar(char c)
        {
            var changerDict = new Dictionary<Char, Char>()
            {
                { 'ą', 'a' },
                { 'ć', 'c' },
                { 'ę', 'e' },
                { 'ł', 'l' },
                { 'ń', 'n' },
                { 'ó', 'o' },
                { 'ś', 's' },
                { 'ż', 'z' },
                { 'ź', 'z' }
            };
            return changerDict.ContainsKey(c) ? changerDict[c] : c;
            switch (c)
            {
                case 'ą':
                    return 'a';
                case 'ć':
                    return 'c';
                case 'ę':
                    return 'e';
                case 'ł':
                    return 'l';
                case 'ń':
                    return 'n';
                case 'ó':
                    return 'o';
                case 'ś':
                    return 's';
                case 'ż':
                case 'ź':
                    return 'z';
            }
            return c;
        }

        private string CheckIfWordIsNotVulgar(string decodedText)
        {
            string vulgarWordsInOneString = Properties.Resources.vulgarWords;
            string[] vulgarWordsSeperately = CleanQuotesAndEndOfLines(vulgarWordsInOneString).Split(',');
            string[] decodedWordsSeperately = decodedText.Split(' ');
            string cleanText = String.Empty;

            foreach (string decodedWord in decodedWordsSeperately)
            {
                string checkingWord = decodedWord;
                string cleanWord = String.Empty;

                bool isVulgar = Array.Exists(vulgarWordsSeperately, vulgarWord => vulgarWord == decodedWord);
                cleanWord = !isVulgar ? checkingWord : new Regex("\\S").Replace(checkingWord, "*"); ;
                cleanText += $"{cleanWord} ";
            }

            return cleanText;
        }

        private string CleanQuotesAndEndOfLines(string filename)
        {
            return filename.Replace("'", "").Replace(" ", "").Replace("\n", "").Replace("\r\n", "").Replace("\r", "");
        }

        private void oProjekcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectInfoForm projectInfoForm = new ProjectInfoForm();
            projectInfoForm.ShowDialog();
        }

        private void oTworcachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.ShowDialog();
        }

        private void wyjdzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
