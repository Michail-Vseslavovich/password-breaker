using System.Diagnostics;


string allow = "abcdefghijklmnopqrstuvwxyz1234567890";
string test;
Console.WriteLine("Введите ваш пароль без спец. символов");
string password = Console.ReadLine().ToLower();

var stopwatch = new Stopwatch();
stopwatch.Start();
Random rnd = new Random();

while (true)
{
    test = "";
    for (int i = 0; i < password.Length; i++)
    {
        
        test += allow[rnd.Next(0, 36)];

    }
    
    if (test == password)
    {
        Console.WriteLine(test);
        break;
    }
}

stopwatch.Stop();
TimeSpan ts = stopwatch.Elapsed;
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
    ts.Hours, ts.Minutes, ts.Seconds,
    ts.Milliseconds / 10);
Console.WriteLine("RunTime " + elapsedTime);
Console.ReadLine();