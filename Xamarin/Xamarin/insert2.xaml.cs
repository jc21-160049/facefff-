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
    public partial class insert2 : ContentPage
    {

        public String dd;
        public String[] In;
        public int[] Tm;
        public int x = 0;
        public static string[] button = new string[30];
        public static string[] b;
        public static string[] c;
        //public static List<DateTime> dTime = new List<DateTime>();

        public insert2()//List<DateTime> dTime)
        {
            InitializeComponent();
            ddd.Text = Home.ddt[0].ToString("日付：yyyy年MM月dd日");
            dd = Home.ddt[0].ToString("yyyy/MM/dd");
            a();
            b1.Clicked += b1Clicked;
            b2.Clicked += b2Clicked;
            b3.Clicked += b3Clicked;
            b4.Clicked += b4Clicked;
            b5.Clicked += b5Clicked;
            b6.Clicked += b6Clicked;
            b7.Clicked += b7Clicked;
            b8.Clicked += b8Clicked;
            b9.Clicked += b9Clicked;
            b10.Clicked += b10Clicked;
            b11.Clicked += b11Clicked;
            b12.Clicked += b12Clicked;

        }

        private void b1Clicked(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[0],
                Spay = Tm[0],
                Day = dt1
            };
            Save(item);
        }

        private void b2Clicked(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[1],
                Spay = Tm[1],
                Day = dt1
            };
            Save(item);
        }

        private void b3Clicked(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[2],
                Spay = Tm[2],
                Day = dt1
            };
            Save(item);
        }

        private void b4Clicked(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[3],
                Spay = Tm[3],
                Day = dt1
            };
            Save(item);
        }

        private void b5Clicked(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[4],
                Spay = Tm[4],
                Day = dt1
            };
            Save(item);
        }

        private void b6Clicked(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[5],
                Spay = Tm[5],
                Day = dt1
            };
            Save(item);
        }

        private void b7Clicked(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[6],
                Spay = Tm[6],
                Day = dt1
            };
            Save(item);
        }

        private void b8Clicked(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[7],
                Spay = Tm[7],
                Day = dt1
            };
            Save(item);
        }

        private void b9Clicked(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[8],
                Spay = Tm[8],
                Day = dt1
            };
            Save(item);
        }

        private void b10Clicked(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[9],
                Spay = Tm[9],
                Day = dt1
            };
            Save(item);
        }

        private void b11Clicked(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[10],
                Spay = Tm[10],
                Day = dt1
            };
            Save(item);
        }

        private void b12Clicked(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[11],
                Spay = Tm[11],
                Day = dt1
            };
            Save(item);
        }

        /*private void b1(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Parse(dd);
            LocationItem item = new LocationItem()
            {
                Name = In[0],
                Spay = Tm[0],
                Day = dt1
            };
            Save(item);
        }*/

        public async void a()
        //protected override async void OnAppearing()
        {
            base.OnAppearing();
            var result = await App.Database5.GetItemsAsync();

            int size = result.Count;
            b = new string[size];
            int y = 0;
            /*foreach(var location in result)
            {
                string jj = location.Tmoney.ToString();
                c[y] = jj;
                b[y] = location.Iname;
            }*/
            In = new string[size];
            Tm = new int[size];
            //var lay2 = new StackLayout() { Spacing = 10 };
            // Button lay5 = new Button();


            foreach (var location in result)
            {

                string LT = location.Tmoney.ToString();
                //var lay3 = new StackLayout();

                //Button lay3 = new Button() { Text = LT + " (" + location.Iname + ")" };

                //Button button1 = new Button();
                //b[x] = new Button() { Text = LT + " (" + location.Iname + ")" };
                //lay3.Children.Add(new Button() { Text = LT + " (" + location.Iname + ")" });
                In[x] = location.Iname;
                Tm[x] = location.Tmoney;
                x++;
                button[roop()] = LT + " (" + location.Iname + ")";
                //lay2.Children.Add(lay3);
                //lay5 = lay3;
            }
            b1.Text = button[0];
            b2.Text = button[1];
            b3.Text = button[2];
            b4.Text = button[3];
            b5.Text = button[4];
            b6.Text = button[5];
            b7.Text = button[6];
            b8.Text = button[7];
            b9.Text = button[8];
            b10.Text = button[9];
            b11.Text = button[10];
            b12.Text = button[11];

            if (b1.Text == null)
            {
                b1.BackgroundColor = Color.White;
            }
            if (b2.Text == null)
            {
                b2.BackgroundColor = Color.White;
            }
            if (b3.Text == null)
            {
                b3.BackgroundColor = Color.White;
            }
            if (b4.Text == null)
            {
                b4.BackgroundColor = Color.White;
            }
            if (b5.Text == null)
            {
                b5.BackgroundColor = Color.White;
            }
            if (b6.Text == null)
            {
                b6.BackgroundColor = Color.White;
            }
            if (b7.Text == null)
            {
                b7.BackgroundColor = Color.White;
            }
            if (b8.Text == null)
            {
                b8.BackgroundColor = Color.White;
            }
            if (b9.Text == null)
            {
                b9.BackgroundColor = Color.White;
            }
            if (b10.Text == null)
            {
                b10.BackgroundColor = Color.White;
            }
            if (b11.Text == null)
            {
                b11.BackgroundColor = Color.White;
            }
            if (b12.Text == null)
            {
                b12.BackgroundColor = Color.White;
            }
            //layout.Children.Add(lay2);
            //lay5.Clicked += lay5Clicked;
        }

        public int roop()
        {
            int a = 0;
            for (int i = 0; i <= 11; i++)
            {
                if (button[i] == null)
                {
                    a = i;
                    break;
                }
            }
            return a;
        }
        /* private void lay5Clicked(object sender, EventArgs e)
         {

             DateTime dt1 = DateTime.Parse(dd);
             LocationItem item = new LocationItem()
             {
                 Name = In[x],
                 Spay = Tm[x],
                 Day = dt1
             };
             Save(item);
         }*/

        public async void Save(LocationItem item1)
        {
            await App.Database.SaveItemAsync(item1);
            await DisplayAlert("DATA", "登録しました", "OK");
        }

    }
}