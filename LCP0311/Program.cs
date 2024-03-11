// MIS 3013 001
// March 11, 2024
// Alexandra Camarena
// 113568154

Console.WriteLine("Exam 2 Practice 1");

string menuStr = "*************************";

menuStr = $"{menuStr}\nSales System Menu";
menuStr = $"{menuStr}\n1. Add a new order";
menuStr = $"{menuStr}\n2. Show summary information";
menuStr = $"{menuStr}\n*************************";

while (true)
{ 
    Console.WriteLine(menuStr);

    Console.Write("Enter an option: ");
    string userChoiceStr= Console.ReadLine();

    if (userChoiceStr == "1")
    { // add a new order
    }
    else if (userChoiceStr == "2")
    { // show summary information
    }
    else
    {
        Console.WriteLine("Thank you and goodbye!");
        break;
    }
}
