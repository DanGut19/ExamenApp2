using CommunityToolkit.Mvvm.ComponentModel;
using ExamenApp2.Models;
using ExamenApp2.Services;
using ExamenApp2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenApp2.ViewModels
{
    public partial class ProveedoresMainPageViewModels : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Proveedores> proveedoresCollection = new ObservableCollection<Proveedores>();

        private readonly ProveedoresServices _proveedoresServices;

        public ProveedoresMainPageViewModels()
        {
            _proveedoresServices = new ProveedoresServices();
        }

        public void GetAll()
        {
            var getAll = _proveedoresServices.GetAll();

            if (getAll.Count > 0)
            {
                proveedoresCollection.Clear();
                foreach (var proveedores in getAll)
                {
                    proveedoresCollection.Add(proveedores);
                }
            }
        }
    }
}
