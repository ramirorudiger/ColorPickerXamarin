using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColorPicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            sldBlue.Value = 128;
            sldGreen.Value = 128;
            sldRed.Value = 128;
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            int red = (int)sldRed.Value;
            int green = (int)sldGreen.Value;
            int blue = (int)sldBlue.Value;
            Color c = Color.FromRgb(red, green, blue);
            boxColor.BackgroundColor = c;
            txtHtmlColor.Text = string.Format("#{0:X2}{1:X2}{2:X2}", red, green, blue);
            lblBlue.Text = $"Blue {blue}";
            lblGreen.Text = $"Green {green}";
            lblRed.Text = $"Red {red}";

        }
    }
}
