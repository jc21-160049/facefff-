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
    public partial class often_use : ContentPage
    {
        string[] t = new string[9];

        public often_use()
        {
            InitializeComponent();
            Register.Clicked += RegisterClicked;

            var komoku1 = new List<string>

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

            foreach (var item in komoku1)

            {

                this.komoku1.Items.Add(item);

            }
            this.t = komoku1.ToArray();

        }

        private void RegisterClicked(object sender, EventArgs e)
        {
            int kin = int.Parse(tmoney.Text);
            string s = (string)komoku1.SelectedItem;

            Template item = new Template()
            {
                Iname = s,
                Tmoney = kin,

            };
            Save(item);


        }
        public async void Save(Template item1)
        {
            await App.Database5.SaveItemAsync(item1);
            await DisplayAlert("DATA", "登録しました", "OK");
        }
    }
}