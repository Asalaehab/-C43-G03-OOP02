using WorkShop.Overload;

namespace WorkShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            int size;

            do
            {
                Console.Write("Enter Size");
                flag=int.TryParse(Console.ReadLine(), out size);
            } while (! flag);

            Employee[] employees = Employee.CreateEmployee(size);
            

            Employee.InsertEmployees(employees);
            Console.Clear();
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }



            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(2, 2));

        }
    }
}