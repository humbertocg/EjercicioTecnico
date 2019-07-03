using System;
using System.Collections.Generic;
using EjercicioTecnico.ViewModels;
using Xamarin.Forms;

namespace EjercicioTecnico.Views
{
    public partial class CarListView : BaseContentPage
    {
        private CarListVM _vm;
        public CarListView()
        {
            InitializeComponent();
            _vm = new CarListVM(Navigation);
            BindingContext = _vm;
        }
    }
}
