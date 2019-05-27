using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using DrenaSys.Models;

namespace DrenaSys.Windows
{
    /// <summary>
    /// Lógica interna para MetodoDeGumbel.xaml
    /// </summary>
    public partial class MetodoDeGumbel : Window
    {
        public List<yn> ynTable = new List<yn>(100);
        public List<Sn> snTable = new List<Sn>(100);
        ObservableCollection<Precipitacao> listaP;
        GumbelMethods gumb;
        public MetodoDeGumbel()
        {
            this.snTable.Add(new Sn { N = 10, SnValue = 0.9496 });
            this.snTable.Add(new Sn { N = 11, SnValue = 0.9676 });
            this.snTable.Add(new Sn { N = 12, SnValue = 0.9833 });
            this.snTable.Add(new Sn { N = 13, SnValue = 0.9971 });
            this.snTable.Add(new Sn { N = 14, SnValue = 1.0095 });
            this.snTable.Add(new Sn { N = 15, SnValue = 1.0206 });
            this.snTable.Add(new Sn { N = 16, SnValue = 1.0316 });
            this.snTable.Add(new Sn { N = 17, SnValue = 1.0411 });
            this.snTable.Add(new Sn { N = 18, SnValue = 1.0493 });
            this.snTable.Add(new Sn { N = 19, SnValue = 1.0565 });
            this.snTable.Add(new Sn { N = 20, SnValue = 1.0628 });
            this.snTable.Add(new Sn { N = 21, SnValue = 1.0696 });
            this.snTable.Add(new Sn { N = 22, SnValue = 1.0754 });
            this.snTable.Add(new Sn { N = 23, SnValue = 1.0811 });
            this.snTable.Add(new Sn { N = 24, SnValue = 1.0864 });
            this.snTable.Add(new Sn { N = 25, SnValue = 1.0915 });
            this.snTable.Add(new Sn { N = 26, SnValue = 1.0961 });
            this.snTable.Add(new Sn { N = 27, SnValue = 1.1004 });
            this.snTable.Add(new Sn { N = 28, SnValue = 1.1047 });
            this.snTable.Add(new Sn { N = 29, SnValue = 1.1086 });
            this.snTable.Add(new Sn { N = 30, SnValue = 1.1124 });
            this.snTable.Add(new Sn { N = 31, SnValue = 1.1159 });
            this.snTable.Add(new Sn { N = 32, SnValue = 1.1193 });
            this.snTable.Add(new Sn { N = 33, SnValue = 1.1226 });
            this.snTable.Add(new Sn { N = 34, SnValue = 1.1255 });
            this.snTable.Add(new Sn { N = 35, SnValue = 1.1285 });
            this.snTable.Add(new Sn { N = 36, SnValue = 1.1313 });
            this.snTable.Add(new Sn { N = 37, SnValue = 1.1339 });
            this.snTable.Add(new Sn { N = 38, SnValue = 1.1363 });
            this.snTable.Add(new Sn { N = 39, SnValue = 1.1388 });
            this.snTable.Add(new Sn { N = 40, SnValue = 1.1413 });
            this.snTable.Add(new Sn { N = 41, SnValue = 1.1436 });
            this.snTable.Add(new Sn { N = 42, SnValue = 1.1458 });
            this.snTable.Add(new Sn { N = 43, SnValue = 1.1480 });
            this.snTable.Add(new Sn { N = 44, SnValue = 1.1499 });
            this.snTable.Add(new Sn { N = 45, SnValue = 1.1519 });
            this.snTable.Add(new Sn { N = 46, SnValue = 1.1538 });
            this.snTable.Add(new Sn { N = 47, SnValue = 1.1557 });
            this.snTable.Add(new Sn { N = 48, SnValue = 1.1574 });
            this.snTable.Add(new Sn { N = 49, SnValue = 1.1590 });
            this.snTable.Add(new Sn { N = 50, SnValue = 1.1607 });
            this.snTable.Add(new Sn { N = 51, SnValue = 1.1623 });
            this.snTable.Add(new Sn { N = 52, SnValue = 1.1638 });
            this.snTable.Add(new Sn { N = 53, SnValue = 1.1658 });
            this.snTable.Add(new Sn { N = 54, SnValue = 1.1667 });
            this.snTable.Add(new Sn { N = 55, SnValue = 1.1681 });
            this.snTable.Add(new Sn { N = 56, SnValue = 1.1696 });
            this.snTable.Add(new Sn { N = 57, SnValue = 1.1708 });
            this.snTable.Add(new Sn { N = 58, SnValue = 1.1721 });
            this.snTable.Add(new Sn { N = 59, SnValue = 1.1734 });
            this.snTable.Add(new Sn { N = 60, SnValue = 1.1747 });
            this.snTable.Add(new Sn { N = 61, SnValue = 1.1759 });
            this.snTable.Add(new Sn { N = 62, SnValue = 1.1770 });
            this.snTable.Add(new Sn { N = 63, SnValue = 1.1782 });
            this.snTable.Add(new Sn { N = 64, SnValue = 1.1793 });
            this.snTable.Add(new Sn { N = 65, SnValue = 1.1803 });
            this.snTable.Add(new Sn { N = 66, SnValue = 1.1814 });
            this.snTable.Add(new Sn { N = 67, SnValue = 1.1824 });
            this.snTable.Add(new Sn { N = 68, SnValue = 1.1834 });
            this.snTable.Add(new Sn { N = 69, SnValue = 1.1844 });
            this.snTable.Add(new Sn { N = 70, SnValue = 1.1854 });
            this.snTable.Add(new Sn { N = 71, SnValue = 1.1863 });
            this.snTable.Add(new Sn { N = 72, SnValue = 1.1873 });
            this.snTable.Add(new Sn { N = 73, SnValue = 1.1881 });
            this.snTable.Add(new Sn { N = 74, SnValue = 1.1890 });
            this.snTable.Add(new Sn { N = 75, SnValue = 1.1898 });
            this.snTable.Add(new Sn { N = 76, SnValue = 1.1906 });
            this.snTable.Add(new Sn { N = 77, SnValue = 1.1915 });
            this.snTable.Add(new Sn { N = 78, SnValue = 1.1923 });
            this.snTable.Add(new Sn { N = 79, SnValue = 1.1930 });
            this.snTable.Add(new Sn { N = 80, SnValue = 1.1938 });
            this.snTable.Add(new Sn { N = 81, SnValue = 1.1945 });
            this.snTable.Add(new Sn { N = 82, SnValue = 1.1953 });
            this.snTable.Add(new Sn { N = 83, SnValue = 1.1959 });
            this.snTable.Add(new Sn { N = 84, SnValue = 1.1967 });
            this.snTable.Add(new Sn { N = 85, SnValue = 1.1973 });
            this.snTable.Add(new Sn { N = 86, SnValue = 1.1980 });
            this.snTable.Add(new Sn { N = 87, SnValue = 1.1987 });
            this.snTable.Add(new Sn { N = 88, SnValue = 1.1994 });
            this.snTable.Add(new Sn { N = 89, SnValue = 1.2001 });
            this.snTable.Add(new Sn { N = 90, SnValue = 1.2007 });
            this.snTable.Add(new Sn { N = 91, SnValue = 1.2013 });
            this.snTable.Add(new Sn { N = 92, SnValue = 1.2020 });
            this.snTable.Add(new Sn { N = 93, SnValue = 1.2026 });
            this.snTable.Add(new Sn { N = 94, SnValue = 1.2032 });
            this.snTable.Add(new Sn { N = 95, SnValue = 1.2038 });
            this.snTable.Add(new Sn { N = 96, SnValue = 1.2044 });
            this.snTable.Add(new Sn { N = 97, SnValue = 1.2049 });
            this.snTable.Add(new Sn { N = 98, SnValue = 1.2055 });
            this.snTable.Add(new Sn { N = 99, SnValue = 1.2060 });
            this.snTable.Add(new Sn { N = 100, SnValue = 1.2065 });

            this.ynTable.Add(new yn { N = 10, ynValue = 0.4952 });
            this.ynTable.Add(new yn { N = 11, ynValue = 0.4996 });
            this.ynTable.Add(new yn { N = 12, ynValue = 0.5035 });
            this.ynTable.Add(new yn { N = 13, ynValue = 0.5070 });
            this.ynTable.Add(new yn { N = 14, ynValue = 0.5100 });
            this.ynTable.Add(new yn { N = 15, ynValue = 0.5128 });
            this.ynTable.Add(new yn { N = 16, ynValue = 0.5157 });
            this.ynTable.Add(new yn { N = 17, ynValue = 0.5181 });
            this.ynTable.Add(new yn { N = 18, ynValue = 0.5202 });
            this.ynTable.Add(new yn { N = 19, ynValue = 0.5220 });
            this.ynTable.Add(new yn { N = 20, ynValue = 0.5236 });
            this.ynTable.Add(new yn { N = 21, ynValue = 0.5252 });
            this.ynTable.Add(new yn { N = 22, ynValue = 0.5268 });
            this.ynTable.Add(new yn { N = 23, ynValue = 0.5283 });
            this.ynTable.Add(new yn { N = 24, ynValue = 0.5296 });
            this.ynTable.Add(new yn { N = 25, ynValue = 0.5309 });
            this.ynTable.Add(new yn { N = 26, ynValue = 0.5320 });
            this.ynTable.Add(new yn { N = 27, ynValue = 0.5332 });
            this.ynTable.Add(new yn { N = 28, ynValue = 0.5343 });
            this.ynTable.Add(new yn { N = 29, ynValue = 0.5353 });
            this.ynTable.Add(new yn { N = 30, ynValue = 0.5362 });
            this.ynTable.Add(new yn { N = 31, ynValue = 0.5371 });
            this.ynTable.Add(new yn { N = 32, ynValue = 0.5380 });
            this.ynTable.Add(new yn { N = 33, ynValue = 0.5388 });
            this.ynTable.Add(new yn { N = 34, ynValue = 0.5396 });
            this.ynTable.Add(new yn { N = 35, ynValue = 0.5402 });
            this.ynTable.Add(new yn { N = 36, ynValue = 0.5410 });
            this.ynTable.Add(new yn { N = 37, ynValue = 0.5418 });
            this.ynTable.Add(new yn { N = 38, ynValue = 0.5424 });
            this.ynTable.Add(new yn { N = 39, ynValue = 0.5430 });
            this.ynTable.Add(new yn { N = 40, ynValue = 0.5436 });
            this.ynTable.Add(new yn { N = 41, ynValue = 0.5442 });
            this.ynTable.Add(new yn { N = 42, ynValue = 0.5448 });
            this.ynTable.Add(new yn { N = 43, ynValue = 0.5453 });
            this.ynTable.Add(new yn { N = 44, ynValue = 0.5458 });
            this.ynTable.Add(new yn { N = 45, ynValue = 0.5463 });
            this.ynTable.Add(new yn { N = 46, ynValue = 0.5468 });
            this.ynTable.Add(new yn { N = 47, ynValue = 0.5473 });
            this.ynTable.Add(new yn { N = 48, ynValue = 0.5477 });
            this.ynTable.Add(new yn { N = 49, ynValue = 0.5481 });
            this.ynTable.Add(new yn { N = 50, ynValue = 0.5485 });
            this.ynTable.Add(new yn { N = 51, ynValue = 0.5489 });
            this.ynTable.Add(new yn { N = 52, ynValue = 0.5493 });
            this.ynTable.Add(new yn { N = 53, ynValue = 0.5497 });
            this.ynTable.Add(new yn { N = 54, ynValue = 0.5501 });
            this.ynTable.Add(new yn { N = 55, ynValue = 0.5504 });
            this.ynTable.Add(new yn { N = 56, ynValue = 0.5508 });
            this.ynTable.Add(new yn { N = 57, ynValue = 0.5511 });
            this.ynTable.Add(new yn { N = 58, ynValue = 0.5515 });
            this.ynTable.Add(new yn { N = 59, ynValue = 0.5518 });
            this.ynTable.Add(new yn { N = 60, ynValue = 0.5521 });
            this.ynTable.Add(new yn { N = 61, ynValue = 0.5524 });
            this.ynTable.Add(new yn { N = 62, ynValue = 0.5527 });
            this.ynTable.Add(new yn { N = 63, ynValue = 0.5530 });
            this.ynTable.Add(new yn { N = 64, ynValue = 0.5533 });
            this.ynTable.Add(new yn { N = 65, ynValue = 0.5535 });
            this.ynTable.Add(new yn { N = 66, ynValue = 0.5538 });
            this.ynTable.Add(new yn { N = 67, ynValue = 0.5540 });
            this.ynTable.Add(new yn { N = 68, ynValue = 0.5543 });
            this.ynTable.Add(new yn { N = 69, ynValue = 0.5545 });
            this.ynTable.Add(new yn { N = 70, ynValue = 0.5548 });
            this.ynTable.Add(new yn { N = 71, ynValue = 0.5550 });
            this.ynTable.Add(new yn { N = 72, ynValue = 0.5552 });
            this.ynTable.Add(new yn { N = 73, ynValue = 0.5555 });
            this.ynTable.Add(new yn { N = 74, ynValue = 0.5557 });
            this.ynTable.Add(new yn { N = 75, ynValue = 0.5559 });
            this.ynTable.Add(new yn { N = 76, ynValue = 0.5561 });
            this.ynTable.Add(new yn { N = 77, ynValue = 0.5563 });
            this.ynTable.Add(new yn { N = 78, ynValue = 0.5565 });
            this.ynTable.Add(new yn { N = 79, ynValue = 0.5567 });
            this.ynTable.Add(new yn { N = 80, ynValue = 0.5569 });
            this.ynTable.Add(new yn { N = 81, ynValue = 0.5570 });
            this.ynTable.Add(new yn { N = 82, ynValue = 0.5572 });
            this.ynTable.Add(new yn { N = 83, ynValue = 0.5574 });
            this.ynTable.Add(new yn { N = 84, ynValue = 0.5576 });
            this.ynTable.Add(new yn { N = 85, ynValue = 0.5578 });
            this.ynTable.Add(new yn { N = 86, ynValue = 0.5580 });
            this.ynTable.Add(new yn { N = 87, ynValue = 0.5581 });
            this.ynTable.Add(new yn { N = 88, ynValue = 0.5583 });
            this.ynTable.Add(new yn { N = 89, ynValue = 0.5585 });
            this.ynTable.Add(new yn { N = 90, ynValue = 0.5586 });
            this.ynTable.Add(new yn { N = 91, ynValue = 0.5587 });
            this.ynTable.Add(new yn { N = 92, ynValue = 0.5589 });
            this.ynTable.Add(new yn { N = 93, ynValue = 0.5591 });
            this.ynTable.Add(new yn { N = 94, ynValue = 0.5592 });
            this.ynTable.Add(new yn { N = 95, ynValue = 0.5593 });
            this.ynTable.Add(new yn { N = 96, ynValue = 0.5595 });
            this.ynTable.Add(new yn { N = 97, ynValue = 0.5596 });
            this.ynTable.Add(new yn { N = 98, ynValue = 0.5598 });
            this.ynTable.Add(new yn { N = 99, ynValue = 0.5599 });
            this.ynTable.Add(new yn { N = 100, ynValue = 0.5600 });
            gumb = new GumbelMethods();
            this.DataContext = this;
            InitializeComponent();
            listaP = new ObservableCollection<Precipitacao>();
            listaP.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(CollectionChangedMethod);

            dataGrids.ItemsSource = listaP;
        }



        private void CollectionChangedMethod(object sender, NotifyCollectionChangedEventArgs e)
        {

            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                            if (listaP.Count > 1)
            {
                txtNumeroAmostras.Text = Convert.ToString(listaP.Count);
                double totalPrecip = 0;
                for (int i = 0; i < listaP.Count; i++)
                {
                    totalPrecip = totalPrecip + listaP[i].MaximaAnual;
                }
                this.txtMedia.Text = Convert.ToString((Math.Round(totalPrecip / listaP.Count, 3)));

            }

            if (txtTR != null && txtTR.Text != "")
            {
                double itr = Convert.ToDouble(Convert.ToInt16(txtTR.Text));
                double itr1 = itr - 1.00;
                txtYt.Text = Convert.ToString(Math.Round(Math.Log(Math.Log(itr / itr1)), 5));
            }

            if (listaP.Count > 9)
            {
                txtyn.Text = Convert.ToString(ynTable.Find(x => x.N == listaP.Count).ynValue);
            } else
            {
                txtyn.Text = "N deve ser > 10";
            }

            if (listaP.Count > 9)
            {
                txtSn.Text = Convert.ToString(snTable.Find(x => x.N == listaP.Count).SnValue);
            }
            else
            {
                txtSn.Text = "N deve ser > 10";
            }
            }
            if (e.Action == NotifyCollectionChangedAction.Replace)
            {

            }
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {

            }
            if (e.Action == NotifyCollectionChangedAction.Move)
            {


            }
        }


        private void Principal_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {

            if (listaP.Count > 1)
            {
                txtNumeroAmostras.Text = Convert.ToString(listaP.Count);
                double totalPrecip = 0;
                for (int i = 0; i < listaP.Count; i++)
                {
                    totalPrecip = totalPrecip + listaP[i].MaximaAnual;
                }
                this.txtMedia.Text = Convert.ToString((Math.Round(totalPrecip / listaP.Count, 3)));

            }

            if (txtTR != null && txtTR.Text != "")
            {
                double itr = Convert.ToDouble(Convert.ToInt16(txtTR.Text));
                double itr1 = itr - 1.00;
                txtYt.Text = Convert.ToString(-Math.Round(Math.Log(Math.Log(itr / itr1)), 5));
            }

            if (listaP.Count > 9)
            {
                txtyn.Text = Convert.ToString(ynTable.Find(x => x.N == listaP.Count).ynValue);
            } else
            {
                txtyn.Text = "N deve ser > 10";
            }

            if (listaP.Count > 9)
            {
                txtSn.Text = Convert.ToString(snTable.Find(x => x.N == listaP.Count).SnValue);
            }
            else
            {
                txtSn.Text = "N deve ser > 10";
            }

            if ( listaP.Count > 9 && !txtYt.Text.Equals(""))
            {
                if (!txtyn.Text.Equals("") && !txtSn.Text.Equals(""))
                {
                    double yt = Convert.ToDouble(txtYt.Text);
                    double yn = Convert.ToDouble(txtyn.Text);
                    double sn = Convert.ToDouble(txtSn.Text);

                    txtK.Text = Convert.ToString(Math.Round(((yt - yn) / sn), 5));
                }

            }

            if(listaP.Count > 9)
            {
                List<double> precipt = new List<double>();
                foreach (Precipitacao x in listaP)
                {
                    precipt.Add(x.MaximaAnual);
                }
                    txtDp.Text = Convert.ToString(Math.Round(StandardDeviation(precipt),6));
            }

            if (listaP.Count > 9 && !txtK.Text.Equals("") && !txtYt.Equals("") && !txtyn.Equals("") && !txtSn.Equals("") && !txtMedia.Equals("") && !txtDp.Equals(""))
            {
                double xm = Convert.ToDouble(txtMedia.Text);
                double k = Convert.ToDouble(txtK.Text);
                double dp = Convert.ToDouble(txtDp.Text);
                txtMaxPrecipt.Text = Convert.ToString(Math.Round((xm+(k*dp)), 2));
            }
        }

        public double StandardDeviation(List<double> values)
        {
            double avg = values.Average();
            return Math.Sqrt(values.Average(v => Math.Pow(v - avg, 2)));
        }

        private void BtnExportReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClearFields_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
