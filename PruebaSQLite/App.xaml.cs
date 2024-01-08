
using PruebaSQLite.Data;
using PruebaSQLite.MVVM.Views;
using PruebaSQLite.Utils;

namespace PruebaSQLite;

public partial class App : Application
{


	public App(ProductoRepository repo)
	{
		InitializeComponent();
		Util.ProductoRepo = repo;
		

		MainPage = new NavigationPage(new ProductoPage());
	}
}

