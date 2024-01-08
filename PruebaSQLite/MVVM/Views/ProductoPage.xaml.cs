using PruebaSQLite.MVVM.ViewModels;

namespace PruebaSQLite.MVVM.Views;

public partial class ProductoPage : ContentPage
{
	public ProductoPage()
	{
		InitializeComponent();
		BindingContext = new ProductoViewModel();
	}
}
