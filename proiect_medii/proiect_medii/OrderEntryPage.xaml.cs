using proiect_medii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace proiect_medii
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderEntryPage : ContentPage
    {
        public OrderEntryPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetPizzaOrderAsync();
        }
        async void OnPizzaOrderAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderPage
            {
                BindingContext = new PizzaOrder()
            });
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new OrderPage
                {
                    BindingContext = e.SelectedItem as PizzaOrder
                });
            }
        }
    }
}