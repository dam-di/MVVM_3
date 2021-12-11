﻿using MVVM_3.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_3.ViewModels
{
    class MainViewModel:ViewModelBase
    {
        private ViewModelBase selectedViewModel;
        public ViewModelBase SelectedViewModel
        {
            get { return selectedViewModel; }
            set { selectedViewModel = value; OnPropertyChanged(nameof(SelectedViewModel)); }
        }

        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
