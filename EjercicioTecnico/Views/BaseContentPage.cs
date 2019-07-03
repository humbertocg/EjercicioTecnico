using System;
using EjercicioTecnico.ViewModels;
using Xamarin.Forms;

namespace EjercicioTecnico
{
    public class BaseContentPage : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var vm = BindingContext as BaseViewModel;
            vm?.OnViewAppearing();
        }

        protected override void OnDisappearing()
        {
            var vm = BindingContext as BaseViewModel;
            vm?.OnViewDisappearing();
            base.OnDisappearing();
        }
    }
}
