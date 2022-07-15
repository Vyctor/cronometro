namespace Stopwatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("S = Segundo => 10s = 10 segundos");
      Console.WriteLine("M = Minuto => 1m = 1 minuto");
      Console.WriteLine("H = Hora => 1h = 1 hora");
      Console.WriteLine("0 = Parar");
      Console.Write("Quanto tempo deseja contar? ");

      string data = Console.ReadLine().ToLower();

      if (data == "0")
      {
        Console.WriteLine("Good Bye");
        Environment.Exit(0);
      }

      char type = char.Parse(data.Substring(data.Length - 1, 1));
      int time = int.Parse(data.Substring(0, data.Length - 1));

      var multiplier = 1;

      if (type == 'm')
      {
        multiplier = 60;
      }
      else if (type == 'h')
      {
        multiplier = 3600;
      }

      var totalCountTime = time * multiplier;

      PreStart();
      Start(totalCountTime);
    }

    static void PreStart()
    {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.WriteLine("Set...");
      Thread.Sleep(1000);
      Console.WriteLine("Go...");
      Thread.Sleep(1500);
    }

    static void Start(int time)
    {
      int currentTime = 0;

      while (currentTime < time)
      {
        Console.Clear();
        currentTime++;
        Console.Write("Time => " + currentTime);
        Thread.Sleep(1000);
      }
      Console.Clear();
      Thread.Sleep(500);
      Menu();
    }
  }
}