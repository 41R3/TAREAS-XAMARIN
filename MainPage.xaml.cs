using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FORMCV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void ButtonSubmitClicked(System.Object sender, System.EventArgs e)
        {
            var input_name = name.Text;
            var input_age = age.Text;
            var input_adress = adress.Text;
            

            Application.Current.MainPage.Navigation.PushModalAsync(new dinamicpage(input_name,input_age,input_adress), true);

            
        }
       void ButtonPlusOcupationClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your Occupation" };
            ocupation.Children.Add(entry);
            
        }
    }
}
