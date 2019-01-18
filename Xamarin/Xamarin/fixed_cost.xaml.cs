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
	public partial class fixed_cost : ContentPage
	{
		public fixed_cost ()
		{
			InitializeComponent ();
            touroku.Clicked += tourokuClicked;

            var categoryList = new List<string>
        {
            "食費",
            "日用品",
            "交通費",
            "医療費",
            "光熱費",
            "美容衣服",
            "趣味",
            "酒たばこ",
            "その他",
        };

            //Pickerに項目を追加
            foreach (var item in categoryList)
            {
                this.koumoku.Items.Add(item);
            }
        }

        private async void tourokuClicked(object sender, EventArgs e)
        {
            base.OnAppearing();
            var result = await App.Database4.GetItemsAsync();
            /*foreach (var loc in result)
            {
                await App.Database1.DeleteItemAsync(loc);
            }*/
            int num;
            string str;
            num = int.Parse(kingaku.Text);
            str = (string)koumoku.SelectedItem;
            var fix = new fixed_costmoney()
            {
                Spay = num,
                cate = str
            };
            Save(fix);
            //await DisplayAlert("登録しました","OK","");
        }

        public async void Save(fixed_costmoney item1)
        {
            await App.Database4.SaveItemAsync(item1);
            await DisplayAlert("DATA", "登録しました", "OK");
        }
    }
}