using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Practica13MVVM_6011464
{
    public partial class DistanciaViewModel : ObservableObject
    {
        [ObservableProperty]
        private string coordenadaX1;

        [ObservableProperty]
        private string coordenadaY1;

        [ObservableProperty]
        private string coordenadaX2;

        [ObservableProperty]
        private string coordenadaY2;

        [ObservableProperty]
        private string mensajeDeDistancia;

        [RelayCommand]
        private void CalcularDistanciaEntrePuntos()
        {
            if (double.TryParse(CoordenadaX1, out double x1) &&
                double.TryParse(CoordenadaY1, out double y1) &&
                double.TryParse(CoordenadaX2, out double x2) &&
                double.TryParse(CoordenadaY2, out double y2))
            {
                double distancia = CalcularDistancia(x1, y1, x2, y2);
                MensajeDeDistancia = $"La distancia entre los puntos es {distancia:F2} unidades.";
            }
            else
            {
                MensajeDeDistancia = "Ingresar números válidos. ";
            }
        }

        private double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
           
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
