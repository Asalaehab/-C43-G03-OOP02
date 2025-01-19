using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    enum Gender
    {
        M,F
    }
    [Flags]
    enum SecurityPrivialge:byte
    {
        None=0, 
        guest=1,
        developer=2,
        secretary=4,
        DBA=8
        //00001111
    }
    internal class Employee
    {
        #region Attributes
        private int id;
        private int salary;
        private string name;

        #endregion

        #region Propeties
        public int Id
        {
            get { return id; }
            set
            {
                if (id > 0)
                    id = value;
                else
                    Console.WriteLine("Invalid Id");
            }
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    Console.WriteLine("Invalid Name");
            }
        }


        public int Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    Console.WriteLine("Invalid Salary");
            }
        }

        public Gender Gender { get; set; }
        public SecurityPrivialge SecurityPrivialge { get; set; }
        public HireDate HireDate { get; set; } 
        #endregion


        #region Constructor

        public Employee()
        {
            HireDate = new HireDate();
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $" ID : {Id} Name : {Name} Salary : {Salary:c} Gender {Gender} with privialage {SecurityPrivialge} HireDate {HireDate}";
        }

        public static Employee[] CreateEmployee(int size)
        {
            if (size > 0)
            {
                Employee[] employees = new Employee[size];

                for (int i = 0; i < size; i++)
                {
                    employees[i] = new Employee();
                }
                return employees;
            }
            else
                throw new ArgumentOutOfRangeException();
        }


        public static void InsertEmployees(Employee[] employees)
        {
            bool flag;
            int day, month, year;
            Console.WriteLine("Employees Data : ");
            Console.WriteLine("-----------------");
            for (int i=0;i<employees.Length;i++)
            {
                Console.WriteLine($"Enter Data of Employee No.{i + 1}");
                Console.WriteLine("***********************************");
                do
                {
                    Console.Write("Enter ID : ");
                    flag=int.TryParse(Console.ReadLine(), out employees[i].id);

                } while (!flag);
                do
                {
                    Console.Write("Enter name");
                    employees[i].name = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(employees[i].name));
                Gender gender;
                do
                {
                    Console.WriteLine("Enter M/m for male F for Femal");
                    flag=Enum.TryParse(Console.ReadLine(),true, out gender);
                } while (! flag);
                employees[i].Gender = gender;
                int sp;
                do
                {
                    Console.Write("Enter Security ");
                    flag = int.TryParse(Console.ReadLine(), out sp);
                }while (!flag);

                employees[i].SecurityPrivialge = (SecurityPrivialge)sp;
                Console.WriteLine("Enter Hire Date");

                do
                {
                    Console.Write("Enter Day : ");
                    flag = int.TryParse(Console.ReadLine(), out day);

                }while(!flag);

                do
                {
                    Console.Write("Enter month : ");
                    flag = int.TryParse(Console.ReadLine(), out month);

                } while (!flag);


                do
                {
                    Console.Write("Enter year : ");
                    flag = int.TryParse(Console.ReadLine(), out year);

                } while (!flag);

                employees[i].HireDate.Day = day;
                employees[i].HireDate.Month = month;
                employees[i].HireDate.Year = year;
            }
        }

        public static void SortEmployee(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                for(int j = 0;j<employees.Length;j++)
                {
                    if (employees[i].HireDate.Year > employees[i].HireDate.Year)
                        (employees[i], employees[j]) = (employees[j], employees[i]);
                    else if (employees[i].HireDate.Year == employees[i].HireDate.Year)
                    {
                        if(employees[i].HireDate.Month > employees[i].HireDate.Month)
                        (employees[i], employees[j]) = (employees[j], employees[i]);
                        else if (employees[i].HireDate.Month == employees[i].HireDate.Month)
                        {
                            (employees[i], employees[j]) = (employees[j], employees[i]);

                        }
                    }
            }
        }
        #endregion


    }
}
