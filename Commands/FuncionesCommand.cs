using MVVM_3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_3.Commands
{
    class FuncionesCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is string)
            {
                string funcion = (string)parameter;

                if (funcion.Equals("=") && !homeViewModel.NumeroA.Equals("") && !homeViewModel.NumeroB.Equals(""))
                {
                    double total = Calcular(homeViewModel.FuncionSeleccionada);
                    homeViewModel.Total = total.ToString();
                    homeViewModel.Pantalla = total.ToString();
                    homeViewModel.NumeroA = "";
                    homeViewModel.NumeroB = "";
                    homeViewModel.FuncionSeleccionada = "";


                }
                if (!funcion.Equals("="))
                {
                    homeViewModel.FuncionSeleccionada = funcion;
                    homeViewModel.Pantalla = funcion;
                    if (!homeViewModel.FuncionSeleccionada.Equals("") && !homeViewModel.Total.Equals(""))
                    {
                        homeViewModel.NumeroA = homeViewModel.Total;
                    }

                }

            }
        }

        public double Calcular(string funcion)
        {
            double total = 0;

            if (funcion.Equals("+"))
            {
                total = double.Parse(homeViewModel.NumeroA) + double.Parse(homeViewModel.NumeroB);
            }
            else if (funcion.Equals("-"))
            {
                total = double.Parse(homeViewModel.NumeroA) - double.Parse(homeViewModel.NumeroB);
            }
            else if (funcion.Equals("*"))
            {
                total = double.Parse(homeViewModel.NumeroA) * double.Parse(homeViewModel.NumeroB);
            }
            else if (funcion.Equals("/"))
            {
                try
                {
                    total = total = double.Parse(homeViewModel.NumeroA) / double.Parse(homeViewModel.NumeroB);
                }
                catch (Exception) { }

            }
            return total;

        }


        


        public HomeViewModel homeViewModel { get; set; }
        public FuncionesCommand(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
        }
    }
}
