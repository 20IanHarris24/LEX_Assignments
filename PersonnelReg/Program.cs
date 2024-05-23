namespace PersonnelReg
{

    /*     Qu1. Employee class
     *     Qu2. Attributes: Firstname, Surname, Salary. Methods for printing
     *     
     *     updated after watching object tutorials
     */





    internal class Program
    {
        static void Main(string[] args)

        {
            

            Console.Write("first name: ");
            var detail1 = Console.ReadLine();
            Console.Write("surname: ");
            var detail2 = Console.ReadLine();
            Console.Write("salary: ");
            var detail3 = Console.ReadLine();


            Employee person = new Employee(detail1, detail2, detail3);








        }
    }
}
