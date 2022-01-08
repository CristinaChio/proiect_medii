using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using proiect_medii.Data;
using System.IO;

namespace proiect_medii
{
    public partial class App : Application
    {
        static PizzaOrderDatabase database;
        public static PizzaOrderDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   PizzaOrderDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "PizzaOrder.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new OrderEntryPage());
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
