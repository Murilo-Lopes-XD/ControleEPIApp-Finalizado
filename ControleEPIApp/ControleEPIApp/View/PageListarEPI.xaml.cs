using ControleEPIApp.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleEPIApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListarEPI : ContentPage
    {
        public PageListarEPI()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lsvEPI.ItemsSource = MySQLCon.ListarEPI();
            lsvEPIVencida.ItemsSource = MySQLCon.ListarEPIVencida();
        }
    }
}