using System.Reflection.Metadata;

//do
//{
//    //Intro to program
//    Console.WriteLine("Hello!");
//    Console.WriteLine("");
//    Console.WriteLine("What do you want to do?");
//    Console.WriteLine("[S]ee all todos");
//    Console.WriteLine("[A]dd a todo");
//    Console.WriteLine("[R]emove a todo");
//    Console.WriteLine("[E]xit");
//} while(userMenuChoice != inputChoice);


//Intro to program
Console.WriteLine("Hello!");
Console.WriteLine("");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all todos");
Console.WriteLine("[A]dd a todo");
Console.WriteLine("[R]emove a todo");
Console.WriteLine("[E]xit");

string userMenuChoice = Console.ReadLine();

//executes TodoMenuChoices method
TodoMenuChoices(userMenuChoice);


//all the methods nees to return strings
//string TodoMenuChoices(string userMenuChoice)
//{
//    switch (userMenuChoice)
//    {
//        case "S":
//        case "s":
//            return SeeAllTodo();
//        case "A":
//        case "a":
//            return AddTodo();
//        case "R":
//        case "r":
//            return RemoveTodo();
//        case "E":
//        case "e":
//            return Exit();
//        default:
//            return "Invalid option. Please choose S, A, R, or E.";
//    }
//}

//all the methods nees to return strings
string TodoMenuChoices(string userMenuChoice)
{
    if (userMenuChoice == "S" || userMenuChoice == "s")
    {
        Console.WriteLine("Displaying all todos.");
        return SeeAllTodo();
    }
    else if(userMenuChoice == "A" || userMenuChoice == "a")
    {
        Console.WriteLine("Added a todo.");
        return SeeAllTodo(); 
    }
    else if(userMenuChoice == "R" || userMenuChoice == "r")
    {
        Console.WriteLine("Removing a todo.");
        return RemoveTodo();
    }
    else if (userMenuChoice == "E" || userMenuChoice == "e")
    {
        Console.WriteLine("Exiting the program.");
        return Exit();
    }
    Console.WriteLine("Invalid option. Please choose S, A, R, or E.");
    return "Invalid option. Please choose S, A, R, or E.";
}

// Placeholder methods
string SeeAllTodo()
{
    return "Displaying all todos.";
    //return insertVaribaleForAllTodos;
}

string AddTodo()
{
    return "Adding a todo.";    
    //return "Adding" + insertVaribaleToBeAdded;
}

string RemoveTodo()
{
    return "Removing a todo.";    
    //return "Removing" + insertVaribaleToBeDeleted;
}

string Exit()
{
    return "Exiting the program.";
}
