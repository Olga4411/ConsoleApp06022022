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

        // конструктор
       public  Money(string currencyCode, double amount)
        {
            CurrencyCode = currencyCode;
            Amount = amount;

        }
        // строковое представление
        public override string ToString()
        {
            return $"{Amount}{CurrencyCode}";
        }

        // Работа с делегатами
        // описание делегата
        // делегат, который хранит с 1 параметром double и результатом double
        public delegate double MoneyConvertDelegate(double value);

        // метод, принимающий в качестве параметра делегат и вызывающий его
        public void MakeConvertOperation(MoneyConvertDelegate del)
        {
            Console.WriteLine(this);
            // вызов делегата
            if (del!=null)// если делегат не пустой был передан,
                          // то можим сохранить результат
            {
                double res = del(Amount); // выполняем конвертацию
                Console.WriteLine($"{this}-converting->{res}");// наш объект
            }
            else
            {
                Console.WriteLine("empty operation passed");
            }
        }
    }
}
