//Intro to program
Console.WriteLine("Hello!");
Console.WriteLine("");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all todos");
Console.WriteLine("[A]dd a todo");
Console.WriteLine("[R]emove a todo");
Console.WriteLine("[Exit]");

string userMenuChoice = Console.ReadLine();

string TodoMenuChoices(string userMenuChoice)
{
    switch (userMenuChoice)
    {
        case "S":
        case "s":
            //return SeeAllTodo();
            return "placeholder";
        case "A":
        case "a":
            //return AddATodo();
            return "placeholder";
        case "R":
        case "r":
            //return RemoveTodo();
            return "placeholder";
        case "E":
        case "e":
            //return Exit();
            return "placeholder";
    }
       
}
Console.ReadKey();

