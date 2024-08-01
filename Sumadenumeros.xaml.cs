namespace Practica13MVVM_6011464;

public partial class Sumadenumeros : ContentPage
{
	public Sumadenumeros()
	{
		InitializeComponent();
		  BindingContext = new SumaViewModel();
	}
}