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
        private Color unsafeColor = Color.OrangeRed;

        public event EventHandler SmthChanged;

        public BausteinControl(VarianteControl finazierung, IBaustein baustein)
        {
            InitializeComponent();

            Finazierung = finazierung;
            Baustein = baustein;

            Baustein.Calc();
            Baustein.SmthChanged += Baustein_SmthChanged;
            UpdateGui();
        }

        private void Baustein_SmthChanged(object sender, EventArgs e)
        {
            propertyGrid1.Refresh();
            this.BackColor = Baustein.Unsicher ? unsafeColor : Color.FromKnownColor(KnownColor.Control);

            SmthChanged?.Invoke(this, EventArgs.Empty);
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
        public VarianteControl Finazierung { get; }

        public void UpdateGui()
        {
            tbTitle.Text = Baustein.Title;
            propertyGrid1.SelectedObject = Baustein;

            this.BackColor = Baustein.Unsicher ? unsafeColor : Color.FromKnownColor(KnownColor.Control);
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
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            Title = tbTitle.Text;
        }
    }
}
