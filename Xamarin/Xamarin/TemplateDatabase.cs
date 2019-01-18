using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace Xamarin
{
    public class TemplateDatabase
    {
        readonly SQLiteAsyncConnection database;

        public TemplateDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Template>().Wait();
        }

        public Task<List<Template>> GetItemsAsync()
        {
            return database.Table<Template>().ToListAsync();
        }

        public Task<List<Template>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Template>("SELECT * FROM [Template] WHERE [Done] = 0");
        }

        public Task<Template> GetItemAsync(int id)
        {
            return database.Table<Template>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        /* public Task<List<Template>> GetItemDay(System.Collections.Generic.List<System.DateTime> day)
         {
             var DayList = day;
             DateTime Daykd = day[0];
             return database.QueryAsync<Template>("SELECT * FROM [LocationItem] WHERE Day = " + Daykd);
         }*/


        public Task<int> SaveItemAsync(Template item)
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

        public Task<int> DeleteItemAsync(Template item)
        {
            return database.DeleteAsync(item);

        }
    }
}