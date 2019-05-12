using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin super = new Admin();

            //string input = Console.ReadLine();
            Console.WriteLine("Login with Admin or Employee Account?");
            string account = Console.ReadLine();
            Console.Clear();
            if (account.ToLower() == "admin")
            {
                Console.WriteLine($"{"User"}:{"Admin"}");
                Console.Write($"Type Admin Password:");
                string adminpassword = Console.ReadLine();
                Console.Clear();

                Person ad = new Person();
                ad.Login("Admin", "User", adminpassword);
                if (ad.reply == 1)
                {
                     Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Login Succesful");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nAdd Employee (A)");
                    Console.WriteLine("Delete Employee (D)");
                    Console.WriteLine("Check Device (C)");
                    Console.WriteLine("Update(U)");
                    // Console.ReadLine();
                    string func = Console.ReadLine();
                    switch (func)
                    {
                        case "a":
                            Console.Clear();

                            Console.WriteLine("Write Employee details to add..");

                            Console.Write("First Name:");
                            string fname = Console.ReadLine();

                            Console.Write("Last Name:");
                            string sname = Console.ReadLine();

                            Console.Write("Password:");
                            string pword = Console.ReadLine();

                               Console.Clear();
                            if ((fname != "Admin" && fname != "") && (sname != "User" && sname != ""))
                            {


                                super.Add(fname, sname, pword);
                                if (super.Reply == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"Employee {fname} { sname} Added succesfully");
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;

                                    Console.WriteLine("Error Adding Employee (Employee might already exist )");
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Error adding employee");
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            break;
                        case "d":
                            Console.Clear();

                            Console.WriteLine("Write Employee details to delete..");

                            Console.Write("First Name:");
                            string finame = Console.ReadLine();

                            Console.Write("Last Name:");
                            string suname = Console.ReadLine();

                            Console.Clear();
                            if (finame != "Admin" && suname != "User")
                            {


                                super.Delete(finame, suname);
                                if (super.Reply == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"Employee {finame} {suname} deleted successful");
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Error deleting employee");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Cannot delete Admin User");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nLogin Insuccesful", Console.ForegroundColor);
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
               

                //admin.Add(firstname, lastname, password);
                // admin.Delete(firstname, lastname);
            }
            else if(account.ToLower() ==  "employee")
            {
                Console.Write("First Name:");
                string fname = Console.ReadLine();

                Console.Write("Last Name:");
                string sname = Console.ReadLine();

                Console.Write("Password:");
                string pword = Console.ReadLine();
                if (fname != "Admin" && sname != "User")
                {
                    Console.Clear();
                    Person person = new Person();
                    person.Login(fname, sname, pword);



                    if (person.reply == 1)
                    {
                        //Admin super = new Admin();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Login Succesful");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nGet Information (A)");
                        Console.WriteLine("Contact (D)");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nLogin Insuccesful", Console.ForegroundColor);
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cannot login as Admin! Go back and select Admin Account if you wish to login as Admin ");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
           






            // person.Login(firstname, lastname,password);

            Console.ReadLine();
        }
    }
}
