using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PE2_Estrada
{
    class Ingresar
    {
        public int[] Ingresa(int large)
        {
            int[] values = new int[large];
            for (int count = 0; count < large; count++)
            {
                Console.Write("\nIngresa el valor {0}: ", count + 1);
                values[count] = Convert.ToInt32(Console.ReadLine());
            }
            return values;
        }
    }
    class ValorMayor
    {
        public int NumMay(int count, int mayor, int[] numeros)
        {

            if (count != numeros.Length)
            {
                if (numeros[count] > mayor)
                {
                    mayor = NumMay(count + 1, numeros[count], numeros);
                }
                else
                {
                    mayor = NumMay(count + 1, mayor, numeros);
                }
            }
            return mayor;
        }
    }
    class ValorMinimo
    {
        public int NumMin(int count, int minimo, int[] numeros)
        {

            if (count != numeros.Length)
            {
                if (numeros[count] < minimo)
                {
                    minimo = NumMin(count + 1, numeros[count], numeros);
                }
                else
                {
                    minimo = NumMin(count + 1, minimo, numeros);
                }
            }
            return minimo;
        }
    }
    class Invertir
    {
        public void Inver(int veces, params int[] valores)
        {
            double numero = 0;
            if (veces > 0)
            {
                numero = valores[veces - 1];
                Console.Write(numero + " ");
                Inver(veces - 1, valores);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            while (opcion != 4)
            {
                try
                {

                    Console.WriteLine("1.- El numero mínimo");
                    Console.WriteLine("2.- El numero máximo");
                    Console.WriteLine("3.- Invertir los numeros");
                    Console.WriteLine("4.- Sair");
                    Console.Write("Que opcion desea ver: ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Cuantos desea ingresar: ");
                    int large = Convert.ToInt32(Console.ReadLine());
                    Ingresar pedor = new Ingresar();
                    int[] values = new int[large];
                    values = pedor.Ingresa(large);

                    switch (opcion)
                    {
                        case 1:
                            ValorMinimo minimo = new ValorMinimo();
                            Console.Write("El numero minimo es: " + minimo.NumMin(0, values[0], values));
                            Console.ReadKey();
                            break;
                        case 2:
                            ValorMayor mayor = new ValorMayor();
                            Console.Write("El numero mayor es: " + mayor.NumMay(0, values[0], values));
                            Console.ReadKey();
                            break;
                        case 3:
                            Invertir llamada = new Invertir();
                            Console.Write("Los números invertidos son: ");
                            llamada.Inver(large, values);
                            Console.ReadKey();
                            break;
                        case 4:
                            opcion = 4;
                            break;
                    }
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }



}
