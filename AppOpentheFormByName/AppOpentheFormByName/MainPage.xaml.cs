using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppOpentheFormByName
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        async void OnButtonClicked(object sender, EventArgs e)
        {
            try
            {
            Button btn = (Button)sender;
            string id = btn.StyleId;
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            Type pageType = assembly.GetType("AppOpentheFormByName." + id);
            Page page = (Page)Activator.CreateInstance(pageType);
            await Navigation.PushAsync(page);
            }
            catch (Exception ex)
            {
                var s = ex.Message;
            }
        }





    }
}
