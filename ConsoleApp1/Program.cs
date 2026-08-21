List<string> votes = [];
while (true)
{
    Console.WriteLine("Vilket parti vill du rösta på");
    Console.WriteLine("1. Kalle Anka-partiet");
    Console.WriteLine("2. Allt-åt-alla");
    Console.WriteLine("3. Sudo-partiet");
    Console.WriteLine("4. Nörddemokraterna");
    Console.WriteLine("5. NTI-partiet");
    Console.WriteLine("6. Cthulhu");
    string choice = Console.ReadLine();

    if (choice == "q")
    {
        break;
    }

    votes.Add(choice);

    Console.Clear();
}

int kallenanka = 0;
for (int i = 0; i < votes.Count; i++)
{
    string vote = votes[i];
    if (vote == "1")
    {
        kalleanka++;
    }
}

int alltåtalla = 0;
for (int i = 0; i < votes.Count; i++)
{
    string vote = votes[i];
    if (vote == "2")
}


Console.WriteLine("Kalle Anka-partiet: " + kalleanka);

Console.ReadLine();