using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {// Küsib, kas lähed v tuled; sugu
            string userAnswer;
            string gender;
            Console.WriteLine("Are you coming or leaving");
            userAnswer = Console.ReadLine();
            Console.WriteLine("What is your gender?");
            gender = Console.ReadLine();
           

            if (userAnswer.ToLower() == "coming")
            {
                Hello(gender);
            }


            else if (userAnswer.ToLower() == "leaving")
            {
                Goodbye(gender);
            }
            
            Console.ReadLine();
        }

        public static void Hello(string gender)
        {
            if (gender == "female")
            {
                Console.WriteLine("Hello, Madam!");
            }    
            
            else if (gender == "male")
            {
                Console.WriteLine("Hello, Sir!");
            }
                

        }

        
        public static void Goodbye(string gender)
        {
            if (gender == "male")
            
            {
                Console.WriteLine("Goodbye, Sir!");
            }
            else if (gender == "female")
            {
                Console.WriteLine("Goodbye, Madam!");
            }
            
        }
        
       

        
    }
    
}
