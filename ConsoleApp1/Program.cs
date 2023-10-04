bool loop = true;
int choice = 0;
Dictionary<string, string> dict = new Dictionary<string, string>();
dict.Add("Danny", "0888820728");
dict.Add("Pavel", "0888812421");
dict.Add("Ivan", "0884820718");
dict.Add("Ivan1", "0888123119");
while (loop == true)
{
    Console.WriteLine("1. Print all numbers");
    Console.WriteLine("2. Add new number");
    Console.WriteLine("3. Remove number");
    Console.WriteLine("4. Quit");

    choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        foreach (KeyValuePair<string, string> pair in dict)
        {
            Console.WriteLine($"{pair.Key},{pair.Value}");
        }
    }
    else if (choice == 2)
    {
        Console.Write("Enter the name of the new contact: ");
        string name = Console.ReadLine();
        Console.Write("Enter the number of the new contact: ");
        dict.Add(name, Console.ReadLine());

    }
    else if (choice == 3)
    {
        Console.Write("Enter the name of a contact you want to remove: ");
        dict.Remove(Console.ReadLine());
    }
    else
    {
        loop = false;
    }

}
