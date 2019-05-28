using DrenaSys.Models;
using GMap.NET.WindowsPresentation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DrenaSys.Windows
{
    /// <summary>
    /// Lógica interna para EquacoesDeChuva.xaml
    /// </summary>
    public partial class EquacoesDeChuva : Window
    {
        List<HidroEquation> listaEquacoes = new List<HidroEquation>();
        public EquacoesDeChuva()
        {


            //populate all equation on the list
            listaEquacoes.Add(new HidroEquation { local = "Curitiba_Prado_Velho", lat = -25.452936, lon = -49.252932, k = 5726.64, m = 0.159, to = 41, n = 1.041 });
            listaEquacoes.Add(new HidroEquation { local = "Bandeirantes", lat = -23.110899, lon = -50.370604, k = 1077.21, m = 0.157, to = 10, n = 0.781 });
            listaEquacoes.Add(new HidroEquation { local = "Cambará", lat = -23.040286, lon = -50.074660, k = 1772.96, m = 0.126, to = 17, n = 0.867 });
            listaEquacoes.Add(new HidroEquation { local = "Paranavaí", lat = -23.079319, lon = -52.463701, k = 2808.67, m = 0.104, to = 33, n = 0.93 });
            listaEquacoes.Add(new HidroEquation { local = "Umuarama", lat = -23.763544, lon = -53.303261, k = 1752.27, m = 0.148, to = 17, n = 0.840 });
            listaEquacoes.Add(new HidroEquation { local = "Cianorte", lat = -23.663665, lon = -52.609903, k = 2115.18, m = 0.145, to = 22, n = 0.849 });
            listaEquacoes.Add(new HidroEquation { local = "Apucarana", lat = -23.552513, lon = -51.451768, k = 1301.07, m = 0.177, to = 15, n = 0.836 });
            listaEquacoes.Add(new HidroEquation { local = "Lodrina", lat = -23.311033, lon = -51.166106, k = 3132.56, m = 0.0093, to = 30, n = 0.939 });
            listaEquacoes.Add(new HidroEquation { local = "Nova_Cantu", lat = -24.674285, lon = -52.570985, k = 2778.43, m = 0.149, to = 24, n = 0.94 });
            listaEquacoes.Add(new HidroEquation { local = "Tomazina", lat = -23.777770, lon = -49.956263, k = 2676.70, m = 0.149, to = 29, n = 0.931 });
            listaEquacoes.Add(new HidroEquation { local = "Telêmaco_Borba", lat = -24.326876, lon = -50.627746, k = 3235.19, m = 0.162, to = 24, n = 0.968 });
            listaEquacoes.Add(new HidroEquation { local = "Palmital", lat = -22.787414, lon = -50.218995, k = 1548.46, m = 0.130, to = 16, n = 0.834 });
            listaEquacoes.Add(new HidroEquation { local = "Ponta_Grossa", lat = -25.092613, lon = -50.160771, k = 1902.39, m = 0.152, to = 21, n = 0.893 });
            listaEquacoes.Add(new HidroEquation { local = "Cerro_Azul", lat = -24.825233, lon = -49.261832, k = 1625.55, m = 0.138, to = 18, n = 0.86 });
            listaEquacoes.Add(new HidroEquation { local = "Guaraqueçaba", lat = -25.297278, lon = -48.323630, k = 1479.78, m = 0.178, to = 19, n = 0.802 });
            listaEquacoes.Add(new HidroEquation { local = "Cascavel", lat = -24.955927, lon = -53.459935, k = 1062.92, m = 0.141, to = 5, n = 0.776 });
            listaEquacoes.Add(new HidroEquation { local = "Laranjeiras_do_Sul", lat = -25.403274, lon = -52.410562, k = 771.97, m = 0.148, to = 8, n = 0.726 });
            listaEquacoes.Add(new HidroEquation { local = "Guarapuava", lat = -25.390662, lon = -51.472214, k = 1039.68, m = 0.171, to = 10, n = 0.799 });
            listaEquacoes.Add(new HidroEquation { local = "Piraquara", lat = -25.445506, lon = -49.062235, k = 1537.80, m = 0.120, to = 17, n = 0.859 });
            listaEquacoes.Add(new HidroEquation { local = "Morretes", lat = -25.479186, lon = -48.830809, k = 2160.23, m = 0.155, to = 24, n = 0.890 });
            listaEquacoes.Add(new HidroEquation { local = "Teixeira_Soares", lat = -25.371840, lon = -50.459640, k = 959.18, m = 0.177, to = 9, n = 0.789 });
            listaEquacoes.Add(new HidroEquation { local = "Planalto", lat = -25.721297, lon = -53.764957, k = 1659.59, m = 0.156, to = 14, n = 0.840 });
            listaEquacoes.Add(new HidroEquation { local = "Francisco_Beltrão", lat = -26.078420, lon = -53.052459, k = 1012.28, m = 0.182, to = 9, n = 0.760 });
            listaEquacoes.Add(new HidroEquation { local = "Pato_Branco", lat = -26.228372, lon = -52.673032, k = 879.43, m = 0.152, to = 9, n = 0.732 });
            listaEquacoes.Add(new HidroEquation { local = "Clevelândia", lat = -26.407141, lon = -52.358882, k = 2553.88, m = 0.166, to = 24, n = 0.917 });
            listaEquacoes.Add(new HidroEquation { local = "Ivaiporã", lat = -24.243957, lon = -51.673615, k = 676.71, m = 0.158, to = 1, n = 0.726 });
            listaEquacoes.Add(new HidroEquation { local = "Santa_Izabel_do_Ivaí", lat = -23.002769, lon = -53.190239, k = 1824.73, m = 0.166, to = 17, n = 0.892 });
            listaEquacoes.Add(new HidroEquation { local = "Tibagi", lat = -24.514911, lon = -50.413190, k = 1592.58, m = 0.136, to = 11, n = 0.882 });
            listaEquacoes.Add(new HidroEquation { local = "Palmas", lat = -26.484704, lon = -51.988148, k = 1303.47, m = 0.126, to = 12, n = 0.815 });
            listaEquacoes.Add(new HidroEquation { local = "São_Miguel_do_Iguaçu", lat = -25.344515, lon = -54.236698, k = 2886.69, m = 0.124, to = 26, n = 0.927 });
            listaEquacoes.Add(new HidroEquation { local = "Araucária", lat = -25.585960, lon = -49.401466, k = 2505.53, m = 0.177, to = 13, n = 0.988 });
            listaEquacoes.Add(new HidroEquation { local = "Antonina", lat = -25.432007, lon = -48.714522, k = 5209.55, m = 0.160, to = 57, n = 0.978 });
            InitializeComponent();
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            // choose your provider here
            mapView.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            mapView.MinZoom = 2;
            mapView.MaxZoom = 17;
            // whole world zoom
            mapView.Zoom = 10;
            mapView.ShowCenter = false;
            mapView.Position = new GMap.NET.PointLatLng(-23.086737, -52.459092);
            // lets the map use the mousewheel to zoom
            mapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            // lets the user drag the map
            mapView.CanDragMap = true;
            // lets the user drag the map with the left mouse button
            mapView.DragButton = MouseButton.Middle;

            if (this.CheckForInternetConnection() == false)
            {
                System.Windows.Forms.MessageBox.Show("Sem conexão com a internet, o mapa funcionará somente nas áreas \n já exploradas, caso não visualize o conteúdo, conecte-se à internet e recarregue esta janela!");
            }

            for (int i = 0; i < listaEquacoes.Count(); i++)
            {
                Ellipse ellipseMarker = new Ellipse
                {
                    Stroke = System.Windows.Media.Brushes.Black,
                    Fill = System.Windows.Media.Brushes.DarkBlue,
                    Width = 21,
                    Name = listaEquacoes[i].local,
                    Height = 21
                };
                ellipseMarker.MouseLeftButtonDown += Ellip_MouseLeftButtonDown;
                GMapMarker gmap = new GMapMarker(new GMap.NET.PointLatLng(listaEquacoes[i].lat, listaEquacoes[i].lon));
                gmap.Shape = ellipseMarker;
                mapView.Markers.Add(gmap);
            }
        }
        private void Ellip_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse cb = (Ellipse)sender;
            System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Deseja utilizar a equação de " + cb.Name.Replace('_', ' ') + "?", "Informativo", MessageBoxButtons.YesNo);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                GMapMarker mark1 = new GMapMarker(new GMap.NET.PointLatLng(-23.081227, -52.460605));
                HidroEquation eq = listaEquacoes.Find(i => i.local.Equals(cb.Name));
                pk.Text = Convert.ToString(eq.k);
                pm.Text = Convert.ToString(eq.m);
                to.Text = Convert.ToString(eq.to);
                pn.Text = Convert.ToString(eq.n);
                nomeCidade.Text = Convert.ToString(eq.local);


            }
            else if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                //do something else
            }
        }

        private void clearFields()
        {
            pk.Text = "";
            pm.Text = "";
            to.Text = "";
            pn.Text = "";
            txtDesniv.Text = "";
            txtTalv.Text = "";
            cboxMetodos.Text = "";
            txtTr.Text = "";
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            this.clearFields();
        }
        private bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        private double calculateTcByKirpich(string talv, string delt)
        {
            double talvegue = Convert.ToDouble(talv);
            double delta= Convert.ToDouble(delt);
            return Math.Round((0.95 * Math.Pow((Math.Pow(talvegue, 3) / delta), 0.385)),3);
        }
        private double calculateTcByKirpichModified(string talv, string delt)
        {
            double talvegue = Convert.ToDouble(talv);
            double delta = Convert.ToDouble(delt);
            return Math.Round((1.42 * Math.Pow((Math.Pow(talvegue, 3) / delta), 0.385)), 3);
        }
        
        private double calculateRain()
        {
            double k = Convert.ToDouble(pk.Text);
            double Tr = Convert.ToDouble(txtTr.Text);
            double m = Convert.ToDouble(pm.Text);
            double n = Convert.ToDouble(pn.Text);
            double t = Convert.ToDouble(txtTempoFinal.Text);
            double To = Convert.ToDouble(to.Text);

            double precipitacao = Math.Round((k * Math.Pow(Tr,m))/Math.Pow((t+To),n),3);
            return precipitacao;
        }
        private void BtnCalc_Click(object sender, RoutedEventArgs e)
        {
            Regex reg = new Regex(@"[.;!@#$%^&*()_+/*-+?><:{ }a - z A - Z]");
            Match match = reg.Match(txtTalv.Text + txtDesniv.Text + txtTr.Text);
            if (!match.Success){
                if (this.IsDataCorrectlyInserted() == true)
                {
                    switch (cboxMetodos.Text)
                    {
                        case "Kirpich":
                            txtTempoFinal.Text = Convert.ToString(calculateTcByKirpich(txtTalv.Text, txtDesniv.Text) * 60);
                            txtPrecipitacaoFinal.Text = Convert.ToString((this.calculateRain()));
                            break;
                        case "Kirpich modificada":
                            txtTempoFinal.Text = Convert.ToString(calculateTcByKirpichModified(txtTalv.Text, txtDesniv.Text) * 60);
                            txtPrecipitacaoFinal.Text = Convert.ToString((this.calculateRain()));
                            break;
                    }
                }
                else
                {
                    System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Existem campos sem informação, certifique-se de inserir os dados necessários.", "Erro", MessageBoxButtons.OK);
                }
            } else
            {
                System.Windows.Forms.MessageBox.Show("Foram detectados caracteres ilegais nos campos, em campos numéricos somente são permitidos números e virgulas como separador");
            }
 


            //if (cboxMetodos.Text.Equals("Kirpich"))
            //{
            //    double answer = (this.calculateTcByKirpich(txtTalv.Text, txtDesniv.Text))*60;
            //    System.Windows.Forms.MessageBox.Show(Convert.ToString(answer));
            //} else if (cboxMetodos.Text.Equals("Kirpich modificada"))
            //{
            //    double answer = (this.calculateTcByKirpichModified(txtTalv.Text, txtDesniv.Text)) * 60;
            //    System.Windows.Forms.MessageBox.Show(Convert.ToString(answer));
            //}
        }

        private bool IsDataCorrectlyInserted()
        {
            if (txtDesniv.Text.Equals("") || txtTalv.Text.Equals("") || pk.Text.Equals("") || pm.Text.Equals("") || to.Text.Equals("") || pn.Text.Equals("") || txtTr.Text.Equals(""))
            {
                return false;
            } else return true;
        }

        public void CheckLetter(Object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar)||!char.IsNumber(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            if ( e.KeyChar == (char)Keys.Back || e.KeyChar == ',' || char.IsNumber(e.KeyChar))
            {

                // These characters may pass
                e.Handled = false;
            }
            else
            {
                // Everything that is not a letter, nor a backspace nor a space will be blocked
                e.Handled = true;
            }

        }

        private void BtnExportReport_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Relatório em XLS | *.xlsx";
            save.Title = "Selecione o local para salvar o relatório";
            if (pk.Text.Equals("") || pm.Text.Equals("") || to.Text.Equals("") || pn.Text.Equals("") || nomeCidade.Text.Equals("") || pm.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Para exportar o relatório no mínimo é necessário a inserção dos parâmetros I.D.F por seleção no mapa");
            }
            else
            {
                // Abre o dialogo
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Copia a planilha padrão para a pasta selecionada
                    string pastaSelecionada = System.IO.Path.GetDirectoryName(save.FileName);
                    if (!File.Exists(save.FileName))
                    {
                        File.Copy(System.AppDomain.CurrentDomain.BaseDirectory + "Resources/EquacoesChuva.xlsx", save.FileName);

                        // Get the app
                        Excel.Application app = new Excel.Application();

                        // Run the process in hidden state
                        app.Visible = false;

                        // Open the workbook with given path
                        Excel.Workbook workbook = app.Workbooks.Open(save.FileName, 0, false);

                        //Open the worksheet with hardcoded integer number
                        Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                        // Just insert and test
                        worksheet.Cells[5, 10] = nomeCidade.Text;
                        worksheet.Cells[6, 10] = pk.Text;
                        worksheet.Cells[8, 10] = pm.Text;
                        worksheet.Cells[7, 10] = pn.Text;
                        worksheet.Cells[9, 10] = to.Text;
                        worksheet.Cells[10, 10] = txtTalv.Text;
                        worksheet.Cells[11, 10] = txtDesniv.Text;
                        worksheet.Cells[12, 10] = cboxMetodos.Text;
                        worksheet.Cells[13, 10] = txtTr.Text;
                        worksheet.Cells[14, 10] = txtTempoFinal.Text;
                        worksheet.Cells[1, 1] = txtPrecipitacaoFinal.Text;


                        

                        // Save the workbook
                        workbook.Save();

                        // Close the workbook
                        workbook.Close(1);

                        // Close the application - if it not got closed the upcoming open of this file will be readonly, pay attention
                        app.Quit();
                        System.Diagnostics.Process.Start(save.FileName);
                    }
                    else
                    {
                        File.Delete(save.FileName);
                        File.Copy(System.AppDomain.CurrentDomain.BaseDirectory + "Resources/EquacoesChuva.xlsx", save.FileName);
                        // Get the app
                        Excel.Application app = new Excel.Application();

                        // Run the process in hidden state
                        app.Visible = false;

                        // Open the workbook with given path
                        Excel.Workbook workbook = app.Workbooks.Open(save.FileName, 0, false);

                        //Open the worksheet with hardcoded integer number
                        Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                        // Just insert and test
                        worksheet.Cells[5, 10] = nomeCidade.Text;
                        worksheet.Cells[6, 10] = pk.Text;
                        worksheet.Cells[8, 10] = pm.Text;
                        worksheet.Cells[7, 10] = pn.Text;
                        worksheet.Cells[9, 10] = to.Text;
                        worksheet.Cells[10, 10] = txtTalv.Text;
                        worksheet.Cells[11, 10] = txtDesniv.Text;
                        worksheet.Cells[12, 10] = cboxMetodos.Text;
                        worksheet.Cells[13, 10] = txtTr.Text;
                        worksheet.Cells[14, 10] = txtTempoFinal.Text;
                        worksheet.Cells[1, 1] = txtPrecipitacaoFinal.Text;




                        // Save the workbook
                        workbook.Save();

                        // Close the workbook
                        workbook.Close(1);

                        // Close the application - if it not got closed the upcoming open of this file will be readonly, pay attention
                        app.Quit();
                        System.Diagnostics.Process.Start(save.FileName);
                    }

                }
            }

            


        }
    }
    }

