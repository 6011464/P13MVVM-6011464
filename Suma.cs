using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica13MVVM_6011464
{




    public partial class SumaViewModel : ObservableObject
    {
        [ObservableProperty]
        private string numeroUno;

        [ObservableProperty]
        private string numeroDos;

        [ObservableProperty]
        private string resultado;

        [RelayCommand]
        private void CalcularSuma()
        {
            if (double.TryParse(NumeroUno, out double num1) &&
                double.TryParse(NumeroDos, out double num2))
            {
                Resultado = (num1 + num2).ToString();
            }
            else
            {
                Resultado = "Ingrese números válidos.";
            }
        }

    }
    }