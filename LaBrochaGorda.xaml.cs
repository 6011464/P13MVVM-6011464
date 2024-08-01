namespace Practica13MVVM_6011464;

public partial class LaBrochaGorda : ContentPage
{
	public LaBrochaGorda()
	{
		InitializeComponent();
        BindingContext = new PinturaViewModel();
    }
}