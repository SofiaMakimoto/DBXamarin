using AppBD.Control;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBD
{
    public partial class App : Application
    {
        static DBAccess customerAccess;

        public static DBAccess CustomerAccess
        {
            get
            {
                if (customerAccess  == null)
                {
                    customerAccess = new DBAccess(Path.Combine(Environment.GetFolderPath
                        (Environment.SpecialFolder.LocalApplicationData), "customer.db3"));
                }
                return customerAccess;
            }

        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new MainPage());
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
