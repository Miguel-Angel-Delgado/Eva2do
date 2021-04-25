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

        }

        public void pickOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            double preEnv = 0;
            String env = pickOper.SelectedItem.ToString();
            if (env == "Envío Gratis")
            {
                preEnv = 0;
            } else
            {
                preEnv = 200;
            }
            envi.Text = preEnv + "";
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            string desc = Convert.ToString(code.Text);
            var subt = double.Parse(sub.Text);
            var envt = double.Parse(envi.Text);
            double prf = subt + envt;
            double desccc = 0.90;
            double prfsi = prf * desccc;
            if (desc == "DESC10")
            {
                final.Text = prfsi + "";
            }
            else { final.Text = prf + ""; }
            
        }

        public void pickAud_SelectedIndexChanged(object sender, EventArgs e)
        {
            String au = pickAud.SelectedItem.ToString();
            double pr1 = 0;
            if (au == "Bose Quite Comfort II")
            {
                pr1 = 6000;

            }
            else if (au == "PowerBeats 2 Pro by Dr.Dre")
            {
                pr1 = 4200;
            }

            sub.Text = pr1 + "";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new P1());

        }
    }
}