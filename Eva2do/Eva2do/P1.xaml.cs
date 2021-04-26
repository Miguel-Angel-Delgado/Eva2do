using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eva2do
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class P1 : ContentPage
    {
        public P1()
        {
            InitializeComponent();
            pickOper.Items.Add("Envío Gratis");
            pickOper.Items.Add("Envío Express");
            pickAud.Items.Add("Bose Quite Comfort II");
            pickAud.Items.Add("PowerBeats 2 Pro by Dr.Dre");
            pickAud.Items.Add("Beyerdinamic 770 Pro");
            pickAud.Items.Add("Skullcandy Crusher");
            pickAud.Items.Add("Shure 440 HF");

        }

        public void pickOper_SelectedIndexChanged(object sender, EventArgs e)
        {

            double preEnv = 0;
            String env = pickOper.SelectedItem.ToString();
            if (env == "Envío Gratis")
            {
                preEnv = 0;
            }
            else
            {
                preEnv = 200;
            }
            envi.Text = preEnv + "";
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            check.IsEnabled = true;
            check1.IsEnabled = true;
            check2.IsEnabled = true;
            check3.IsEnabled = true;
            string desc = Convert.ToString(code.Text);
            var subt = double.Parse(sub.Text);
            var envt = double.Parse(envi.Text);
            double prf = subt + envt;
            double desccc = 0.90;
            double prfsi = prf * desccc;
            double calciva = prf * 0.16;
            double calcivadesc = prfsi * 0.16;
            double totalsin = calciva + prf;
            double totalsi = calcivadesc + prfsi;
            if (desc == "DESC10")
            {
                final.Text = prfsi + "";
                ivaf.Text = calcivadesc + "";
                finalahorasi.Text = totalsi + "";
            }
            else
            {
                final.Text = prf + "";
                ivaf.Text = calciva + "";
                finalahorasi.Text = totalsin + "";
            }

        }

        public void pickAud_SelectedIndexChanged(object sender, EventArgs e)
        {

            calcu.IsEnabled = true;
            String au = pickAud.SelectedItem.ToString();
            double pr1 = 0;
            if (au == "Bose Quite Comfort II")
            {
                pr1 = 6000;
                bose.Source = ImageSource.FromFile("audiff.jpg");
                beats.Source = null;
                skull.Source = null;
                beyerdinamic.Source = null;
                shure.Source = null;
            }
            else if (au == "PowerBeats 2 Pro by Dr.Dre")
            {
                pr1 = 4200;
                beats.Source = ImageSource.FromFile("audiff2.jpg");
                bose.Source = null;
                skull.Source = null;
                beyerdinamic.Source = null;
                shure.Source = null;
            }
            else if (au == "Beyerdinamic 770 Pro")
            {
                pr1 = 8000;
                beyerdinamic.Source = ImageSource.FromFile("beyerdinamic.jpg");
                bose.Source = null;
                skull.Source = null;
                beats.Source = null;
                shure.Source = null;
            }
            else if (au == "Skullcandy Crusher")
            {
                pr1 = 4550;
                skull.Source = ImageSource.FromFile("skullcandy.jpg");
                bose.Source = null;
                beats.Source = null;
                beyerdinamic.Source = null;
                shure.Source = null;
            }
            else if (au == "Shure 440 HF")
            {
                pr1 = 3899;
                shure.Source = ImageSource.FromFile("shure.jpg");
                bose.Source = null;
                skull.Source = null;
                beyerdinamic.Source = null;
                beats.Source = null;
            }

            sub.Text = pr1 + "";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new P1());

        }

        private void check_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

            acp.IsEnabled = true;

        }

        private async void acp_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("informacion", "se realizo su compra", "ok");
            Navigation.PopAsync();
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new P1());
        }
    }
}