public class Program
{
    public class Lab_1 // Создаём основной класс.
    {
        public double log; // Переменная для логарифма.
        public double osn; // Переменная для основания.
        public int okr; // Переменная для округления.

        public Lab_1() // Заполняем переменные. Выводиться при вызови объекта.
        {
            Console.WriteLine("Введите логарифм: ");
            log = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите основание: ");
            osn = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите до скольких знаков округлять: ");
            okr = int.Parse(Console.ReadLine());
        }
    }

    public static void Main() // Основная функция.
    {
        Lab_1 lab1 = new Lab_1(); // Создание объекта.
        Console.WriteLine(Math.Round(Math.Log(lab1.log, lab1.osn), lab1.okr)); // Проводим логарифмирование и округление.
    }
}