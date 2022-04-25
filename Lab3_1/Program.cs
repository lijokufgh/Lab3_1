public class Program
{
    public class Lab_1 // Создаём основной класс.
    {
        public double log; // Переменая для логорифма.
        public double osn; // Переменая для основания.
        public int okr; // Переменая для округления.

        public Lab_1() // Заполняем переменные. Выводиться при вызови объекта.
        {
            Console.WriteLine("Введите логорифм: ");
            log = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите основани: ");
            osn = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите до скольки знаков округлять: ");
            okr = int.Parse(Console.ReadLine());
        }
    }

    public static void Main() // Основная функция.
    {
        Lab_1 lab1 = new Lab_1(); // Создание объекта.
        Console.WriteLine(Math.Round(Math.Log(lab1.log, lab1.osn), lab1.okr)); // Проводим логарифмирование и округление.
    }
}