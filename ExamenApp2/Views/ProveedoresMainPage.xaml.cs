using ExamenApp2.ViewModels;

namespace ExamenApp2.Views;

public partial class ProveedoresMainPage : ContentPage
{
	private ProveedoresMainPageViewModels viewModels;
	public ProveedoresMainPage()
	{
        InitializeComponent();
        viewModels = new ProveedoresMainPageViewModels();
        this.BindingContext = viewModels;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
		viewModels.GetAll();
    }
}