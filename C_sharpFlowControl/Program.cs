using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace C_sharpFlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {



            do
            {
                FunctionSelection(ShowMenu()); //Call the Take in the user input and convert the string representation to an integer

            } while (true);
        }




        private static void YouthOrPensioner()
        {
            string prompt = "How many are you?";
            //string prompt2 = "";
            Console.WriteLine("\nYouth and Pensioner");
            Console.WriteLine("Here at a theoretical cinema we'll see if you or your party qualify for Youth or Pensioner priced tickets");
            uint userResponse = CheckValidInput(prompt); //Checks user input validity "How many people in the party"
            AgeTest(userResponse);  //Passes the response and then allows user enter ages and calculate ticket prices.


        }


        private static uint CheckValidInput(string prompt) //ensuring the user input is valid i.e. not a control character or letters etc.
        {

            bool success = false;
            string answer = string.Empty;
            uint ok_Result = 0;

            do

            {
                Console.Write($"\n{prompt}: ");
                answer = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(answer))
                {
                    Console.Write($"\nYou must enter a valid {prompt}");
                }
                if (uint.TryParse(answer, out uint result))
                {
                    //Console.WriteLine($"\nConverted {answer} to {result}");

                    ok_Result = result;
                    success = true;

                }


            } while (!success);

            return ok_Result;
        }




        private static void AgeTest(uint userResponse)
        {

            List<uint> collecting_ages = new List<uint>();
            string prompt = "Age";
            int youth = 0;
            int pensioner = 0;
            int theRest = 0;


            if (userResponse == 1)
            {

                for (int i = 0; i < userResponse; i++)
                {

                    collecting_ages.Add(CheckValidInput(prompt));

                }

                foreach (var each_age in collecting_ages)
                {

                    if (each_age < 20)
                    {
                        Console.WriteLine($"Youth Price: 80kr");
                    }
                    else if (each_age > 64)
                    {
                        Console.WriteLine($"Pensioner Price: 90kr");
                    }
                    else
                    {
                        Console.WriteLine($"Standard Price: 120kr");
                    }

                }

            }

            if (userResponse > 1)
            {

                for (int i = 0; i < userResponse; i++)
                {

                    collecting_ages.Add(CheckValidInput(prompt));

                }

                foreach (var each_age in collecting_ages)
                {

                    if (each_age < 20)
                    {
                        youth++;

                    }
                    else if (each_age > 64)
                    {
                        pensioner++;

                    }
                    else
                    {
                        theRest++;

                    }

                }


                Console.WriteLine($"\tTotal number of people in party: {userResponse}\n\tTotal cost for the party: {(youth * 80) + (pensioner * 90) + (theRest * 120)}kr\n");

            }
            else
            {
                Console.WriteLine($"\tNumber of people is: {userResponse}\n\tTotal cost is: {(youth * 80) + (pensioner * 90) + (theRest * 120)}kr\n");
            }

        }




        public static uint ShowMenu()  // User introduction
        {

            string prompt = "menu choice";
            Console.WriteLine("Test the functions by selecting one of the menu options below\n");
            Console.Write($"\t1: Youth or Pensioner.\n\t2: Repeat 10 times.\n\t3: The 3rd word.\n");

            uint userResponse = CheckValidInput(prompt);

            return userResponse;

        }



        public static void FunctionSelection(uint userChoice) //Select function tree
        {



            switch (userChoice)
            {

                case 0:
                    Console.WriteLine("Oops, you've just closed the program");
                    Environment.Exit(0);
                    break;

                case 1:
                    YouthOrPensioner();
                    break;

                case 2:
                    Console.WriteLine($"To be completed");
                    break;

                case 3:
                    Console.WriteLine($"To be completed");
                    break;

                default:
                    string prompt = "menu option";
                    Console.WriteLine("\nNot a valid option. Please enter a valid menu option");
                    userChoice = CheckValidInput(prompt);
                    FunctionSelection(userChoice);
                    break;




            }
        }








    }

}
