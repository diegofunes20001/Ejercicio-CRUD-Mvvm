using Ejercicio_CRUD_Mvvm.Models;
using SQLite;
using System.Collections.Generic;
using System.Data.Common;



namespace Ejercicio_CRUD_Mvvm.Sevrices
{
	public class ProductoDatabase
	{
		private readonly SQLiteAsyncConnection _connection;

		public ProductoDatabase(string dbPath)
		{
			_connection = new SQLiteAsyncConnection(dbPath);
			_connection.CreateTableAsync<Producto>().Wait();
		}

		public Task<List<Producto>> GetProductosAsync()
		{
			return _connection.Table<Producto>().ToListAsync();
		}

		public Task<Producto> GetProductoAsync(int id)
		{
			return _connection.Table<Producto>().Where(i => i.Id == id).FirstOrDefaultAsync();
		}

		public Task<int> SaveProductoAsync(Producto producto)
		{
			if (producto.Id == 0)
			{
				return _connection.InsertAsync(producto);
			}
			else
			{
				return _connection.UpdateAsync(producto);
			}
		}

		public Task<int> DeleteProductoAsync(Producto producto)
		{
			return _connection.DeleteAsync(producto);
		}
	}

}

	

