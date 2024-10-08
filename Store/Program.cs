for (int j=0; j < 10; j++)
{
    Console.WriteLine("hej");
}

bool success = false;
int ageNum = 0;
int money = 100;
while (success != true)
{
    Console.WriteLine("ålder:");
    string age = Console.ReadLine();

    success = int.TryParse(age, out ageNum);

    if (ageNum >= 18){
    Console.Clear();
    Console.WriteLine("välkommen in i butiken!");
     Thread.Sleep(1500);
    while(true){
        Console.Clear();
     Console.Clear();
     Console.WriteLine($"dina pengar {money}$");
     Console.WriteLine("");
     Console.WriteLine("du kan köpa");
     Console.WriteLine("- mysterybox: pris 100$");
     Console.WriteLine("- lott: pris 20$");
     Console.WriteLine("- pigelin: 5$");
    Console.WriteLine("");
    Console.WriteLine("vad vill du köpa?");
                var key = Console.ReadKey(intercept: true);
            Console.ReadKey();
            if (key.Key == ConsoleKey.B){
                money++;
            }
    string köpa = Console.ReadLine();
        if (köpa == "mysterybox"){
        Console.Clear();
        Console.WriteLine("hur många vill du köpa?");

        int antalet1 = 0;
        while(!int.TryParse(Console.ReadLine(), out antalet1)){
            Console.Clear();
            Console.WriteLine("det är inte ett nummer");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("hur många vill du köpa!");
        }
       antalet1 *= 100;
       money -= antalet1;
       if(money < 0){
        Console.Clear();
        Console.WriteLine("du har inte råd med det!");
        money += antalet1;
        Thread.Sleep(2000);
        continue;
       }
       if(money >= 0){
        antalet1 /= 100;
        Console.Clear();
        Console.WriteLine($"du köpte {antalet1} mysteryboxes, nu har du {money}$ kvar");
        Thread.Sleep(2000);
       }
       
       
    }
    if (köpa == "lott"){
        Console.Clear();
        Console.WriteLine("hur många vill du köpa?");

        int antalet2 = 0;
        while(!int.TryParse(Console.ReadLine(), out antalet2)){
            Console.Clear();
            Console.WriteLine("det är inte ett nummer");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("hur många vill du köpa!");
    }
           antalet2 *= 20;
       money -= antalet2;
       if(money < 0){
        Console.Clear();
        Console.WriteLine("du har inte råd med det!");
        money += antalet2;
        Thread.Sleep(2000);
        continue;
       }
       if(money >= 0){
        antalet2 /= 20;
        Console.Clear();
        Console.WriteLine($"du köpte {antalet2} mysteryboxes, nu har du {money}$ kvar");
        Thread.Sleep(2000);
       }



    } 
    if (köpa == "pigelin"){
        Console.Clear();
        Console.WriteLine("hur många vill du köpa?");

        int antalet3 = 0;
        while(!int.TryParse(Console.ReadLine(), out antalet3)){
            Console.Clear();
            Console.WriteLine("det är inte ett nummer");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("hur många vill du köpa!");
    }
           antalet3 *= 5;
       money -= antalet3;
       if(money < 0){
        Console.Clear();
        Console.WriteLine("du har inte råd med det!");
        money += antalet3;
        Thread.Sleep(2000);
        continue;
       }
       if(money >= 0){
        antalet3 /= 5;
        Console.Clear();
        Console.WriteLine($"du köpte {antalet3} pigelin, nu har du {money}$ kvar");
        Thread.Sleep(2000);
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
}
}
Console.ReadLine();