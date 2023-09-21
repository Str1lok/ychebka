using ychebka;
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
                    Bank = Func.IfRab(rab, Bank);
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