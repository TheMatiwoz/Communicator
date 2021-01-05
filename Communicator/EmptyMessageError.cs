using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communicator
{
    public partial class EmptyMessageError : Form
    {
        public EmptyMessageError()
        {
            InitializeComponent();
            InitializeErrorText();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button
        }

        private void InitializeErrorText()
        {
            errorLabel.Text = "Aby przeslac wiadomosc wprowadz tekst do pola tekstowego," +
                "a nastepnie kliknij konwertuj celem przekonwertowania wiadomosci do kodu binarnego, " +
                "aby umozliwic jej przesyl.";
        }
    }
}
