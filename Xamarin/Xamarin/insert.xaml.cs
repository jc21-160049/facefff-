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
	public partial class insert : TabbedPage
	{
        public DateTime dd;

        public insert (List<DateTime> dt)
		{
			InitializeComponent ();

            aaa.Text = dt[0].ToString("日付：yyyy年MM月dd日");
            //dd = dt[0].ToString("yyyy/MM/dd");
            this.dd = dt[0];

            //string1.Text = "金額：";
            b1.Clicked += b1Clicked;
            b2.Clicked += b2Clicked;
            b3.Clicked += b3Clicked;
            b4.Clicked += b4Clicked;
            b5.Clicked += b5Clicked;
            b6.Clicked += b6Clicked;
            b7.Clicked += b7Clicked;
            b8.Clicked += b8Clicked;
            b9.Clicked += b9Clicked;
            touroku.Clicked += tourokuClicked;
        }

        private void tourokuClicked(object sender, EventArgs e)
        {
            int kin = int.Parse(money.Text);
            //DateTime dt1 = DateTime.Parse(dd);
            //DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = koumoku.Text,
                Spay = kin,
                Day = this.dd
            };
            Save(item);
        }
        public async void Save(LocationItem item1)
        {
            await App.Database.SaveItemAsync(item1);
            await DisplayAlert("DATA", "登録しました","OK");
        }

        private void b1Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b1.Text;
        }
        private void b2Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b2.Text;
        }
        private void b3Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b3.Text;
        }
        private void b4Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b4.Text;
        }
        private void b5Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b5.Text;
        }
        private void b6Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b6.Text;
        }
        private void b7Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b7.Text;
        }
        private void b8Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b8.Text;
        }
        private void b9Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b9.Text;
        }



    }

}