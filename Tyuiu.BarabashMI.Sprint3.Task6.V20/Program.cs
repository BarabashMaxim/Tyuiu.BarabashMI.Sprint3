using Tyuiu.BarabashMI.Sprint3.Task6.V20.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнил Барабаш М. И. | ИИПб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #2                                                                *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                *");
        Console.WriteLine("* Задание #0                                                               *");
        Console.WriteLine("* Вариант #18                                                              *");
        Console.WriteLine("* Выполнил: Барабаш Максим Игоревич | ИИПб-25-1                            *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,     *");
        Console.WriteLine("* которая вернет логическую последовательность(массив),                    *");
        Console.WriteLine("* при x = 5105, y = 475                                                    *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("");



        Console.WriteLine();
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine(ds.GetSumTheDivisors(20, 32));






        Console.ReadKey();
    }
}