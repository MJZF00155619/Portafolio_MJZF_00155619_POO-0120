  
using System;
using System.Collections.Generic;

namespace Pre_Parcial3
{
    internal class Program
    {
        private delegate void MyDelegate(List<CuentaBancaria> c);
        static MyDelegate del;
        
        public static void Main(string[] args)
        {
            int option;
            var Propietarios = new List<CuentaBancaria>();
            Action<List<CuentaBancaria>> myAction;
            Action<List<CuentaBancaria>> myAction2;
            Action<List<CuentaBancaria>> myAction3;
            string nombre;
            double saldo;
            bool continuar = true;
            do
            {
                Console.WriteLine(
                    "Ingrese la opcion que desea \n 1. Agregar cuenta \n 2.Ver cuentas almacenadas \n 3. Ver cuentas y total de las cuentas \n 4.Ver cuentas, total de cuentas y cuentas de personas cuyo nombre empieza en vocal \n 5. Salir");
                try
                {
                option = Convert.ToInt16(Console.ReadLine());
                
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el nombre: ");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el saldo actual");
                            saldo = Convert.ToDouble(Console.ReadLine());

                            Propietarios.Add(new CuentaBancaria(nombre, saldo));
                            break;
                        case 2:
                            del = new MyDelegate(VerCuentas);
                            del(Propietarios);
                            break;
                        case 3:
                            del = new MyDelegate(VerCuentas);
                            del(Propietarios);
                            del = new MyDelegate(TotalCuentas);
                            del(Propietarios);
                            break;
                        case 4:
                            myAction2 = VerCuentas;
                            myAction3 = TotalCuentas;
                            myAction = Vocal;
                            
                            myAction2.Invoke(Propietarios);
                            myAction3.Invoke(Propietarios);
                            myAction.Invoke(Propietarios);
                            break;
                        case 5:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Numero fuera del rango permitido");
                            break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Error, ha ingresado un formato invalido");
                    option = 0;
                }

            } while (continuar);
        }
        public static void VerCuentas(List<CuentaBancaria> prop)
        {
            Mostrar1 Mostrando1 = new Mostrar1();
            Mostrando1.Viendo(prop);
        }
        
        public static void TotalCuentas(List<CuentaBancaria> Prop2)
        {
            Mostrar2 Mostrando2 = new Mostrar2();
            Mostrando2.Viendo(Prop2);
        }
        
        public static void Vocal(List<CuentaBancaria> prop3)
        {
            Mostrar3 Mostrando3 = new Mostrar3();
            Mostrando3.Viendo(prop3);
        }
        
    }
}