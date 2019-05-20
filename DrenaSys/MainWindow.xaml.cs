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

        private void TreeGrupoEstudosHidrologicos_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
 
        }

        private void TreeChildEquacoes_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void TreeChildHidrograma_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
