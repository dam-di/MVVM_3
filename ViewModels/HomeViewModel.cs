using MVVM_3.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_3.ViewModels
{
    class HomeViewModel:ViewModelBase
    {
        
        private string numeroA;
        public string NumeroA 
        { 
            get { return numeroA; } 
            set { numeroA = value; OnPropertyChanged(nameof(NumeroA)); } 
        }

        private string numeroB;
        public string NumeroB
        {
            get { return numeroB; }
            set { numeroB = value; OnPropertyChanged(nameof(NumeroB)); }
        }

        private string total;
        public string Total
        {
            get { return total; }
            set { total = value; OnPropertyChanged(nameof(Total)); }
        }

        private string pantalla;
        public string Pantalla
        {
            get { return pantalla; }
            set { pantalla = value; OnPropertyChanged(nameof(Pantalla)); }
        }

        private string funcionSeleccionada;
        public string FuncionSeleccionada 
        { 
            set { funcionSeleccionada = value;} 
            get { return funcionSeleccionada; OnPropertyChanged(nameof(FuncionSeleccionada)); } 
        }   


        public ICommand NumerosCommand { get; set; }
        public ICommand FuncionesCommand  { get; set; }

        public HomeViewModel()
        {
            NumeroA = "";
            NumeroB = "";
            Total = "";
            Pantalla = "0";
            FuncionSeleccionada = "";

            NumerosCommand = new NumerosCommand(this);
            FuncionesCommand = new FuncionesCommand(this);
        }

    }
}
