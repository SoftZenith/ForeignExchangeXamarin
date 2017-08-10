using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForeignExchangeXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnConvert.Clicked += BtnConvert_Clicked;
        }

        private void BtnConvert_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PesosEntry.Text)) {
                DisplayAlert("Error","You must enter a value in pesos...","Accept");
                return;
            }

            decimal pesos = 0;
            if (!decimal.TryParse(PesosEntry.Text, out pesos)) {
                DisplayAlert("Error","You must enter a value numeric in pesos","Accept");
                return;
            }

            var dollars = pesos / 18.0M;
            var euros = pesos / 21.0M;
            var pounds = pesos / 23.24M;

            DollarsEntry.Text = string.Format("{0:C2}", dollars);
            EurosEntry.Text = string.Format("{0:C2}", euros);
            PoundsEntry.Text = string.Format("{0:C2}",pounds);

        }
    }
}
