using System;
using System.Collections.ObjectModel;
using System.Linq;
using Core.ServiceConsumer;
using Core.ServiceConsumer.Models;
using Xamarin.Forms;

namespace EjercicioTecnico.ViewModels
{
    public class CarListVM : BaseViewModel
    {
        public ObservableCollection<CarItem> ItemCars { get; set; }
        public Command AddCommand { get; set; }
        public string Brand { get; set; }
        public string Line { get; set; }
        public string Year { get; set; }

        public CarListVM(INavigation navigation) : base(navigation)
        {
            ItemCars = new ObservableCollection<CarItem>();
            AddCommand = new Command(AddAction);
        }

        private void AddAction()
        {
            if (!IsBusy)
            {
                IsBusy = true;
                var item = new CarItem
                {
                    Brand = Brand,
                    Line = Line,
                    Year = Year
                };
                //var checkItem = ItemCars.FirstOrDefault(x => x == item);
                //if
                ItemCars.Add(item);
                IsBusy = false;
            }
        }

        public override void OnViewAppearing()
        {
            base.OnViewAppearing();
            var dataConsumer = new DataConsumer();
            var carList = dataConsumer.GetCarList();
            foreach(var item  in carList)
            {
                ItemCars.Add(item);
            }
        }
    }
}
