internal class Program
{
     static void Main()
    {
        Console.WriteLine("Name");
        string? Name = Console.ReadLine();
        Console.WriteLine("Age");
        byte? Age = Convert.ToByte(Console.ReadLine());
        int zp = Convert.ToInt32(70000);
        int Bank;


        if (Age < 18)
            Console.WriteLine("you pidor maloletny");
        else
        {
            Console.WriteLine("Bank");
            bool c = int.TryParse(Console.ReadLine(), out Bank);
            if (c)
            {
                Console.WriteLine("Ты хорошо работал этот месяц?");
                string? a = Console.ReadLine();
                a ??= " "; // Если a == null то меняем на " "


                if (a.ToUpper() == "ДА" || a.ToUpper() == "YES")
                {
                    Console.WriteLine("На в ебучку +70к"); Bank = zp + Bank;
                    Console.WriteLine($"Name {Name}\nAge {Age}\nBank {Bank}");

                }
                else Console.Write("ЕБАШЬ РАБОТАТЬ!!!");
            }
            else
            {
                Console.WriteLine("Введите блять число мудак!");
            }
        }

    }
}