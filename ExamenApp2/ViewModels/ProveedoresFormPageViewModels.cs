using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExamenApp2.Models;
using ExamenApp2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenApp2.ViewModels
{
    public partial class ProveedoresFormPageViewModels : ObservableObject
    {
        [ObservableProperty]
        private int _id;

        [ObservableProperty]
        private string _nombre;

        [ObservableProperty]
        private string _cliente;

        [ObservableProperty]
        private string _direccion;

        [ObservableProperty]
        private string _empresa;

        [ObservableProperty]
        private string _producto;

        private readonly ProveedoresServices _proveedoresServices;

        public ProveedoresFormPageViewModels()
        {
            _proveedoresServices = new ProveedoresServices();
        }

        public ProveedoresFormPageViewModels(Proveedores proveedores)
        {
            Id = proveedores.Id;
            Nombre = proveedores.Nombre;
            Cliente = proveedores.Cliente;
            Direccion = proveedores.Direccion;
            Empresa = proveedores.Empresa;
            Producto = proveedores.Producto;
        }

        [RelayCommand]
        private async Task CreateUpdate()
        {
            try 
            {
                Proveedores proveedores = new Proveedores
                {
                    Id = Id,
                    Nombre = Nombre,
                    Cliente = Cliente,
                    Direccion = Direccion,
                    Empresa = Empresa,
                    Producto = Producto
                };
                if (Validar(proveedores))
                {
                    if (Id == 0)
                    {
                        _proveedoresServices.Insert(proveedores);
                    }
                    else 
                    {
                        _proveedoresServices.Update(proveedores);
                    }
                    await App.Current!.MainPage!.Navigation.PopAsync();
                }
            }catch (Exception ex) 
            {
                Error(ex.Message);
            }
        }

        private bool Validar(Proveedores proveedores)
        {
            try
            {
                if (proveedores.Nombre == null || proveedores.Nombre == "")
                {
                    Warning("Escriba el Nombre");
                    return false;
                }
                else if (proveedores.Cliente == null || proveedores.Cliente == "")
                {
                    Warning("Escriba el Cliente");
                    return false;
                }
                else if (proveedores.Direccion == null || proveedores.Direccion == "")
                {
                    Warning("Escriba el Direccion");
                    return false;
                }
                else if (proveedores.Empresa == null || proveedores.Empresa == "")
                {
                    Warning("Escriba el Empresa");
                    return false;
                }
                else if (proveedores.Producto == null || proveedores.Producto == "")
                {
                    Warning("Escriba el Producto");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
                return false;
            }
        }

        private async void Error(string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROE", Mensaje, "Aceptar"));
        }

        private async void Warning(string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROE", Mensaje, "Aceptar"));
        }
    }
}