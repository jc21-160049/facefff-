using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin;

namespace Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ResultPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var result = await App.Database4.GetItemsAsync();


            int size = result.Count;
            await DisplayAlert("ResultPage", "record=" + size, "OK");

            var layout2 = new StackLayout() { Spacing = 10 };

            foreach (var loc in result)
            {
                //loc.Num = loc.Spay + loc.Longitude;
            }
            //await App.Database1.DeleteItemAsync(result[1]);
            /*foreach(var locat in result){
                await App.Database1.DeleteItemAsync(locat);
            }*/
            
            foreach (var location in result)
            {
                var layout3 = new StackLayout();
                layout3.Children.Add(new Label() { Text = "name:" + location.cate });
                //layout3.Children.Add(new Label() { Text = "Spay:" + location.Spay });
                //layout3.Children.Add(new Label() { Text = "Name:" + location.Name });
                //layout3.Children.Add(new Label() { Text = "Day:" + location.Day });
                //layout3.Children.Add(new Label() { Text = "Longitude:" + location.Longitude });
                //layout3.Children.Add(new Label() { Text = "Num:" + location.Num });
                //layout3.Children.Add(new Label() { Text = "Day:" + location.Day });
                layout2.Children.Add(layout3);
            }

            layout.Children.Add(layout2);


        }

        public async void Delete(goalmoney1 item1)
        {
            await App.Database1.DeleteItemAsync(item1);
            await DisplayAlert("削除", "", "OK");
        }

    }


}