﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communicator
{
    static class Program
    {
        public static List<Form1> listOfForms = new List<Form1>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            Form1 form2 = new Form1();

            listOfForms.Add(form1);
            form1.formNumer = 0;
            listOfForms.Add(form2);
            form2.formNumer = 1;

            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = new Point(0, 50);
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(650, 50);

            Application.Run(new MultiFormContext(form1, form2));
        }
    }
}
