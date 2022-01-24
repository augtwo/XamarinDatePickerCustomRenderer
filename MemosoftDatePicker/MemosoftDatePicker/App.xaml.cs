using MemosoftDatePicker.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MemosoftDatePicker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DatePickerPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
