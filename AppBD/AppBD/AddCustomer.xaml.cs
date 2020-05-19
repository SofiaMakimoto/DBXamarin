using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCustomer : ContentPage
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        private async void SaveCustomer_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameBox.Text) && !string.IsNullOrWhiteSpace(AgeBox.Text))
            {
                await App.CustomerAccess.SaveCustomer(new Model.Customer
                {
                    Name = NameBox.Text,
                    Age = int.Parse(AgeBox.Text) //int.parse converte string em numero. Quando possível

                });

                NameBox.Text = AgeBox.Text = string.Empty;
                /* igual a 
                 * NameBox = string.Empty;
                 * AgeBox = string.Empty;
                 */
                
            }
        }
    }
}