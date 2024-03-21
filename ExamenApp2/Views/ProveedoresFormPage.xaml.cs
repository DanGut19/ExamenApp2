using ExamenApp2.Models;
using ExamenApp2.ViewModels;

namespace ExamenApp2.Views;

public partial class ProveedoresFormPage : ContentPage
{
	private ProveedoresFormPageViewModels viewModels;
	public ProveedoresFormPage()
	{
		InitializeComponent();
		viewModels = new ProveedoresFormPageViewModels();
		this.BindingContext = viewModels;
	}

	public ProveedoresFormPage(Proveedores proveedores)
	{
        InitializeComponent();
		viewModels = new ProveedoresFormPageViewModels();
		this.BindingContext = viewModels;
    }
}