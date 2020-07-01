using System;
using System.Collections.Generic;

namespace Pre_Parcial3
{
    public class Mostrar2 : CuentaBancaria
    {
        public void Viendo(List<CuentaBancaria> prop)
        {
            double saldos = 0;
            int i = 0;
            
            prop.ForEach(element => { saldos += element._saldoActual;
                i++;
            });
            Console.WriteLine("");
            Console.WriteLine("Total de cuentas: "+ i);
            Console.WriteLine($"Total de saldos de las cuentas: {saldos}");
            Console.WriteLine("");
        }
    }
}