bool success = false;
int ageNum = 0;
int money = 100;
int antalet1 = 0;
int antalbox = 0;
int antalet2 = 0;
int antallott = 0;
int antalet3 = 0;
int antalpigelin = 0;
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
     Console.WriteLine($"inventory du har {antalbox} mysteryboxar, {antallott} lotter, {antalpigelin} pigeliner");
     Console.WriteLine("");
     Console.WriteLine("du kan köpa");
     Console.WriteLine("- mysterybox: pris 100$");
     Console.WriteLine("- lott: pris 20$");
     Console.WriteLine("- pigelin: 5$");
    Console.WriteLine("");
    Console.WriteLine("vad vill du köpa?");
    Console.WriteLine("");
    Console.WriteLine("om du vill tjärna mer pengar skriv pengar");
    Console.WriteLine("skriv ät om du vill äta dina glassar, skriv öppna om du vill öppna mysterybox eller lott");
     Console.WriteLine("");
    string köpa = Console.ReadLine();
    if (köpa == "pengar"){
        while(true){
        Console.Clear();
        Console.WriteLine("skriv på b för att tjärna pengar");
        Console.WriteLine("annars för att läna skriv avsluta");
        Console.WriteLine("");
        Console.WriteLine($"{money}$");
        string makingmoney = Console.ReadLine();
        Console.Clear();
    if (makingmoney.ToLower() == "b"){
        money++;
    }
    else if (makingmoney.ToLower() == "bb"){
        money += 10;
    }
    if (makingmoney.ToLower() == "avsluta"){
      break;  
    }
        }
    }
       else  if (köpa == "mysterybox"){
        Console.Clear();
        Console.WriteLine("hur många vill du köpa?");

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
       else if(money >= 0){
        antalet1 /= 100;
        Console.Clear();
        Console.WriteLine($"du köpte {antalet1} mysteryboxes, nu har du {money}$ kvar");
        antalbox += antalet1;
        Thread.Sleep(2000);
       }
       
       
    }
    else if (köpa == "lott"){
        Console.Clear();
        Console.WriteLine("hur många vill du köpa?");

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
       else if(money >= 0){
        antalet2 /= 20;
        Console.Clear();
        Console.WriteLine($"du köpte {antalet2} lott, nu har du {money}$ kvar");
        antallott += antalet2;
        Thread.Sleep(2000);
        
       }



    } 
    else if (köpa == "pigelin"){
        Console.Clear();
        Console.WriteLine("hur många vill du köpa?");

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
       else if(money >= 0){
        antalet3 /= 5;
        Console.Clear();
        Console.WriteLine($"du köpte {antalet3} pigelin, nu har du {money}$ kvar");
        antalpigelin += antalet3;
        Thread.Sleep(2000);
       }
    }
        else if (köpa.ToLower() == "äta"){
        while(true){
        Console.Clear();
        Console.WriteLine($"du har {antalpigelin} vill du äta en pigelin ja/nej ?");
        string äta = Console.ReadLine();
        if(äta == "ja"){
            if(antalpigelin == 0){
                antalpigelin++;
            }
            antalpigelin --;
             Console.Clear();
            Console.WriteLine("mums!");
            Thread.Sleep(1000);
            Console.Clear();
        }
        else if (äta == "nej"){
            break;
        }
        }
    }
    else if (köpa.ToLower() == "öppna"){
        Console.Clear();
        Console.WriteLine($"Du har {antalbox} mysteryboxar och {antallott} lotter");
        Console.WriteLine("");
         Console.WriteLine("vilken vill du öppna?");
         string öppnaalternativ = Console.ReadLine();
         if (öppnaalternativ == "mysterybox"){
            Console.Clear();
            if(antalbox == 0){
                antalbox++;
                money -= 200;
            }
            Console.WriteLine("tryck på enter för att öppna");
            antalbox--;
            money += 200;
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



            //     var key = Console.ReadKey(intercept: true);
            // Console.ReadKey();
            // if (key.Key == ConsoleKey.B){
            //     money++;
            // }

// for (int j=0; j < 10; j++)
// {
//     Console.WriteLine("hej");
// }