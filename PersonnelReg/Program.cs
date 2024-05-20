namespace PersonnelReg
{

    /*     Qu1. Employee class
     *     Qu2. Attributes: Firstname, Surname, Salary. Methods for printing
     */





    internal class Program
    {
        static void Main(string[] args)

        {

            string firstname = "";


            Employee person = new Employee();


            Console.Write("Enter Employee firstname: ");
            person.firstname = Console.ReadLine();
            Console.Write("\n");
            Console.Write("Enter Employee surname: ");
            person.surname = Console.Readline();
            Console.Write("\n");
            Console.Write("Enter Employee salary: ");
            person.salary = int.Parse(Console.Readline());

           

          

        }
    }
}
