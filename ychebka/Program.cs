internal class Program
{
    static void Main()
    {
        Console.WriteLine("Name");
        string? Name = Console.ReadLine();
        Console.WriteLine("Age");
        byte? Age = Convert.ToByte(Console.ReadLine());
        int rab;
        //int[] cvote = {0, 1, 2, 3, 4, 5};

        if (Age < 18)
            Console.WriteLine("you pidor maloletny");
        else
        {
            Console.WriteLine("Bank");
            bool c = int.TryParse(Console.ReadLine(), out int Bank);
            if (c)
            {
                Console.WriteLine("Ты хорошо работал этот месяц?");
                string? a = Console.ReadLine();
                a ??= " "; // Если a == null то меняем на " "


                if (a.ToUpper() == "ДА" || a.ToUpper() == "YES")
                {
                    Console.WriteLine("Оцени как ты работал от 0 - 5");
                    rab = Convert.ToInt32(Console.ReadLine());
                    if (rab == 0) Console.WriteLine("Ты долбаеб? ЕБАШЬ РАБОТАТЬ!!!");
                    if (rab == 1)
                    {
                        if (rab == 2) Console.WriteLine("держи на хлеб и на молоко) +1000");
                        Bank += 100;
                    }
                    if (rab == 2)
                    {
                        Console.WriteLine("держи на хлеб и на молоко) +1000");
                        Bank += 1000;
                    }
                    if (rab == 3)
                    {
                        Console.WriteLine("на в ебучку +5000");
                        Bank += 5000;
                    }
                    if (rab == 4)
                    {
                        Console.WriteLine("нахуй столько работать? +15000");
                        Bank += 15000;
                    }
                    if (rab == 5)
                    {
                        Console.WriteLine("БЛЯТЬ ЗАЕБАЛ, И ТАК ДЕНЕГ НЕТ +30000");
                        Bank += 30000;
                    }
                }
                else Console.Write("ЕБАШЬ РАБОТАТЬ!!!");
            }
            else
            {
                Console.WriteLine("Введите блять число мудак!");
            }
            Console.WriteLine($"Name {Name}\nAge {Age}\nBank {Bank}");
        }

    }
}