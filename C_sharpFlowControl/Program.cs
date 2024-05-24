using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Text;

namespace C_sharpFlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;


            while (running)
            {
                FunctionSelection(ShowMenu()); //Call the Take in the user input and convert the string representation to an integer

            }
        }




        private static void Youth_And_Pensioner()
        {
            string prompt = "menu choice";
            Console.WriteLine("\nYouth and Pensioner");
            Console.WriteLine("A cinema where you can enquire the cost of a single ticket based on age and if desired find the cost of a group booking dependant on the group size and age");
            Console.WriteLine("\n\t1. Single ticket\n\t2. Group tickets");
            uint userResponse = CheckValidInput(prompt); //Checks user input validity "How many people in the party"
            AgeTest(userResponse);  //Passes the response and then allows user enter ages and calculate ticket prices.


        }



        private static void Repeat_Ten_Times()
        {
            string[] TenTimes = new string[10];
            string prompt = "enter text to be printed";

            Console.WriteLine("\nRepeat Ten Times");
            Console.WriteLine("A short phrase or sentence and the function will print the enter content in 10 times in a long row");

            string userResponse = CheckValidText(prompt); //Checks user input validity "How many people in the party"*/


            for (int count = 0; count < 10; count++)
            {

                TenTimes[count] = userResponse;
                Console.Write($"{count + 1}. {TenTimes[count]} ");


            }
            Console.WriteLine("\n");

        }



        private static void The_Third_Word()
        {

            string prompt = "sentence";

            Console.WriteLine("\nThe Third Word");
            Console.WriteLine("This function will take a sentence entered by the user(must be at least 3 words) and will print the 3rd word from that sentence");

            string userResponse = CheckValidText(prompt); //Checks user input validity "enter sentence to be processed"*/
            string[] thirdWord = userResponse.Split(' ');

            //string[] thirdWord = CheckSentenceLength(userResponse, prompt); will work on trying to get Sentence length test logic to work

            for (int index = 0; index < thirdWord.Length; index++)
            {
                if (index == 2)                                                 //
                {
                    Console.Write($"\nSentence input \n\t{userResponse}.");
                    Console.Write($"\nThird word is: {thirdWord[index]}");
                }
            }

        }




        private static string CheckValidText(string prompt) //ensuring the user input is valid i.e. not a control character or letters etc.
        {

            bool success = false;
            string answer = string.Empty;
           

            do

            {
                Console.Write($"\n{prompt}: ");
                answer = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(answer) || string.IsNullOrEmpty(answer))
                {
                    Console.Write($"\nYou must enter valid {prompt}");
                }
              
                else 
 
                    success = true;

            } while (!success);

            return answer;
        }



       /* private static string[] CheckSentenceLength(string userResponse, string prompt) //ensuring sentence length is at least 3 words but just now can't get the logic to work
        {

           
            bool success = false;
            string[] test = userResponse.Split(' ');
            string answer;


            do

            {
               

                if (test.Length < 3)
                {
                    Console.Write($"\nYou must enter a valid {prompt}");

                    Console.Write($"\n{prompt}: ");
                    answer = Console.ReadLine()!;
                    Array.Resize(ref test, test.Length);
                    string [] test = answer.Split(" ");
                }

                else

                    success = true;



            } while (!success);

            return test;
        }*/









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
            string prompt2 = "group size";
            int youth = 0;
            int pensioner = 0;
            int theRest = 0;


            if (userResponse == 1)
            {

               collecting_ages.Add(CheckValidInput(prompt));

              
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

            if (userResponse == 2)
            {
                Console.Write($"\nHow many people in the group? ");
                uint groupSize = (CheckValidInput(prompt2));

                for (int i = 0; i < groupSize; i++)
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


                Console.WriteLine($"\tTotal number of people in party: {groupSize}\n\tTotal cost for the party: {(youth * 80) + (pensioner * 90) + (theRest * 120)}kr\n");

            }
            else if (userResponse == 0)
                        
            {
                Console.WriteLine($"\tNumber of people is: {userResponse}\n\tTotal cost is: {(youth * 80) + (pensioner * 90) + (theRest * 120)}kr\n");
            }

        }




        public static uint ShowMenu()  // User introduction
        {

            string prompt = "menu choice";
            Console.WriteLine("\n\nWelcome to the function main menu select an option below\n");
            Console.Write($"\t0: Shutdown program\n\t1: Youth or Pensioner.\n\t2: Repeat ten times.\n\t3: The 3rd word.\n");

            uint userResponse = CheckValidInput(prompt);

            return userResponse;

        }



        public static void FunctionSelection(uint userChoice) //Select function tree
        {



            switch (userChoice)
            {

                case 0:
                    Console.WriteLine("Program shutdown");
                    Environment.Exit(0);
                    break;

                case 1:
                    Youth_And_Pensioner();
                    break;

                case 2:
                    Repeat_Ten_Times();
                    break;

                case 3:
                    The_Third_Word();
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
