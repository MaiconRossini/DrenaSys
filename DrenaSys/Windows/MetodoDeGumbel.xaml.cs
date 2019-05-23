using System;
using System.Collections.ObjectModel;
using System.Windows;
using DrenaSys.Models;

namespace DrenaSys.Windows
{
    /// <summary>
    /// Lógica interna para MetodoDeGumbel.xaml
    /// </summary>
    public partial class MetodoDeGumbel : Window
    {
        ObservableCollection<Precipitacao> listaP;
        
        public MetodoDeGumbel()
        {
            this.DataContext = this;
            InitializeComponent();
            listaP = new ObservableCollection<Precipitacao>();
            Precipitacao pre1 = new Precipitacao(10,100);
            listaP.Add(pre1);
            Precipitacao pre2 = new Precipitacao(15,100.15);
            listaP.Add(pre2);
            Precipitacao pre3 = new Precipitacao(15,100.58);
            listaP.Add(pre3);
            dataGrids.ItemsSource = listaP;
        }

    }
}
