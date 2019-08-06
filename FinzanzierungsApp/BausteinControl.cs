using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public partial class BausteinControl : UserControl
    {
        public event EventHandler SmthChanged;

        public BausteinControl(FinazierungControl finazierung, IBaustein baustein)
        {
            InitializeComponent();

            Finazierung = finazierung;
            Baustein = baustein;

            Baustein.Calc();
            UpdateGui();
        }

        public IBaustein Baustein { get; }

        public string Title
        {
            get => Baustein.Title;
            set
            {
                if (Baustein.Title != value)
                {
                    Baustein.Title = value;
                    tbTitle.Text = value;
                }
            }
        }

        public int Monate { get; set; }
        public double GezahlteZinsen { get; set; }
        public DateTime EndDatum { get; set; }
        public FinazierungControl Finazierung { get; }

        public void UpdateGui()
        {
            tbTitle.Text = Baustein.Title;
            propertyGrid1.SelectedObject = Baustein;
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Baustein {this.Title} wirklich  Löschen?", "Löschen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                Finazierung.RemoveBaustein(this);
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            Finazierung.AddBaustein();
        }

        private void BtAnschluss_Click(object sender, EventArgs e)
        {
            var anschluss = Finazierung.AddBaustein();
            anschluss.Baustein.ParentBaustein = this.Baustein;
            anschluss.Title = "-> " + Title;
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            Baustein.Calc();
            propertyGrid1.Refresh();

            SmthChanged?.Invoke(this, EventArgs.Empty);
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            Title = tbTitle.Text;
        }
    }
}
