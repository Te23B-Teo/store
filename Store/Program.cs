for (int j=0; j < 10; j++)
{
    Console.WriteLine("hej");
}

bool success = false;
int ageNum = 0;
int money = 100;
int mysterybox = 100;
int lott = 20;
int pigelin = 5;
while (success != true)
{
    Console.WriteLine("ålder:");
    string age = Console.ReadLine();

    success = int.TryParse(age, out ageNum);

    if (ageNum >= 18)
    {
        Console.Clear();
            Console.WriteLine("välkommen in i butiken!");
     Thread.Sleep(1500);
     Console.Clear();
     Console.WriteLine($"dina pengar {money}$");
     Console.WriteLine("");
     Console.WriteLine("du kan köpa");
     Console.WriteLine("- en mysterybox: pris 100$");
     Console.WriteLine("- en lott: pris 20$");
     Console.WriteLine("- en pigelin: 5$");
    Console.WriteLine("");
    Console.WriteLine("vad vill du köpa?");
    string köpa = Console.ReadLine();
    if (köpa == "mysterybox"){
        Console.WriteLine("hur många vill du köpa?");
       string antal1 = Console.ReadLine();
       int antalet1 = 0;
       int.TryParse(antal1, out antalet1);
       money * antalet1;
    }
    }
    else if (success == false)
    {
        Console.Clear();
        Console.WriteLine("det är inte en ålder");
        Thread.Sleep(1000);
        Console.Clear();
    }
    else if (ageNum < 18)
    {
        Console.Clear();
        Console.WriteLine("bad luck big guy!");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("du får inte besöka butiken, hejdå!");
        Thread.Sleep(1500);
        Console.Clear();
        break;
    }
}
Console.ReadLine();