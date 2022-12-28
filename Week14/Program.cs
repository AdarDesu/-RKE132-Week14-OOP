// Cat = Class
// AnimeCat && RealCat = string data + int data = Object

Console.WriteLine("Name your cat:");
string CatName = Console.ReadLine();

Cat RealCat = new Cat(CatName);
Cat AnimeCat = new Cat("Sakamoto");

Console.WriteLine($"The real cat is named {RealCat.Name} and it's happiness is {RealCat.PrecentOfHappiness}%.");
Console.WriteLine($"Nichijou has a black cat named {AnimeCat.Name} and his happiness is {AnimeCat.PrecentOfHappiness + 25}%.");


Console.WriteLine("Give the real cat a new name:");
RealCat.Rename(Console.ReadLine());

while (RealCat.PrecentOfHappiness != 50)
{
    RealCat.Meow();
}

Console.WriteLine($"The real cat's happiness is now {RealCat.PrecentOfHappiness}%.");

RealCat.Purr();

class Cat
{
    // Fields
    private string _name;
    private int _precentOfHappiness = 45;


    // Constructor
    public Cat(string Name)
    {
        // Let the user name the cat.
        _name = Name;
        _precentOfHappiness = 45;
    }


    // Getters
    public string Name
    {
        get { return _name; }
    }

    public int PrecentOfHappiness
    {
        get { return _precentOfHappiness; }
    }


    // Methods
    public void Rename(string NewName)
    {
        _name = NewName;
        Console.WriteLine($"The real cat is now named {NewName}.");
    }

    public void Meow()
    {
        Console.WriteLine("Meow-meow!");
        _precentOfHappiness++;
    }

    public void Purr()
    {
        Console.WriteLine("Purr-purr!");
    }

}