using SQLite;

namespace Ejercicio_CRUD_Mvvm.Models
{
	public class Producto
	{
		[PrimaryKey, AutoIncrement]	
        public int Id { get; set; }
		[NotNull]
		public string Nombre { get; set; }
		public string Descripcion { get; set; }
		public decimal Precio { get; set; }
		public int Stock { get; set; }

	}
}
