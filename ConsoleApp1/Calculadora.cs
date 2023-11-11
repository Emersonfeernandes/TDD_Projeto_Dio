using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculadora
    {
        private List<string> ListaHistorico;

        public Calculadora()
        {
            ListaHistorico = new List<string>();
        }
        public int Somar(int num1, int num2) 
        {
            ListaHistorico.Insert(0, "SOMAR" + num1 + num2);
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            ListaHistorico.Insert(0, "SUBTRAIR" + num1 + num2);
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            ListaHistorico.Insert(0, "MULTICAÇÃO" + num1 + num2);
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine($"Não é possivel dividir {num1} por {num2}");
            }
            ListaHistorico.Insert(0, "DIVISAO" + num1 + num2);
            return num1 / num2;
        }

        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}
