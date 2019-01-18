using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class salary : ContentPage
    {
        public salary()
        {
            InitializeComponent();

            touroku.Clicked += tourokuClicked;
        }
        private async void tourokuClicked(object sender, EventArgs e)
        {
            base.OnAppearing();
            var result = await App.Database3.GetItemsAsync();
            var result2 = await App.Database4.GetItemsAsync();
            int goukei = 0;
            foreach (var loc in result)
            {
                await App.Database3.DeleteItemAsync(loc);
            }
            int kin = int.Parse(money.Text);

            foreach(var loc1 in result2)
            {
                goukei = loc1.Spay + goukei;
            }

            goukei = kin - goukei;
            //DateTime dt1 = DateTime.Parse(dd);
            //DateTime dt1 = DateTime.Parse(dd);
            salarymoney item = new salarymoney()
            {
                Spay = goukei,
            };
            Save(item);
        }
        public async void Save(salarymoney item)
        {
            //await App.Database.SaveItemAsync(item);
            await DisplayAlert("DATA", "登録しました", "OK");
            await App.Database3.SaveItemAsync(item);
        }
    }
}