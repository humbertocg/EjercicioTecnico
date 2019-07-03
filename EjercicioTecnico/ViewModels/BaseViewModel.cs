using System;
using Xamarin.Forms;

namespace EjercicioTecnico.ViewModels
{
    public class BaseViewModel : MvvmHelpers.BaseViewModel
    {
        public INavigation Navigation { get; private set; }
        public BaseViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }

        public virtual void OnViewAppearing()
        {

        }

        public virtual void OnViewDisappearing()
        {

        }
    }
}
