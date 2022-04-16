using System;

namespace Notes_Taker_Astonian_Awards
{
    class Program
    {
        static void __init__(string[] args)
        {
            Console.WriteLine ("What would you like to note down? ");
            string text = Console.ReadLine();
            note Note1 = new note();
            Note1.content = text;
            Console.WriteLine("Check for completion: 1 = Completed");
            Console.WriteLine("Check for completion: 2 = Half-Way There");
            Console.WriteLine("Check for completion: 3 = Not Completed At All");
            Console.Write("How far have you completed "+Note1+"?");
            int completion_check_digit = Convert.ToInt16(Console.ReadLine());
            Note1.check(completion_check_digit);
            /* This project is an application that allows you to write notes
            */
        }
    }
}
