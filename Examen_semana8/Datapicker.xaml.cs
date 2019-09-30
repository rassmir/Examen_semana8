using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen_semana8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Datapicker : ContentPage
    {
        public Datapicker()
        {
            InitializeComponent();
            dtp.Date = DateTime.Now;
            dtp.MinimumDate = new DateTime(1999, 01, 01);
            dtp.MaximumDate = new DateTime(2019, 12, 01);
            dtp.DateSelected += DtpOnDateSelected;
        }
        private void DtpOnDateSelected(object sender, DateChangedEventArgs e)
        {
            DisplayAlert("Fecha", e.NewDate.ToString(("dd/MM/yyyy")), "OK");
        }
    }
}