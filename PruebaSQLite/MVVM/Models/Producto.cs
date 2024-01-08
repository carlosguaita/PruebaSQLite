using System;
using SQLite;

namespace PruebaSQLite.MVVM.Models
{
    [Table("Productos")]
	public class Producto
	{
        [PrimaryKey, AutoIncrement]
        public int IdProducto { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("descripcion")]
        public string Descripcion { get; set; }
        [Column("cantidad")]
        public int Cantidad { get; set; }

    }
}

