using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamForms.Controls;
using PublicHoliday;
using Xamarin;

namespace Xamarin
{
    public partial class Home : TabbedPage
    {
        public static List<DateTime> ddt;
        public Home()
        {
            try
            {
                InitializeComponent();
                goal1();

                //カレンダー祝日の設定
                calendarrr.SpecialDates = new List<SpecialDate>{
            new SpecialDate(DateTime.Now)
            {
                   TextColor = Color.Green, BorderColor=Color.Green,
                   BorderWidth =8, Selectable = true }
            };

                //SetHoliday(DateTime.Now.Year);
            }
            catch (Exception)
            {
                DisplayAlert("Alert", "正しく選んでください。。", "OK");
            }
        }

        public async void goal1()
        {
            double num1 = 0;
            int num2 = 0;
            int num5 = 0;
            /*var mokuhyou = new goalmoney1()
            {
                goalmoney = 1000000
            };*/

            /*var income1 = new income()
            {
                incomemoney = 200000
            };*/

            //int spend = 0;
            base.OnAppearing();
            var result1 = await App.Database.GetItemsAsync();
            var result2 = await App.Database2.GetItemsAsync();
            var result3 = await App.Database1.GetItemsAsync();
            var result4 = await App.Database3.GetItemsAsync();
            foreach (var loc1 in result1)
            {
                if(DateTime.Now.Year == loc1.Day.Year && DateTime.Now.Month == loc1.Day.Month)
                num1 = loc1.Spay + num1;
            }
            /*foreach(var loc2 in result1)
            {
                if(DateTime.Now.Year == loc2.Day.Year && DateTime.Now.Month == loc2.Day.Month)
                {
                    spend = loc2.Spay + spend;
                }
            }*/
            foreach(var loc2 in result3)
            {
                num5 = loc2.goalmoney;
            }
            foreach(var loc3 in result4){
                num2 = loc3.Spay;
            }
            //num5 = result3[0].goalmoney;
            //num2 = income1.incomemoney;
            double num3 = num2 - num1 - num5;
            string s3;
            string s1 = ("今月使った金額は" + num1 + "円です");
            if (num3 < 0)
            {
                s3 = ("このままだと目標金額を\n" + -num3 + "円オーバーしてしまいます。");
            }
            else
            {
                s3 = ("今月使える金額は" + num3 + "円です");
            }
            //double num4 = ((double)num5 / num3)*100;
            //num4 = Math.Round(num4, 2);
            int iDaysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            int Daya = DateTime.Now.Day;
            double num4 = num1 / Daya;
            num4 = num4 * iDaysInMonth;
            num4 = num2 - num4;
            num4 = num4 / num5;
            
            num4 = num4 * 100;
            num4 = Math.Round(num4, 2);
            string s2;
            if(num4 > 100)
            {
                s2 = ("目標金額との割合100%");
                goaltext.Text = "このペースでいくと今月末には\n目標金額を達成します。";
            }
            else if (num4 < 0) {
                s2 = ("目標金額との割合0%");
                goaltext.Text = "節約しないと、\nこのままだと貯金できませんよ。";
            }
            else
            {
                s2 = ("目標金額の割合" + num4 + "%");
                goaltext.Text = "もう少し節約して、\n目標金額の達成を目指しましょう。";
            }
            
           /* if (num1 != 0)
            {
                double num4 = (num2 - num1) / (iDaysInMonth - Daya);
                num4 = num4 / num2;
                num4 = Math.Round(num4, 2);
                num4 = num4 * 100;
                s2 = ("目標金額の割合" + num4 + "%");
            }
            else
            {
                s2 = ("目標金額の割合0%");
            }*/
            usedmoney.Text = s1;
            ableuse.Text = s3;
            goal.Text = s2;
        }
        //カレンダー土日の設定
        private void SetWeekend(int year)
        {
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            for (var day = startDate.Date; day.Date <= endDate.Date; day = day.AddDays(1))
            {
                if (DayOfWeek.Saturday == day.DayOfWeek)
                {
                    calendarrr.SpecialDates.Add(new SpecialDate(day)
                    {
                        TextColor = Color.Blue
                    });
                }
                else if (DayOfWeek.Sunday == day.DayOfWeek)
                {
                    calendarrr.SpecialDates.Add(new SpecialDate(day)
                    {
                        TextColor = Color.Red
                    });
                }
            }
        }


        //カレンダー祝日の表示

        /*private void SetHoliday(int year)
        {
            IList<DateTime> result = new JapanPublicHoliday().PublicHolidays(year);

            foreach (var holiday in result)
            {
                calendarrr.SpecialDates.Add(new SpecialDate(holiday)
                {
                    TextColor = Color.Red
                });
            }
        }*/


        //カレンダー日付クリック
        private async void OnDateClick(object sender, EventArgs e)
        {
            try
            {
                /*base.OnAppearing();
                List<LocationItem> result = await App.Database.GetItemDay(calendarrr.SelectedDates);
                int x = result.Count;
                if (x == 0)
                {
                    await this.Navigation.PushModalAsync(new insert2(calendarrr.SelectedDates));
                }
                else
                {*/
                //await this.Navigation.PushModalAsync(new inserted(calendarrr.SelectedDates));
                 var t = calendarrr.SelectedDates;
                if (t.Count != 0) {
                    Home.ddt = t;
                    await this.Navigation.PushModalAsync(new insert(Home.ddt));
                }
                /*}*/
            }
            catch (Exception)
            {
               await DisplayAlert("Alert", "同じ日を連続で選ばないでください。", "OK");
            }
        }

        //設定画面ボタンの画面遷移
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new notification());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new often_use());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new fixed_cost());
        }
        private async void Button_Clicked_3(object seder, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new goal_money());
        }
        private async void Button_Clicked_4(object seder, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new salary());
        }
        private async void Button_Clicked_5(object seder, EventArgs e)
        {
            var result1 = await App.Database.GetItemsAsync();
            var result2 = await App.Database1.GetItemsAsync();
            var result3 = await App.Database2.GetItemsAsync();
            var result4 = await App.Database3.GetItemsAsync();
            var result5 = await App.Database4.GetItemsAsync();
            var result6 = await App.Database5.GetItemsAsync();

            foreach(var loc in result1)
            {
                await App.Database.DeleteItemAsync(loc);
            }

            foreach (var loc in result2)
            {
                await App.Database1.DeleteItemAsync(loc);
            }

            foreach (var loc in result3)
            {
                await App.Database2.DeleteItemAsync(loc);
            }

            foreach (var loc in result4)
            {
                await App.Database3.DeleteItemAsync(loc);
            }

            foreach (var loc in result5)
            {
                await App.Database4.DeleteItemAsync(loc);
            }

            foreach (var loc in result6)
            {
                await App.Database5.DeleteItemAsync(loc);
            }
            //alert1();
        }

        public async void alert1()
        {
            await DisplayAlert("初期化しました。","","");
        }
        private async void OnDateClick_detail(object sender, EventArgs e)
        {
            try
            {
                var t = calendar_detail.SelectedDates;
                if (t.Count != 0)
                {
                    Home.ddt = t;
                    await this.Navigation.PushModalAsync(new inserted(calendar_detail.SelectedDates));
                }
                //await this.Navigation.PushModalAsync(new inserted(calendar_detail.SelectedDates));
            }
            catch (Exception)
            {
                await DisplayAlert("Alert", "同じ日を連続で選ばないでください。", "OK");
            }
        }
    }

}