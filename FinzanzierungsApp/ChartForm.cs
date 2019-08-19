using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace FinzanzierungsApp
{
    public partial class ChartForm : Form
    {
        public ChartForm(Vergleich vergleich)
        {
            InitializeComponent();

            Vergleich = vergleich;
        }

        public Vergleich Vergleich { get; }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            InitCharts();
        }

        private void InitCharts()
        {
            var anschlussZinsenArr = new List<double>();
            for (double aZins = 0.4; aZins < 7.0; aZins += 0.1)
            {
                anschlussZinsenArr.Add(aZins);
            }

            var series = new SeriesCollection();

            foreach (var v in Vergleich.Variants)
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
    }
}
