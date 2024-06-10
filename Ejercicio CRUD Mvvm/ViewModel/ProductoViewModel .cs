
using CommunityToolkit.Mvvm.Input;
using Ejercicio_CRUD_Mvvm.Models;
using Ejercicio_CRUD_Mvvm.Sevrices;
using Ejercicio_CRUD_Mvvm.Views;
using System.ComponentModel;

namespace Ejercicio_CRUD_Mvvm.ViewModels
{
	public partial class ProductoViewModel : INotifyPropertyChanged
	{
		private ProductoDatabase _database;
		private Producto _producto = new Producto();

		public event PropertyChangedEventHandler? PropertyChanged;

		public string Nombre
		{
			get { return _producto.Nombre; }
			set { _producto.Nombre = value; }
		}

		public string Descripcion
		{
			get { return _producto.Descripcion; }
			set { _producto.Descripcion = value;  }
		}

		public decimal Precio
		{
			get { return _producto.Precio; }
			set { _producto.Precio = value; }
		}

		public int Stock
		{
			get { return _producto.Stock; }
			set { _producto.Stock = value; }
		}

		[RelayCommand]
		public async Task gotoAddProductoPage()
		{

			await App.Current!.MainPage!.Navigation.PushAsync(new ProductPage());
			
		}
	}
}
