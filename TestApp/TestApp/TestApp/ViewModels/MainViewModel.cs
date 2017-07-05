using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestApp.Interfaces;

namespace TestApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        IProgressDialog Progress;
        public MainViewModel(IProgressDialog progress)
        {
            Progress = progress;


        }

        public ICommand ShowDialogCommand { get { return new RelayCommand(ShowDialog); } }

        async private void ShowDialog()
        {
            Progress.ShowProgress();

            await Task.Delay(3000);
            Progress.HideProgress();
        }
    }
}
