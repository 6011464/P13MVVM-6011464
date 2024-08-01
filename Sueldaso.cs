using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Practica13MVVM_6011464
{
    public partial class SueldoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string sueldoOriginal;

        [ObservableProperty]
        private string mensajeDeSueldo;

        [RelayCommand]
        private void AplicarAumentoMagico()
        {
            if (double.TryParse(SueldoOriginal, out double sueldo))
            {
                double aumento = sueldo < 1000 ? 0.15 : 0.12;
                double nuevoSueldo = sueldo * (1 + aumento);
                MensajeDeSueldo = $" El nuevo sueldo es {nuevoSueldo:F2} uni.";
            }
            else
            {
                MensajeDeSueldo = "Ingresar un sueldo válido";
            }
        }
    }
}