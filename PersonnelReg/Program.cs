namespace PersonnelReg
{

    /*     Qu1. Employee class
     *     Qu2. Attributes: Firstname, Surname, Salary. Methods for printing
     */





    internal class Program
    {
        static void Main(string[] args)

        {
           


           Console.WriteLine("Enter employee first name <press enter> " + "then surname <press enter> " + "then salary figure <press enter>");
           
           Employee person = new Employee(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));


           


          

        }
    }
}
