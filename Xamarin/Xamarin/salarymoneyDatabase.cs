using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;



namespace Xamarin
{
    public class salarymoneyDatabase
    {
        readonly SQLiteAsyncConnection database;

        public salarymoneyDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<salarymoney>().Wait();
        }

        public Task<List<salarymoney>> GetItemsAsync()
        {
            return database.Table<salarymoney>().ToListAsync();
        }

        public Task<List<salarymoney>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<salarymoney>("SELECT * FROM [salarymoney] WHERE [Done] = 0");
        }

        public Task<salarymoney> GetItemAsync(int id)
        {
            return database.Table<salarymoney>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<List<salarymoney>> GetItemDay(System.Collections.Generic.List<System.DateTime> day)
        {
            var DayList = day;
            DateTime Daykd = day[0];
            return database.QueryAsync<salarymoney>("SELECT * FROM [salarymoney] WHERE Day = " + Daykd);
        }


        public Task<int> SaveItemAsync(salarymoney item)
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

        public Task<int> DeleteItemAsync(salarymoney item)
        {
            return database.DeleteAsync(item);

        }
    }
}