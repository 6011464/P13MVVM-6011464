namespace Practica13MVVM_6011464;

public partial class TrianguloBase : ContentPage
{
	public TrianguloBase()
	{
		InitializeComponent();
        BindingContext = new TrianguloViewModel();
    }
}