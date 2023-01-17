using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        var path = @"C:\Courses C#\Module13\Text1.txt";

        var timer1 = new Stopwatch();

        timer1.Start();          
        var textFile = new List<string>();
        var myList = File.ReadAllLines(path);      
        foreach(var item in myList)
        {
            textFile.Add(item);
        }
        timer1.Stop();

        var timer2 = new Stopwatch();

        timer2.Start();
        var textFile2 = new LinkedList<string>();
        var myList2 = File.ReadAllLines(path);
        foreach(var item in myList2)
        {
            textFile2.AddLast(item);
        }
        timer2.Stop();

        Console.WriteLine("Время работы List: {0} милесекунд.", timer1.ElapsedMilliseconds);
        Console.WriteLine("Время работы LinkedList: {0} милесекунд.", timer2.ElapsedMilliseconds);

    }
}