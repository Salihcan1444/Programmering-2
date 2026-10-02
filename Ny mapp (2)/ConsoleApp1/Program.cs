Console.WriteLine("Hello, World!");

Monster m1 = new();
Monster m2 = new();

m2.Hp -= 10;

Console.WriteLine(m1.Hp);

Console.ReadLine();




class Monster
{
    public int Hp;
    public string Name = "Ted";
    public bool Fabulous = true;
}