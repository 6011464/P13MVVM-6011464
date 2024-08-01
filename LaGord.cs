using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace Practica13MVVM_6011464
{
    public partial class PinturaViewModel : ObservableObject
    {
        [ObservableProperty]
        private string areaEnMetros;

        [ObservableProperty]
        private string tarifaPorMetro;

        [ObservableProperty]
        private string mensajeDeFactura;

        [RelayCommand]
        private void CalcularFacturaDePintura()
        {
            if (double.TryParse(AreaEnMetros, out double area) &&
                double.TryParse(TarifaPorMetro, out double tarifa))
            {
                double total = area * tarifa;
                MensajeDeFactura = $"El costo total para pintar es {total:F2} uni. ";
            }
            else
            {
                MensajeDeFactura = "Ingresado números válidos. ";
            }
        }
    }
}
