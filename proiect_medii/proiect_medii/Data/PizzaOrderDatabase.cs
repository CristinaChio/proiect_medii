using proiect_medii.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace proiect_medii.Data
{
    public class PizzaOrderDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public PizzaOrderDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<PizzaOrder>().Wait();
            _database.CreateTableAsync<Product>().Wait();
            _database.CreateTableAsync<ListProduct>().Wait();

        }
        public Task<int> SaveProductAsync(Product product)
        {
            if (product.ID != 0)
            {
                return _database.UpdateAsync(product);
            }
            else
            {
                return _database.InsertAsync(product);
            }
        }
        public Task<int> DeleteProductAsync(Product product)
        {
            return _database.DeleteAsync(product);
        }
        public Task<List<Product>> GetProductsAsync()
        {
            return _database.Table<Product>().ToListAsync();
        }


        public Task<List<PizzaOrder>> GetPizzaOrderAsync()
        {
            return _database.Table<PizzaOrder>().ToListAsync();
        }
        public Task<PizzaOrder> GetPizzaOrderAsync(int id)
        {
            return _database.Table<PizzaOrder>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SavePizzaOrderAsync(PizzaOrder plist)
        {
            if (plist.ID != 0)
            {
                return _database.UpdateAsync(plist);
            }
            else
            {
                return _database.InsertAsync(plist);
            }
        }
        public Task<int> DeletePizzaOrderAsync(PizzaOrder plist)
        {
            return _database.DeleteAsync(plist);
        }
        public Task<int> SaveListProductAsync(ListProduct listp)
        {
            if (listp.ID != 0)
            {
                return _database.UpdateAsync(listp);
            }
            else
            {
                return _database.InsertAsync(listp);
            }
        }
        public Task<List<Product>> GetListProductsAsync(int shoplistid)
        {
            return _database.QueryAsync<Product>(
            "select P.ID, P.Description from Product P"
            + " inner join ListProduct LP"
            + " on P.ID = LP.ProductID where LP.PizzaOrderID = ?",
            shoplistid);
        }
    }
}

