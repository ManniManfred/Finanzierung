using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml.Linq;
using LiveCharts;
using LiveCharts.Wpf;

namespace FinzanzierungsApp
{
    public partial class ChartForm : Form
    {
        private List<double> anschlussZinsenArr;
        private bool needRefresh;

        public ChartForm(Vergleich vergleich)
        {
            InitializeComponent();

            Vergleich = vergleich;

            anschlussZinsenArr = new List<double>();
            for (double aZins = 0.4; aZins < 7.0; aZins += 0.1)
            {
                anschlussZinsenArr.Add(aZins);
            }

            InitChart();
        }

        public Vergleich Vergleich { get; }


        private void ChartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                needRefresh = true;
            }
        }

        private Vergleich Copy()
        {
            var xClone = new XElement("Vergleich");
            Vergleich.ToXml(xClone);
            var clone = new Vergleich();
            clone.FromXml(xClone);

            return clone;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            RefreshData();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (needRefresh)
                RefreshData();
        }

        private void InitChart()
        {
            var xAxis = new Axis();
            xAxis.Title = "Anschluss Zins";
            xAxis.Labels = new List<string>();

            foreach (var aZins in anschlussZinsenArr)
            {
                xAxis.Labels.Add(aZins.ToString("N1") + " %");
            }

            cartesianChart1.AxisX.Add(xAxis);
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Zinsen",
                LabelFormatter = value => value.ToString("C")
            });
        }

        private void RefreshData()
        {
            var copy = Copy();
            var series = new SeriesCollection();

            foreach (var v in copy.Variants)
            {
                var serie = new LineSeries();
                serie.Title = v.Title;
                serie.Stroke = new SolidColorBrush(Color.FromArgb(v.Farbe.A, v.Farbe.R, v.Farbe.G, v.Farbe.B));

                var values = new ChartValues<double>();
                foreach (var aZins in anschlussZinsenArr)
                {
                    v.SetUnsicherenZins(aZins);
                    v.CalcSummen();
                    values.Add(v.GezahlteZinsen);
                }

                serie.Values = values;
                series.Add(serie);
            }
            cartesianChart1.Series = series;

            needRefresh = false;
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
