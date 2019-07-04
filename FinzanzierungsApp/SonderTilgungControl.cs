using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinzanzierungsApp
{
    public partial class SonderTilgungControl : UserControl
    {
        private readonly BindingList<SonderTilgung> tilgungs = new BindingList<SonderTilgung>();

        public SonderTilgungControl()
        {
            InitializeComponent();

            lbItems.DataSource = tilgungs;
        }

        public BindingList<SonderTilgung> Tilgungs => tilgungs;
        
        private void BtAdd_Click(object sender, EventArgs e)
        {
            tilgungs.Add(new SonderTilgung() { Datum = dateTimePicker1.Value, Betrag = double.Parse(tbBetrag.Text) });
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedItem != null)
                tilgungs.Remove((SonderTilgung)lbItems.SelectedItem);
        }

        private void LbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tilgung = lbItems.SelectedItem as SonderTilgung;
            if (tilgung != null)
            {
                tbBetrag.Text = tilgung.Betrag.ToString("N2");
                dateTimePicker1.Value = tilgung.Datum;
            }
        }
    }
}
