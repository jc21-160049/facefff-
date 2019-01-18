using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;



namespace Xamarin
{
    public class incomeDatabase
    {
        readonly SQLiteAsyncConnection database;

        public incomeDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<income>().Wait();
        }

        public Task<List<income>> GetItemsAsync()
        {
            return database.Table<income>().ToListAsync();
        }

        public Task<List<income>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<income>("SELECT * FROM [LocationItem] WHERE [Done] = 0");
        }

        public Task<income> GetItemAsync(int id)
        {
            return database.Table<income>().Where(i => i.ID == id).FirstOrDefaultAsync();
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


        public Task<int> SaveItemAsync(income item)
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

        public Task<int> DeleteItemAsync(income item)
        {
            return database.DeleteAsync(item);

        }
    }
}