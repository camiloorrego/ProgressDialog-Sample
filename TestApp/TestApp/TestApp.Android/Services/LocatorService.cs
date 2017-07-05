using TestApp.Interfaces;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Ioc;
using TestApp.ViewModels;

namespace TestApp.Droid.Services
{
    public class LocatorService : ILocatorService
    {
        static LocatorService()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            //Cross Services
            SimpleIoc.Default.Register<IProgressDialog, ProgressDialogService>();
        }
        public T Get<T>() where T : class
        {
            return SimpleIoc.Default.GetInstance<T>();
        }
    }
}