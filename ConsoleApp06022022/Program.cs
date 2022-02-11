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
            Money money = new Money("test", 13890);
           // Money money = new Money("руб", 13890);
            Console.WriteLine(money);


            // 2 объект делегата
            Money.MoneyConvertDelegate del = null;

            //6/ добавить в делегат анонимный метод конвертации руб-> в доллар
            del += delegate (double amount)
              {
                  // умножаем на курс
                  return amount * 0.013;
              };

            // протестируем
            money.MakeConvertOperation(del);

            // конвертация рубля в гривну
            del += delegate (double amount)
              {
                  return amount * 0.37;
              };
            money.MakeConvertOperation(del);
            // лямбда
            del = (amount) => amount * 0.000007;

            money.MakeConvertOperation(del);

            Console.ReadLine();
        }
    }
}
