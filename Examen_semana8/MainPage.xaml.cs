using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen_semana8
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Stacklayout());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Grid());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new HierchicalNavigation());

            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Tabbed());

            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Formulario());

            };
            Item6.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Datapicker());

            };

        }
    }
}
