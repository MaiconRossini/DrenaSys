using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrenaSys.Models
{
    public class Precipitacao : INotifyPropertyChanged
    {
        private int ano;
        private double maximaAnual;
        public event PropertyChangedEventHandler PropertyChanged;

        public Precipitacao() { }
        public Precipitacao(int anos, double precipitmaxima)
        {
            this.maximaAnual = precipitmaxima;
            this.ano = anos;
        }
        public double MaximaAnual
        {
            get { return maximaAnual; }
            set
            {
                maximaAnual = value;
                OnPropertyChanged("MaximaAnual");
            }
        }

        public int Ano
        {
            get { return ano; }
            set
            {
                ano = value;
                OnPropertyChanged("Ano");
            }
        }
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
