using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EjercicioTecnico.Controls
{
    public partial class EntryControl : ContentView
    {

        public static BindableProperty TitleEntryProperty = BindableProperty.Create(
                                                            propertyName: nameof(TitleEntry),
                                                            returnType: typeof(string),
                                                            declaringType: typeof(EntryControl),
                                                            defaultValue: string.Empty,
                                                            defaultBindingMode: BindingMode.TwoWay);

        public string TitleEntry
        {
            get { return (string)base.GetValue(TitleEntryProperty); }
            set { base.SetValue(TitleEntryProperty, value); }
        }

        public static BindableProperty DataProperty = BindableProperty.Create(
                                                            propertyName: nameof(Data),
                                                            returnType: typeof(string),
                                                            declaringType: typeof(EntryControl),
                                                            defaultValue: string.Empty,
                                                            defaultBindingMode: BindingMode.TwoWay);

        public string Data
        {
            get { return (string)base.GetValue(DataProperty); }
            set { base.SetValue(DataProperty, value); }
        }


        public EntryControl()
        {
            InitializeComponent();
        }
    }
}
