using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;



namespace Xamarin
{
    public class fixed_costDatabase
    {
        readonly SQLiteAsyncConnection database;

        public fixed_costDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<fixed_costmoney>().Wait();
        }

        public Task<List<fixed_costmoney>> GetItemsAsync()
        {
            return database.Table<fixed_costmoney>().ToListAsync();
        }

        public Task<List<fixed_costmoney>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<fixed_costmoney>("SELECT * FROM [fixed_costDatabase] WHERE [Done] = 0");
        }

        public Task<fixed_costmoney> GetItemAsync(int id)
        {
            return database.Table<fixed_costmoney>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        /*public Task<List<LocationItem>> GetItemDay(System.Collections.Generic.List<System.DateTime> day)
        {
            var DayList = day;
            DateTime Daykd = day[0];
            return database.QueryAsync<LocationItem>("SELECT * FROM [LocationItem] WHERE Day = " + Daykd);
        }

        public Task<List<LocationItem>> GetItemNameAsync(String Name, DateTime dates)
        {
            return database.QueryAsync<LocationItem>("SELECT * FROM [LocationItem] WHERE Name = " + Name + "Day = " + dates);
        }*/


        public Task<int> SaveItemAsync(fixed_costmoney item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(fixed_costmoney item)
        {
            return database.DeleteAsync(item);

        }
    }
}