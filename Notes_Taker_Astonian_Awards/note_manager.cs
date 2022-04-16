using System;

namespace Notes_Taker_Astonian_Awards
{
    public class note{
        public static string content (string note_){
            string notes = note_;
            int char_count = notes.Length;
            
            if (char_count>50){
                string char_ = "The note is beyond the character limits";
                return char_;
                note_ = "Nothing";
                Console.WriteLine(note_);
            } else
            {
                string char_ = notes+" has the acceptable character limit";
                return char_;
                note_ = notes;
                Console.WriteLine(note_);
            }
        }
    }

    public static string check(int check_digit, string note_){
        Console.WriteLine("Your check digit is "+check_digit+".");
        
        if (check_digit == 1){
            Console.WriteLine("You have completed "+note_+". It will now delete the note.");
            note_ = "None";
        }else if (check_digit == 2){
            Console.WriteLine("Please finish your activity.");
        }else if(check_digit == 3){
            Console.WriteLine("Please start your activty. Come back when you`re done.");
        }else if(check_digit > 3 || check_digit < 0){
            Console.WriteLine("Please insert a correct number.");
        }
        }
    }
}