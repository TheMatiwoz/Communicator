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
    public partial class AboutUsForm : Form
    {
        public AboutUsForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //restrict from resizing
            MaximizeBox = false;  //disable maximize button
            InitializeAboutUsDescription();
        }

        private void InitializeAboutUsDescription()
        {
            String textMW = "Mateusz Wozniak \n" +
                "Student 3 roku Inzynierii Biomdycznej, pracownik Intela, czlonek Gradientu, pasjonat snowboardu, " +
                "Machine Learningu i pilki noznej.";
            String textMS = "Michal Sakowicz \n" +
                "Student 3 roku Inzynierii Biomedycznej, czlonek Gradientu, czlonek IAESTE, sympatetyk lyzwiastwa " +
                "oraz trojboju silowego.";

            labelMW.Text = textMW;
            labelMS.Text = textMS;
        }
    }
}
