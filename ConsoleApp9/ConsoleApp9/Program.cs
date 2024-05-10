using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}
public class Program
{
    public static void Main(string[] args)
    {
        List<Person> list = new List<Person>
        {
            new Person{Name="john",Age=28,City="New York"},
            new Person{Name="Jane",Age=22,City="London"},
            new Person{Name="Mike",Age=32,City="New York"},
            new Person{Name="Emily",Age=41,City="Paris"}
        };
        var city = list.Where(person => person.City == "New York");
        Console.WriteLine("Find all the persons who are living in New York:");
        foreach (var person in city)
        {
            Console.WriteLine($"Name: {person.Name},Age: {person.Age},City:{person.City}");
        }
        var older = list.Where(Person => Person.Age > 30);
        Console.WriteLine("Get the names of people older than 30:");
        foreach (var person in older)
        {
            Console.WriteLine($"Name:{person.Name},Age:{person.Age}");
        }
        var sort = list.OrderBy(person => person.Age);
        Console.WriteLine("Sort People by age:");
        foreach(var person in sort)
        {
            Console.WriteLine($"Name: {person.Name},Age: {person.Age},City:{person.City}");
        }
        var oldest = list.OrderByDescending(person => person.Age).First();
        Console.WriteLine("Find the oldest person:");
        Console.WriteLine($"The oldest person is {oldest.Name}, aged {oldest.Age}, living in {oldest.City}");
        var grup = list.GroupBy(person=>person.City);
        Console.WriteLine("Group people by city:");
        foreach (var person in grup)
        {
            Console.WriteLine($"City: {person.Key}");
            foreach (var item in person)
            {
                Console.WriteLine($"Name: {item.Name},Age: {item.Age}");
            }
        }
    }
}
/*namespace ConsoleApp9
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public List<int> ProjectIDs { get; set; }
    }

    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
    }

    public class Project
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>
            {
                new Employee{EmployeeId=1,Name="Chandana",DepartmentID=1,ProjectIDs = new List<int> { 201, 202,204,205 } },
                new Employee{EmployeeId=2,Name="Keerthana",DepartmentID=2,ProjectIDs=new List<int> {202, 203 } },
                new Employee{EmployeeId=3,Name="Amreen",DepartmentID=3,ProjectIDs=new List<int> {203, 204,201,202} },
                new Employee{EmployeeId=4,Name="Shrinika",DepartmentID=4,ProjectIDs=new List<int> {204, 205,201,202 } }
            };

            List<Department> departments = new List<Department>
            {
                new Department{DepartmentID=1,Name="Accounts"},
                new Department{DepartmentID=2,Name="Servicing"},
                new Department{DepartmentID=3,Name="Consulting"},
                new Department{DepartmentID=4,Name="Technical"}
            };

            List<Project> projects = new List<Project>
            {
                new Project { ProjectID=201,Title="Instant labor"},
                new Project { ProjectID=202,Title="Corruption control"},
                new Project{ ProjectID=203,Title="Generation face using text description"},
                new Project { ProjectID=204,Title="Attendance Management System"},
                new Project{ ProjectID=205,Title="Handloom Management System"}
            };

            var employeesInEachDepartment = from emp in list
                                            join dept in departments on emp.DepartmentID equals dept.DepartmentID
                                            select new { Employee = emp, Department = dept };
            Console.WriteLine("List employees in each department:");

            foreach (var group in employeesInEachDepartment.GroupBy(x => x.Department))
            {
                Console.WriteLine($"Department: {group.Key.Name}");

                foreach (var employee in group)
                {
                    Console.WriteLine($"   Employee ID: {employee.Employee.EmployeeId}, Name: {employee.Employee.Name}");
                }
                Console.WriteLine();
            }
            var noprojects = from emp in list
                             join proj in projects on emp.ProjectIDs.FirstOrDefault() equals proj.ProjectID into gj
                             from subproj in gj.DefaultIfEmpty()
                             where subproj == null
                             select emp;
            Console.WriteLine("Find employees without project");
            foreach(var emp in noprojects)
            {
                Console.WriteLine($"Employee ID:{emp.EmployeeId},Name:{emp.Name},Department ID:{emp.DepartmentID}");
            }
            Console.WriteLine();
            var count = from emp in list
                        from projectId in emp.ProjectIDs
                        join proj in projects on projectId equals proj.ProjectID
                        group emp by proj into grp
                        select new { Project = grp.Key, EmployeeCount = grp.Count() };
            Console.WriteLine("Count Employees in each Project:");
            foreach(var item in count)
            {
                Console.WriteLine($"Project: {item.Project.Title},Employee Count:{item.EmployeeCount}");
            }
            var pro= from emp in list
                     from projectId in emp.ProjectIDs
                     join proj in projects on projectId equals proj.ProjectID
                     group emp by proj into grp
                     where grp.Count() > 3
                     select new { Project = grp.Key, EmployeeCount = grp.Count() };
            Console.WriteLine("Find Projects with more than 3 employees:");
            foreach(var item in pro)
            {
                Console.WriteLine($"Project: {item.Project.Title}, Employee Count: {item.EmployeeCount}");
            }
            var total= from emp in list
                       from projectId in emp.ProjectIDs
                       join proj in projects on projectId equals proj.ProjectID
                       group proj by emp.DepartmentID into grp
                       join dept in departments on grp.Key equals dept.DepartmentID
                       select new { Department = dept.Name, ProjectCount = grp.Select(p => p.ProjectID).Distinct().Count() };
            Console.WriteLine("Departments with their total project count:");
            foreach (var item in total)
            {
                Console.WriteLine($"Department: {item.Department}, Project Count: {item.ProjectCount}");
            }
        }
    }
}*/

