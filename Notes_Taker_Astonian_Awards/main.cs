Console.Writeline("What would you like to note down? ");
string text = Console.Readline();

note Note1 = new note(text);

Console.WriteLine("Check for completion: 1 = Completed");
Console.WriteLine("Check for completion: 2 = Half-Way There");
Console.WriteLine("Check for completion: 3 = Not Completed At All");
Console.Write("How far have you completed "+Note1+"?");
int completion_check_digit = Console.Readline();

Note1.check(completion_check_digit);

/* 
This project is an application that allows you to write notes
*/