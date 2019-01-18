using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Home();
            //MainPage = new ResultPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        static LocationItemDatabase database;
        static goalmoney1Database database1;
        static incomeDatabase database2;
        static salarymoneyDatabase database3;
        static fixed_costDatabase database4;
        static TemplateDatabase database5;

        public static LocationItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    String ss = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    String s = Path.Combine(ss, "LocationSQLite.db4");
                    database = new LocationItemDatabase(s);
                }
                return database;
            }
        }

        public static goalmoney1Database Database1
        {
            get
            {
                if (database1 == null)
                {
                    String ss = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    String s = Path.Combine(ss, "LocationSQLite.db5");
                    database1 = new goalmoney1Database(s);
                }
                return database1;
            }
        }

        public static incomeDatabase Database2
        {
            get
            {
                if (database2 == null)
                {
                    String ss = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    String s = Path.Combine(ss, "LocationSQLite.db6");
                    database2 = new incomeDatabase(s);
                }
                return database2;
            }
        }

        public static salarymoneyDatabase Database3
        {
            get
            {
                if (database3 == null)
                {
                    String ss = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    String s = Path.Combine(ss, "salarymoneySQLite.db1");
                    database3 = new salarymoneyDatabase(s);
                }
                return database3;
            }
        }

        public static fixed_costDatabase Database4
        {
            get
            {
                if (database4 == null)
                {
                    String ss = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    String s = Path.Combine(ss, "LocationSQLite.db7");
                    database4 = new fixed_costDatabase(s);
                }
                return database4;
            }
        }

        public static TemplateDatabase Database5
        {
            get
            {
                if (database5 == null)
                {
                    String ss1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    String s1 = Path.Combine(ss1, "TemplateSQLite.db1");
                    database5 = new TemplateDatabase(s1);
                }
                return database5;
            }
        }
    }
}
