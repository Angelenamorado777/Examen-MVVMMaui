using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Examen_Mvvm.ViewModels
{
public partial class MainViewModel : ObservableObject
    {
[ObservableProperty]
private double? producto1;

[ObservableProperty]
private double? producto2;

[ObservableProperty]
private double? producto3;

[ObservableProperty]
private double subtotal;

[ObservableProperty]
private double descuento;

[ObservableProperty]
 private double totalPagar;

[RelayCommand]
private void Calcular()
        {
            double p1 = Producto1 ?? 0;
            double p2 = Producto2 ?? 0;
            double p3 = Producto3 ?? 0;

            Subtotal = p1 + p2 + p3;

            if (Subtotal < 1000)
            {
                Descuento = 0;
            }
            else if (Subtotal >= 1000 && Subtotal < 5000)
            {
                Descuento = Subtotal * 0.10;
            }
            else if (Subtotal >= 5000 && Subtotal < 10000)
            {
                Descuento = Subtotal * 0.20;
            }
            else if (Subtotal >= 10000 && Subtotal < 20000)
            {
                Descuento = Subtotal * 0.30;
            }
            else
            {
                Descuento = 0;
            }

            TotalPagar = Subtotal - Descuento;
        }

        [RelayCommand]
        private void Limpiar()
        {
            Producto1 = null;
            Producto2 = null;
            Producto3 = null;
            Subtotal = 0;
            Descuento = 0;
            TotalPagar = 0;
        }
    }
}