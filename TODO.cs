////Might possibly use so menu shows up and then disapears depending on person choices
//do
//{
//    //Intro to program
//    Console.WriteLine("Hello!");
////need a continue
//    Console.WriteLine("");
//    Console.WriteLine("What do you want to do?");
//    Console.WriteLine("[S]ee all todos");
//    Console.WriteLine("[A]dd a todo");
//    Console.WriteLine("[R]emove a todo");
//    Console.WriteLine("[E]xit");
//} while(userMenuChoice != inputChoice);

List<string> todoList = new List<string>();
//List<string> todoList = new List<string> { "1", "2", "3" };


//Console.WriteLine(todoList.Count);

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


////all the methods need to return strings
////For some reason switch doesn't work had to use if/esle instead
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
        //Console.WriteLine("Displaying all todos.");
        return SeeAllTodo(todoList);
    }
    else if (userMenuChoice == "A" || userMenuChoice == "a")
    {
        Console.WriteLine("Added a todo.");
        return AddTodo();
    }
    else if (userMenuChoice == "R" || userMenuChoice == "r")
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

//Todo Read fetch requests methods
string SeeAllTodo(List<string> todoList)
{
    if (todoList.Count > 0)
    {
        return "if statement works";
    }
    return "else works";
}

string SeeAllResult = SeeAllTodo(todoList);
Console.WriteLine(SeeAllResult);

string AddTodo()
{
    if()
    {

    }
    return "Adding a todo.";
}

//string addResult = AddTodo(todoList);
//Console.WriteLine(addResult);

string RemoveTodo()
{
    return "Removing a todo.";
    //return "Removing" + insertVaribaleToBeDeleted;
}

//string removeResult = RemoveTodo(todoList);
//Console.WriteLine(removeResult);

string Exit()
{
    return "Exiting the program.";
}
