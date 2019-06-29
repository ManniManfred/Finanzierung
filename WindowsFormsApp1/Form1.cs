using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            blatt1.StartSchuld = 270000;
            blatt1.Rate = 951.36;
            blatt1.ZinsenProJahr = 2.01;
        }

    }
}
