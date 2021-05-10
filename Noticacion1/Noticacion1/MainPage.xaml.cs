using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Noticacion1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(EntryTitleMessage.Text) && !string.IsNullOrEmpty(EntryMessage.Text)){
                CrossLocalNotifications.Current.Show(EntryTitleMessage.Text, EntryMessage.Text,0,DateTime.Now.AddSeconds(double.Parse(EntryDateMessage.Text)));
            }
            else
            {
                await DisplayAlert("Atención", "Son necesarios todos los campos", "Aceptar");
            }

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            CreateWorker();
        }

        private void CreateWorker()
        {
           
        }
    }
}
