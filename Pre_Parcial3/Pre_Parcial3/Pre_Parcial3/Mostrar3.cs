using System;
using System.Collections.Generic;

namespace Pre_Parcial3
{
    public class Mostrar3 : CuentaBancaria
    {
        public void Viendo(List<CuentaBancaria> prop3)
        {
            var start_vocal = new List<CuentaBancaria>();
            
            Console.WriteLine("\nPROPIETARIOS CUYO NOMBRE COMIENZA CON VOCAL");
            
            prop3.ForEach(element =>
            {
                if (element._nombre.ToUpper().StartsWith("A") || element._nombre.ToUpper().StartsWith("E") || element._nombre.ToUpper().StartsWith("I") || element._nombre.ToUpper().StartsWith("O") || element._nombre.ToUpper().StartsWith("U"))
                {
                    start_vocal.Add(new CuentaBancaria(element._nombre,element._saldoActual));
                }
            });
            
            start_vocal.ForEach(element =>
            {
                Console.WriteLine($"nombre: {element._nombre} \n Saldo actual: {element._saldoActual}");
            });
            Console.WriteLine("");
          
        }
    }
}