using System;
using System.Windows.Input;
using PruebaSQLite.MVVM.Models;
using PruebaSQLite.MVVM.Views;
using PruebaSQLite.Utils;

namespace PruebaSQLite.MVVM.ViewModels
{
	public class ProductoViewModel
	{
		public List<Producto> ListaProductos {get; set;} 
		public ProductoViewModel()
		{
			ListaProductos = Util.ProductoRepo.GetAll();
		}


		public ICommand CrearProducto =>
			new Command(() =>
			{
				App.Current.MainPage.Navigation.PushAsync(new NuevoProductoPage());
			});
		

	}
}

