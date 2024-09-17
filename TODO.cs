//List<string> todoList = new List<string>();
List<string> todoList = new List<string> { "T1", "T2", "T3" };

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
//Need to pass through 2 parameter to work
string userPickedResults = TodoMenuChoices(userMenuChoice, todoList);
// You need this to see what is returns from the switch statment 
Console.WriteLine(userPickedResults);

//all the methods need to return strings
string TodoMenuChoices(string userPickedResults, List<string> todoList)
{
    switch (userPickedResults)
    {
        case "S":
        case "s":
            return SeeAllTodo(todoList);
        case "A":
        case "a":
            return AddTodo(todoList);
        case "R":
        case "r":
            return RemoveTodo(todoList);
        case "E":
        case "e":
            return Exit();
        default:
            return "Invalid option. Please choose S, A, R, or E.";
    }
}

//Todo Read fetch requests methods
//string SeeAllTodo(List<string> todoList)
string SeeAllTodo(List<string> todoList)
{

    if (todoList.Count == 0)
    {
        return "There are no todos.";
    }

    //string result = "Here are your todos:\n";
    //foreach (string todo in todoList)
    //{
    //    result += todo + "\n";
    //}
    //return result;
    return "total goes here";
}


//string AddTodo(List<string> todoList)
string AddTodo(List<string> todoList)
{
    string userAddTodo = Console.ReadLine();
    todoList.Add(userAddTodo);
    return userAddTodo;
}


string RemoveTodo(List<string> todoList)
{
    return "Removing a todo.";
    //return "Removing" + insertVaribaleToBeDeleted;
}


string Exit()
{
    return "Exiting the program.";
}

Console.ReadKey();
