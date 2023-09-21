using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ychebka
{
    internal class Func
    {
        public static int IfRab(int rab,int Bank)
        {
            if (rab == 0) Console.WriteLine("Ты долбаеб? ЕБАШЬ РАБОТАТЬ!!!");
            else  if (rab == 1)
            {
                Console.WriteLine("держи на хлеб и на молоко) +100");
                Bank += 100;
            }
            else if (rab == 2)
            {
                Console.WriteLine("держи на хлеб и на молоко) +1000");
                Bank += 1000;
            }
            else if (rab == 3)
            {
                Console.WriteLine("на в ебучку +5000");
                Bank += 5000;
            }
            else if (rab == 4)
            {
                Console.WriteLine("нахуй столько работать? +15000");
                Bank += 15000;
            }
            else if (rab == 5)
            {
                Console.WriteLine("БЛЯТЬ ЗАЕБАЛ, И ТАК ДЕНЕГ НЕТ +30000");
                Bank += 30000;
            }
            return Bank;
        }
    }
}
