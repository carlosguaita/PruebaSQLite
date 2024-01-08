using PruebaSQLite.MVVM.ViewModels;

namespace PruebaSQLite.MVVM.Views;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
		BindingContext = new NuevoProductoViewModel();
	}
}
