using System;
using PruebaSQLite.Data;
using PruebaSQLite.MVVM.Models;
using SQLite;

namespace PruebaSQLite.Utils
{
	public class Util
	{

        public static ProductoRepository ProductoRepo { get; set; }

        static public List<Producto> ListaProductos = new List<Producto>()
        {
            new Producto{
                IdProducto=1,
                Nombre="Producto 1",
                Descripcion="Descripcion 1",
                Cantidad=1
            },

            new Producto{
                IdProducto=2,
                Nombre = "Producto 2",
                Descripcion="Descripcion 2",
                Cantidad=2
            }

        };

        private const string DBFileName = "Producto.db";

        public const SQLiteOpenFlags Flags =
           SQLiteOpenFlags.ReadWrite |
           SQLiteOpenFlags.Create |
           SQLiteOpenFlags.SharedCache;

        public static string DataBasePath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}

