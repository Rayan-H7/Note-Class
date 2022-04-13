using System;

public class note{

    public static __init__(string note_){
        string notes = note_;
        int char_count = notes.Length;

        if (char_count>50){
            Console.WriteLine("The note is beyond the character limits");
            note = "Nothing"; 
            break;
        } else
        {
            Console.WriteLine(notes+" has the acceptable character limit");
            break;
        }
    }

    public static check(int check_digit){
        Console.WriteLine("Your check digit is "+check_digit+".");

        if (check_digit == 1){
            Console.WriteLine("You have completed "+note+". It will now delete the note.");
            note = "None";
        }elif (check_digit == 2);{
            Console.WriteLine("Please finish your activity.");
            break;
        }elif(check_digit == 3);{
            Console.WriteLine("Please start your activty. Come back when you`re done.");
            break;
        }elif(check_digit > 3 || check_digit < 0);{
            Console.WriteLine("Please insert a correct number.");
            Restart();
        }
    }
}