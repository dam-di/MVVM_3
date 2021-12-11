using MVVM_3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_3.Commands
{
    class NumerosCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is string)
            {

                string numero = parameter.ToString();

                if(homeViewModel.FuncionSeleccionada.Equals(""))
                {
                    homeViewModel.NumeroA = homeViewModel.NumeroA+numero;
                    
                    homeViewModel.Pantalla = homeViewModel.NumeroA;
                }
                else
                {
                    homeViewModel.NumeroB = homeViewModel.NumeroB + numero;
                    homeViewModel.Pantalla = homeViewModel.NumeroB;
                }
            }
  
        }

        public HomeViewModel homeViewModel { get; set; }
        public NumerosCommand(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
        }
    }
}
