using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Practica13MVVM_6011464
{
    public partial class TrianguloViewModel : ObservableObject
    {
        [ObservableProperty]
        private string primerLado1;

        [ObservableProperty]
        private string segundoLado2;

        [ObservableProperty]
        private string tercerLado3;

        [ObservableProperty]
        private string mensajedelArea;

        [RelayCommand]
        private void CalculoMagico()
        {
            if (double.TryParse(PrimerLado1, out double ld1) &&
                double.TryParse(SegundoLado2, out double ld2) &&
                double.TryParse(TercerLado3, out double ld3))
            {
                if (VerificarSiEsUnTriangulo(ld1, ld2, ld3))
                {
                    double semiPerimetro = (ld1 + ld2 + ld3) / 2;
                    double area = Math.Sqrt(semiPerimetro * (semiPerimetro - ld1) * (semiPerimetro - ld2) * (semiPerimetro - ld3));
                    MensajedelArea = $" El área del triángulo es {area:F2}!";
                }
                else
                {
                    MensajedelArea = "No forman un triángulo";
                }
            }
            else
            {
                MensajedelArea = "Asegúrate de ingresar números válidos";
            }
        }

        private bool VerificarSiEsUnTriangulo(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    } 
}
