using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class goal_money : ContentPage
	{
		public goal_money ()
		{
			InitializeComponent ();
            touroku.Clicked += tourokuClicked;
		}

        private async void tourokuClicked(object sender, EventArgs e)
        {
            base.OnAppearing();
            var result = await App.Database1.GetItemsAsync();
            /*foreach (var loc in result)
            {
                await App.Database1.DeleteItemAsync(loc);
            }*/
            int num;
            num = int.Parse(kingaku.Text);
            var mokuhyou = new goalmoney1()
            {
                goalmoney = num
            };
            Save(mokuhyou);
            //await DisplayAlert("登録しました","OK","");
        }

        public async void Save(goalmoney1 item1)
        {
            await App.Database1.SaveItemAsync(item1);
            await DisplayAlert("DATA", "登録しました", "OK");
        }
    }
}