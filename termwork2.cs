using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Termwork2
{
    class Program
    {
        public class Employee
        {
            int Eno;
            string Ename, Job, Dname, Location;
            double Salary;
            public Employee(int Eno, string Ename, string Job, double Salary, string Dname, string Location)
            {
                this.Eno= Eno;
                this.Ename = Ename;
                this.Job = Job;
                this.Salary = Salary;
                this.Dname = Dname;
                this.Location = Location;
            }

            public object this[int index]{
                get{
                    if (index == 0)
                        return Eno;
                    else if (index == 1)
                        return Ename;
                    else if (index == 2)
                        return Job;
                    else if (index == 3)
                        return Salary;
                    else if (index == 4)
                        return Dname;
                    else if (index == 5)
                        return Location;
                    return null;
                }

                set
                {
                    if (index == 0)
                        Eno = (int)value;
                    else if (index == 1)
                        Ename = (string)value;
                    else if (index == 2)
                        Job = (string)value;
                    else if (index == 3)
                        Salary = (double)value;
                    else if (index == 4)
                        Dname = (string)value;
                    else if (index == 5)
                        Location = (string)value;
                }
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee(1001,"Ajay","TeamLead",50000.0,"MCA","Hyderabad");
            Console.WriteLine("Eno: " + emp[0]);
            Console.WriteLine("Ename: " + emp[1]);
            Console.WriteLine("Job: " + emp[2]);
            Console.WriteLine("Salary:" + emp[3]);
            Console.WriteLine("Dname: " + emp[4]);
            Console.WriteLine("Location: " + emp[5]);

            emp[2] = "Manager";
            emp[5] = "Mumbai";

            Console.WriteLine("\n");
            Console.WriteLine("Eno: " + emp[0]);
            Console.WriteLine("Ename: " + emp[1]);
            Console.WriteLine("Job: " + emp[2]);
            Console.WriteLine("Salary:" + emp[3]);
            Console.WriteLine("Dname: " + emp[4]);
            Console.WriteLine("Location: " + emp[5]);
            Console.ReadLine();

        }
    }
}
