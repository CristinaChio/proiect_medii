using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using proiect_medii.Models;

namespace proiect_medii
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        public OrderPage()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var plist = (PizzaOrder)BindingContext;
            plist.Date = DateTime.UtcNow;
            await App.Database.SavePizzaOrderAsync(plist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var plist = (PizzaOrder)BindingContext;
            await App.Database.DeletePizzaOrderAsync(plist);
            await Navigation.PopAsync();
        }
        async void OnChooseButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductPage((PizzaOrder)
           this.BindingContext)
            {
                BindingContext = new Product()
            });

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var shopl = (PizzaOrder)BindingContext;

            listView.ItemsSource = await App.Database.GetListProductsAsync(shopl.ID);
        }
    }
}