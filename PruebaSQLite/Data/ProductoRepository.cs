using System;
using PruebaSQLite.MVVM.Models;
using PruebaSQLite.Utils;
using SQLite;

namespace PruebaSQLite.Data
{
	public class ProductoRepository
	{
		SQLiteConnection connection;

		public ProductoRepository()
		{
			connection = new SQLiteConnection(Util.DataBasePath,Util.Flags);
			connection.CreateTable<Producto>();
		}

		public void Add(Producto producto)
		{
			int result = 0;
			try
			{
				result = connection.Insert(producto);
				Console.WriteLine("Se agrego un producto");
			}
			catch(Exception ex)
			{
                Console.WriteLine("No se agrego un producto "+ex.Message);
            }
		}

		public List<Producto> GetAll()
		{
            try
            {
                Console.WriteLine("Se agrego un producto");
                return connection.Table<Producto>().ToList();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se agrego un producto " + ex.Message);
            }
			return null;
        }

        public void Update(Producto producto)
        {
            int result = 0;
            try
            {
                if(producto.IdProducto!=0)
                {
                    result = connection.Update(producto);
                }
                Console.WriteLine("Se agrego un producto");

            }
            catch (Exception ex)
            {
                Console.WriteLine("No se agrego un producto " + ex.Message);
            }
  
        }

        public Producto Get(int IdProducto)
        {
     
            try
            {
                if (IdProducto != 0)
                {
                   return connection.Table<Producto>()
                        .FirstOrDefault(x=>x.IdProducto==IdProducto);
                }
                Console.WriteLine("Se agrego un producto");

            }
            catch (Exception ex)
            {
                Console.WriteLine("No se agrego un producto " + ex.Message);
            }
            return null;

        }

        public void Delete(int IdProducto)
        {
          
            try
            {
                if (IdProducto != 0)
                {
                    Producto result = Get(IdProducto);
                    connection.Delete(result);
                }
                Console.WriteLine("Se agrego un producto");

            }
            catch (Exception ex)
            {
                Console.WriteLine("No se agrego un producto " + ex.Message);
            }

        }
    }
}

