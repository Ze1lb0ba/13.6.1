using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        var path = @"C:\Courses C#\Module13\Text1.txt";

        int i = 0;
        long summaryList = 0;

        while (i < 30000)
        {
            var timer1 = new Stopwatch();
            timer1.Start();
            var textFile = new List<string>();
            var myList = File.ReadAllLines(path);
            foreach (var item in myList)
            {
                textFile.Add(item);
            }
            timer1.Stop();
            i++;
            summaryList += timer1.ElapsedMilliseconds;
        }
        Console.WriteLine("Среднее время работы List после 30 000 итераций: {0} милесекунд.", summaryList/30000);
        i= 0;
        summaryList= 0;

        while (i < 30000)
        {
            var timer2 = new Stopwatch();
            timer2.Start();
            var textFile2 = new LinkedList<string>();
            var myList2 = File.ReadAllLines(path);
            foreach (var item in myList2)
            {
                textFile2.AddLast(item);
            }
            timer2.Stop();
            i++; 
            summaryList += timer2.ElapsedMilliseconds;
        }

        
        Console.WriteLine("Среднее время работы LinkedList после 30 000 итераций: {0} милесекунд.", summaryList/30000);
    }
}