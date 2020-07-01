using System;
using System.Collections.Generic;

namespace Pre_Parcial3
{
    public class CuentaBancaria
    {
        public readonly string _nombre;
        public readonly double _saldoActual;
        
        public CuentaBancaria(string nombre = "unnamed", double saldo = 0)
        {
            _nombre = nombre;
            _saldoActual = saldo;
        }
        
        public void Viendo(List<CuentaBancaria> prop)
        {
            Console.WriteLine("Mostrando...");
        }
    }
}