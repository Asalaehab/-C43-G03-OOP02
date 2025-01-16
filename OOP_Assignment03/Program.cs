using System.Collections.Immutable;

namespace OOP_Assignment03
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];
            EmpArr[0].security = Security.DBA;
            EmpArr[1].security = Security.Guest;
            EmpArr[2].security = (Security)15;
            int ID;
            string name;
            bool flag;

            for (int i = 0; i < EmpArr.Length;)
            {
                Console.Write("Enter ID :");
                flag = int.TryParse(Console.ReadLine(), out ID);
                if (!flag)
                {
                    Console.Write("Enter ID :");
                    flag = int.TryParse(Console.ReadLine(), out ID);
                    continue;
                }
                Console.WriteLine();
                Console.Write("Enter name :");
                name = Console.ReadLine();
                Console.Write("Enter Salary");
                decimal s;
                decimal.TryParse(Console.ReadLine(), out s);
                Console.Write("Enter hiring date");
                string hire= Console.ReadLine();
              
                Console.Write("Enter Gender");
                Gender result;
                do
                {
                    flag = Enum.TryParse(Console.ReadLine(), true, out result);
                } while (!flag);

                EmpArr[i].gender = result;
                EmpArr[i].name = name;
                EmpArr[i].salary = s;
                EmpArr[i].id = ID;
                EmpArr[i].hiredate = hire;
                i++;
            }
            var sortedEmployees = EmpArr.OrderBy(emp => DateTime.Parse(emp.hiredate)).ToArray();

        }
    }
}