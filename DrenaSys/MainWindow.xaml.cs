using DrenaSys.Windows;
using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Animation;

namespace DrenaSys
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsMousePressed { get; private set; }

        public MainWindow()
        {
            // Seta a aplicação toda para PT-BR
            Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement),
             new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
            InitializeComponent();
        }

        private void TreeChildEquacoes_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            EquacoesDeChuva eq = new EquacoesDeChuva();
            eq.Show();
            
        }

        private void TreeGumbel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MetodoDeGumbel mg = new MetodoDeGumbel();
            mg.Show();
        }
    }
}

