﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppBD
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing(); 
            CustomerList.ItemsSource = await App.CustomerAccess.ListCustomers();
        }

        private async void AddCustomerBt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddCustomer());
        }
    }
}
