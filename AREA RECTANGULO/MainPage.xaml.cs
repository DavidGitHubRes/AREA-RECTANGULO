using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AREA_RECTANGULO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Cal_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                double b = Convert.ToDouble(@base.Text);
                double h = Convert.ToDouble(altura.Text);

                sup.Text = "SUPERFICIE: " + (b * h);
                per.Text = "PERIMETRO: " + (b + b + h + h);
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", "OCURRIO UN ERROR: " + ex.Message, "ACEPTAR");
            }
        }
    }
}
