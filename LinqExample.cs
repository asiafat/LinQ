using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Employee
        {
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public DateTime DOB { get; set; }
            public DateTime DOJ { get; set; }
            public string City { get; set; }
        }
        class Program
        {
            public static List<Employee> empList = new List<Employee>
{

 new Employee() {EmployeeID = 1001,FirstName = "Mahesh",LastName = "Bhatia",Title = "Manager",DOB = DateTime.Parse("02/01/1984"),DOJ = DateTime.Parse("09/08/2011"),City = "Mumbai"},
new Employee() {EmployeeID = 1002,FirstName = "Aakash",LastName = "Kumar",Title = "AsstManager",DOB = DateTime.Parse("20/08/1984"),DOJ = DateTime.Parse("7/7/2012"),City = "Mumbai"},
new Employee() {EmployeeID = 1003,FirstName = "Zara",LastName = "Mehreen",Title = "Consultant",DOB = DateTime.Parse("14/11/1987"),DOJ = DateTime.Parse("12/4/2015"),City = "Pune"},
new Employee() {EmployeeID = 1004,FirstName = "Sohail",LastName = "Shaik",Title = "SE",DOB = DateTime.Parse("6/3/1990"),DOJ = DateTime.Parse("2/2/2016"),City = "Pune"},
new Employee() {EmployeeID = 1005,FirstName = "Husain",LastName = "Basha",Title = "SE",DOB = DateTime.Parse("3/8/1991"),DOJ = DateTime.Parse("2/2/2016"),City = "Mumbai"},

};
            static void Main(string[] args)
            {

              Console.ReadKey();

            }
            //Method to Display All details of the EmployeeList
            public static void DisplayAll()
            {
                var displayallwmployees = (from Emp in empList select Emp);

                foreach (var e in displayallwmployees)
                {
                    Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
                }
            }
            //Method to Display All details of the EmployeeList whose Title is AsstManager
            public static void TitleAsstManager()
            {
                var DisplayTitleAsstManagerList = from e in empList where e.Title == "AsstManager" select e;
                foreach (var e in DisplayTitleAsstManagerList)
                {
                    Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
                }
            }

            //Method to Display All details of the EmployeeList whose Doj is before 6/1/2015
            public static void EmployeeDojBeforeDate()
            {
                var EmployeeDojBeforeDateList = from e in empList where e.DOJ < DateTime.Parse("6/1/2015") select e;
                foreach (var e in EmployeeDojBeforeDateList)
                {
                    Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);
                }
            }

            //Method to Display the Count of the EmployeeList 
            public static void EmployeeListCount()
            {
                var EmployeeListCount = from e in empList select e;
                Console.WriteLine("Total no of Employees in EmpList" + EmployeeListCount.Count());
            }

            //Method to Display the Count of the EmployeeList whose Title is not equal to Associate
            public static void EmployeeTitleNotAssociate()
            {
            var EmployeeTitleNotAssociateCount = from e in empList where e.Title != "Associate" select e;
            Console.WriteLine("Total no of Employees Whose Title is not Associate are : " + EmployeeTitleNotAssociateCount.Count());
            }
            
        }
    }