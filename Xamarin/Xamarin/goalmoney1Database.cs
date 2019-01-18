using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;



namespace Xamarin
{
    public class goalmoney1Database
    {
        readonly SQLiteAsyncConnection database;

        public goalmoney1Database(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<goalmoney1>().Wait();
        }

        public Task<List<goalmoney1>> GetItemsAsync()
        {
            return database.Table<goalmoney1>().ToListAsync();
        }

        public Task<List<goalmoney1>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<goalmoney1>("SELECT * FROM [goalmoney1Database] WHERE [Done] = 0");
        }

        public Task<goalmoney1> GetItemAsync(int id)
        {
            return database.Table<goalmoney1>().Where(i => i.ID == id).FirstOrDefaultAsync();
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


        public Task<int> SaveItemAsync(goalmoney1 item)
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

        public Task<int> DeleteItemAsync(goalmoney1 item)
        {
            return database.DeleteAsync(item);

        }
    }
}