using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp06022022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money("test", 180);
           // Money money = new Money("руб", 13890);
            Console.WriteLine(money);

            Console.ReadLine();
            // 2 объект делегата
            Money.MoneyConvertDelegate del = null;

            //6/ добавить в делегат метод конвертации руб-> в доллар
            del += delegate (double amount)
              {
                  return amount * 0.013;
              };

            // протестируем
            money.MakeConvertOperation(del);
            del += delegate (double amount)
              {
                  return amount * 0.37;
              };

            // лямбда
            

            money.MakeConvertOperation(del);


        }
    }
}
