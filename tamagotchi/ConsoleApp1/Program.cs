using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Welcome to Tamagotchi!");


Tamagotchi myTama = new Tamagotchi();



Console.WriteLine("Vad vill du döpa din Tamagotchi till");
myTama.Name = Console.ReadLine();

Console.WriteLine($"Snyggt! {myTama.Name}, är en jättefin namn");
Console.WriteLine("Tryck på valfri knapp för att fortsätta!");
Console.ReadKey();

while (myTama.GetAlive() == true)
{
    Console.Clear();
    myTama.PrintStats();
    Console.WriteLine("Now what do you want to do");
    Console.WriteLine($"1. Teach {myTama.Name} an new word");
    Console.WriteLine($"2. Talk to {myTama.Name}");
    Console.WriteLine($"3. Feed {myTama.Name}");
    Console.WriteLine($"2. Talk to {myTama.Name}");
    Console.WriteLine($"4. Do nothing");


    string doWhat = Console.ReadLine();
    if (doWhat == "1")
    {
        Console.WriteLine("What word?");
        string word = Console.ReadLine();
        myTama.Teach(word);
    }
    else if (doWhat == "2")
    {
        myTama.Hi();
    }
    else if (doWhat == "3")
    {
        myTama.Feed();
    }
    else
    {
        Console.WriteLine("Doing nothing...");
    }
    myTama.Tick();
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
}


Console.WriteLine($"OH NO! {myTama.Name} is dead!");
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();