using System;
using System.Collections.Generic;

namespace Pre_Parcial3
{ 
    public class Mostrar1 : CuentaBancaria
    {
        
        public void Viendo(List<CuentaBancaria> prop)
        {
            Console.WriteLine("Mostrando...");
            
            prop.ForEach((element) =>
            {
                Console.WriteLine($"nombre: {element._nombre} \n Saldo actual: {element._saldoActual}");
            });
            Console.WriteLine("");
        }
    }
}