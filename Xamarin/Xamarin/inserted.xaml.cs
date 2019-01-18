using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class inserted : ContentPage
	{
        List<DateTime> dd;
        int c1;
        int c2;
        int c3;
        int c4;
        int c5;
        int c6;
        int c7;
        int c8;
        int c9;
        

        public inserted (List<DateTime> dt)
		{
			InitializeComponent ();
            this.dd = dt;
            day_select.Clicked += day_selectClicked;
            month_select.Clicked += month_selectClicked;
            week_select.Clicked += week_selectClicked;
        }

        private async void week_selectClicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            aa.Text = dd[0].ToString("7日前までの支出");
            int a = dd[0].Day;
            int b = dd[0].Year;
            int c = dd[0].Month;
            base.OnAppearing();
            var result1 = await App.Database.GetItemsAsync();
            this.c1 = 0;
            this.c2 = 0;
            this.c3 = 0;
            this.c4 = 0;
            this.c5 = 0;
            this.c6 = 0;
            this.c7 = 0;
            this.c8 = 0;
            this.c9 = 0;
            DateTime dd2;
            int dd3;
            int dd4;
            int dd5;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Day;
                dd4 = dd2.Month;
                dd5 = dd2.Year;
                if (loc1.Name == "食料品" && (dd3 <= a && dd3 > a - 8) && dd4 == c && dd5 == b)
                    this.c1 = loc1.Spay + this.c1;
            }
            a1.Text = ("食料品:    \\" + this.c1);

            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Day;
                dd4 = dd2.Month;
                dd5 = dd2.Year;
                if (loc1.Name == "日用品" && (dd3 <= a && dd3 > a - 8) && dd4 == c && dd5 == b)
                    this.c2 = loc1.Spay + this.c2;
            }
            a2.Text = ("日用品:    \\" + this.c2);
            //var result3 = await App.Database.GetItemsAsync();

            //int c3 = 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Day;
                dd4 = dd2.Month;
                dd5 = dd2.Year;
                if (loc1.Name == "交通費" && (dd3 <= a && dd3 > a - 8) && dd4 == c && dd5 == b)
                    this.c3 = loc1.Spay + this.c3;
            }
            a3.Text = ("交通費:    \\" + this.c3);

            //var result4 = await App.Database.GetItemsAsync();

            //int c4= 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Day;
                dd4 = dd2.Month;
                dd5 = dd2.Year;
                if (loc1.Name == "医療費" && (dd3 <= a && dd3 > a - 8) && dd4 == c && dd5 == b)
                    this.c4 = loc1.Spay + this.c4;
            }
            a4.Text = ("医療費:    \\" + this.c4);

            //var result5 = await App.Database.GetItemsAsync();

            //int c5 = 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Day;
                dd4 = dd2.Month;
                dd5 = dd2.Year;
                if (loc1.Name == "光熱費" && (dd3 <= a && dd3 > a - 8) && dd4 == c && dd5 == b)
                    this.c5 = loc1.Spay + this.c5;
            }
            a5.Text = ("光熱費:    \\" + this.c5);

            //var result6 = await App.Database.GetItemsAsync();

            //int c6 = 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Day;
                dd4 = dd2.Month;
                dd5 = dd2.Year;
                if (loc1.Name == "美容衣服" && (dd3 <= a && dd3 > a - 8) && dd4 == c && dd5 == b)
                    this.c6 = loc1.Spay + this.c6;
            }
            a6.Text = ("美容衣服:    \\" + this.c6);

            //var result7 = await App.Database.GetItemsAsync();

            //int c7 = 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Day;
                dd4 = dd2.Month;
                dd5 = dd2.Year;
                if (loc1.Name == "趣味" && (dd3 <= a && dd3 > a - 8) && dd4 == c && dd5 == b)
                    this.c7 = loc1.Spay + this.c7;
            }
            a7.Text = ("趣味:    \\" + this.c7);

            //var result8 = await App.Database.GetItemsAsync();

            //int c8 = 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Day;
                dd4 = dd2.Month;
                dd5 = dd2.Year;
                if (loc1.Name == "酒たばこ" && (dd3 <= a && dd3 > a - 8) && dd4 == c && dd5 == b)
                    this.c8 = loc1.Spay + this.c8;
            }
            a8.Text = ("酒たばこ:    \\" + this.c8);

            //var result9 = await App.Database.GetItemsAsync();

            //int c9 = 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Day;
                dd4 = dd2.Month;
                dd5 = dd2.Year;
                if (loc1.Name == "その他" && (dd3 <= a && dd3 > a - 8) && dd4 == c && dd5 == b)
                    this.c9 = loc1.Spay + this.c9;
            }
            a9.Text = ("その他:    \\" + this.c9);
        }

        private async void month_selectClicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            aa.Text = dd[0].ToString("日付：yyyy年MM月の支出");
            int a = dd[0].Month;
            int b = dd[0].Year;
            base.OnAppearing();
            var result1 = await App.Database.GetItemsAsync();
            DateTime dd2;
            int dd3;
            int dd4;
            this.c1 = 0;
            this.c2 = 0;
            this.c3 = 0;
            this.c4 = 0;
            this.c5 = 0;
            this.c6 = 0;
            this.c7 = 0;
            this.c8 = 0;
            this.c9 = 0;

            foreach (var loc1 in result1){
                dd2 = loc1.Day;
                dd3 = dd2.Month;
                dd4 = dd2.Year;
                if (loc1.Name == "食料品" && a == dd3 && dd4 == b)
                    this.c1 = loc1.Spay + this.c1;
            }
            a1.Text = ("食料品:    \\" + this.c1);

            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Month;
                dd4 = dd2.Year;
                if (loc1.Name == "日用品" && a == dd3 && dd4 == b)
                    this.c2 = loc1.Spay + this.c2;
            }
            a2.Text = ("日用品:    \\" + this.c2);
            //var result3 = await App.Database.GetItemsAsync();

            //int c3 = 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Month;
                dd4 = dd2.Year;
                if (loc1.Name == "交通費" && a == dd3 && dd4 == b)
                    this.c3 = loc1.Spay + this.c3;
            }
            a3.Text = ("交通費:    \\" + this.c3);

            //var result4 = await App.Database.GetItemsAsync();

            //int c4= 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Month;
                dd4 = dd2.Year;
                if (loc1.Name == "医療費" && a == dd3 && dd4 == b)
                    this.c4 = loc1.Spay + this.c4;
            }
            a4.Text = ("医療費:    \\" + this.c4);

            //var result5 = await App.Database.GetItemsAsync();

            //int c5 = 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Month;
                dd4 = dd2.Year;
                if (loc1.Name == "光熱費" && a == dd3 && dd4 == b)
                    this.c5 = loc1.Spay + this.c5;
            }
            a5.Text = ("光熱費:    \\" + this.c5);

            //var result6 = await App.Database.GetItemsAsync();

            //int c6 = 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Month;
                dd4 = dd2.Year;
                if (loc1.Name == "美容衣服" && a == dd3 && dd4 == b)
                    this.c6 = loc1.Spay + this.c6;
            }
            a6.Text = ("美容衣服:    \\" + this.c6);

            //var result7 = await App.Database.GetItemsAsync();

            //int c7 = 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Month;
                dd4 = dd2.Year;
                if (loc1.Name == "趣味" && a == dd3 && dd4 == b)
                    this.c7 = loc1.Spay + this.c7;
            }
            a7.Text = ("趣味:    \\" + this.c7);

            //var result8 = await App.Database.GetItemsAsync();

            //int c8 = 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Month;
                dd4 = dd2.Year;
                if (loc1.Name == "酒たばこ" && a == dd3 && dd4 == b)
                    this.c8 = loc1.Spay + this.c8;
            }
            a8.Text = ("酒たばこ:    \\" + this.c8);

            //var result9 = await App.Database.GetItemsAsync();

            //int c9 = 0;
            foreach (var loc1 in result1)
            {
                dd2 = loc1.Day;
                dd3 = dd2.Month;
                dd4 = dd2.Year;
                if (loc1.Name == "その他" && a == dd3 && dd4 == b)
                    this.c9 = loc1.Spay + this.c9;
            }
            a9.Text = ("その他:    \\" + this.c9);
        }

        private void day_selectClicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.c1 = 0;
            this.c2 = 0;
            this.c3 = 0;
            this.c4 = 0;
            this.c5 = 0;
            this.c6 = 0;
            this.c7 = 0;
            this.c8 = 0;
            this.c9 = 0;
            OnAppearing();
        }

        protected override async void OnAppearing()
        {
            aa.Text = dd[0].ToString("日付：yyyy年MM月dd日の支出");

            base.OnAppearing();
            var result1 = await App.Database.GetItemsAsync();
                //int c1;
                foreach (var loc1 in result1)
                {
                    if(loc1.Name == "食料品" && loc1.Day == dd[0])
                    this.c1 = loc1.Spay + this.c1;
                }
                a1.Text = ("食料品:    \\" + this.c1);
            //var result2 = await App.Database.GetItemsAsync();
            
                //int c2;
                foreach (var loc1 in result1)
                {
                if (loc1.Name == "日用品" && loc1.Day == dd[0])
                    this.c2 = loc1.Spay + this.c2;
                }
                a2.Text = ("日用品:    \\" + this.c2);
            //var result3 = await App.Database.GetItemsAsync();
            
                //int c3 = 0;
                foreach (var loc1 in result1)
                {
                if (loc1.Name == "交通費" && loc1.Day == dd[0])
                    this.c3 = loc1.Spay + this.c3;
                }
                a3.Text = ("交通費:    \\" + this.c3);
            
            //var result4 = await App.Database.GetItemsAsync();
            
                //int c4= 0;
                foreach (var loc1 in result1)
                {
                if (loc1.Name == "医療費" && loc1.Day == dd[0])
                    this.c4 = loc1.Spay + this.c4;
                }
                a4.Text = ("医療費:    \\" + this.c4);
            
            //var result5 = await App.Database.GetItemsAsync();
            
                //int c5 = 0;
                foreach (var loc1 in result1)
                {
                if (loc1.Name == "光熱費" && loc1.Day == dd[0])
                    this.c5 = loc1.Spay + this.c5;
                }
                a5.Text = ("光熱費:    \\" + this.c5);
            
            //var result6 = await App.Database.GetItemsAsync();
            
                //int c6 = 0;
                foreach (var loc1 in result1)
                {
                if (loc1.Name == "美容衣服" && loc1.Day == dd[0])
                    this.c6 = loc1.Spay + this.c6;
                }
                a6.Text = ("美容衣服:    \\" + this.c6);
            
            //var result7 = await App.Database.GetItemsAsync();
            
                //int c7 = 0;
                foreach (var loc1 in result1)
                {
                if (loc1.Name == "趣味" && loc1.Day == dd[0])
                    this.c7 = loc1.Spay + this.c7;
                }
                a7.Text = ("趣味:    \\" + this.c7);
            
            //var result8 = await App.Database.GetItemsAsync();
            
                //int c8 = 0;
                foreach (var loc1 in result1)
                {
                if (loc1.Name == "酒たばこ" && loc1.Day == dd[0])
                    this.c8 = loc1.Spay + this.c8;
                }
                a8.Text = ("酒たばこ:    \\" + this.c8);
            
            //var result9 = await App.Database.GetItemsAsync();
            
                //int c9 = 0;
                foreach (var loc1 in result1)
                {
                if (loc1.Name == "その他" && loc1.Day == dd[0])
                    this.c9 = loc1.Spay + this.c9;
                }
                a9.Text = ("その他:    \\" + this.c9);
            

        }
    }
}