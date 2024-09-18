List<string> todoList = new List<string>();
//List<string> todoList = new List<string> { "T1", "T2", "T3" };
bool exitProgram = false;


//Intro to program
Console.WriteLine("Hello!");
Console.WriteLine("");

//why is this true by default
//reference bool to exit while loop but doesn't manipulate data
while (!exitProgram)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");

    string userMenuChoice = Console.ReadLine();

    //executes TodoMenuChoices method
    //Need to pass through 2 parameter to work
    string userPickedResults = TodoMenuChoices(userMenuChoice, todoList, ref exitProgram);
    // You need this to see what is returns from the switch statment 
    Console.WriteLine(userPickedResults);

}

//all the methods need to return strings
//reference bool to exit while loop but doesn't manipulate data
string TodoMenuChoices(string userPickedResults, List<string> todoList, ref bool exitProgram)
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
            exitProgram = true;
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
    //Empty string and 0 count to keep track of of Todos
    string todoResults = "";
    int todoCount = 0;
    foreach (string todo in todoList)
    {
        todoCount++;
        //todoResults keeps track of which todo and description, loops through and strings them together
        //\n put the next todo on the next console line
        todoResults += $"Todo {todoCount}: {todo}\n";

    }
    //return has to be on the outside of the for each loop so it can conintue looping without stopping until the end
    return todoResults;
}


string AddTodo(List<string> todoList)
{
    Console.WriteLine("Please add add a todo");
    string userAddTodo = Console.ReadLine();
    todoList.Add(userAddTodo);
    Console.WriteLine($"{userAddTodo} was succfully added.");
    return userAddTodo;
}


string RemoveTodo(List<string> todoList)
{
    Console.WriteLine("Which todo number would you like to remove.");
    string userRemoveTodo = Console.ReadLine();
    int userRemoveTodoIndex = int.Parse(userRemoveTodo);
    todoList.RemoveAt(userRemoveTodoIndex - 1);

    return "Remove Successfull";
}


string Exit()
{
    return "Exiting the program.";
}

Console.ReadKey();
