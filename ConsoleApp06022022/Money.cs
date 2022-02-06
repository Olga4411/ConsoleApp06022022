using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp06022022
{
   internal class Money
    {
       
        //код валюты
        public string CurrencyCode { get; set; }
        //номинал валюты
        public double Amount { get; set; }

       public  Money(string currencyCode, double amount)
        {
            CurrencyCode = currencyCode;
            Amount = amount;

        }
        public override string ToString()
        {
            return $"{Amount},{CurrencyCode}";
        }

        // Работа с делегатами
        // описание делегата
        // делегат, который хранит с 1 параметром double и результатом double
        public delegate double MoneyConvertDelegate(double value);

        public void MakeConvertOperation(MoneyConvertDelegate del)
        {
            if (del!=null)// если делегат не пустой был передан
            {
                double res = del(Amount); // выполняем конвертацию
                Console.WriteLine($"{this}-converting->{res}");
            }
            else
            {
                Console.WriteLine("empty operation");
            }
        }
    }
}
