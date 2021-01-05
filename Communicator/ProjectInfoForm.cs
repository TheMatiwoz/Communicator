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
    public partial class ProjectInfoForm : Form
    {
        public ProjectInfoForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button
            InitializeProjectInfoWithText();
        }

        private void InitializeProjectInfoWithText()
        {
            String text = "Projekt ma na celu wykorzystanie interfejsow w celu komunikacji miedzy dwoma formularzami. " +
                "Obydwa okna sa zarazem nadanikiem jak i odbiornikiem. " +
                "Tekst do wyslania jest formatowany w postaci << bit startu, bity znaku od LSB do MSB oraz dwa bity stopu >> " +
                "Jako nosnik informacji zostal uzyty plik tekstowy. " +
                "W celu dbalosci o czystosc jezyka w program zostal wbudowany slownik grubianstw, zamieniajacy brzydkie " +
                "slowa na gwiazdki.";
            this.projectInfoLabel1.Text = text;
        }
    }
}
