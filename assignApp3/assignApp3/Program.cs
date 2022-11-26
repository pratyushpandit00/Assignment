using System;



namespace EmpAssignment

{

    class Employee

    {

        static void Main(string[] args)

        {
            int c = 1;
            while (c == 1)

            {

                Console.WriteLine("Enter Employee Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the gender :");
                string gender = Console.ReadLine();
                Console.WriteLine("Enter DOB");
                DateTime dob = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of dependents you wish to add");
                short nod = short.Parse(Console.ReadLine());

                Employee e = new Employee(name, dob, gender, nod);
                if (nod <= 3)
                { 
                    for (int i = 0; i < nod; i++)
                    {
                        Console.WriteLine($"Enter dependent {i + 1} name");
                        string dname = Console.ReadLine();
                        int n = e.AddDependent(dname);
                        Console.WriteLine($"{n} dependent added");
                    }
                }

                else if (nod > 3)
                {
                   for (int i = 0; i <= 3; i++)
                    {
                        Console.WriteLine($"Enter dependent {i + 1} name");
                        string dname = Console.ReadLine();
                        int n = e.AddDependent(dname);
                        Console.WriteLine($"{n} dependent added");
                    }
                }

                Console.WriteLine($"Employee details\nEmployee Id: {e.employeeId}\nName: {e.employeeName}\nGender: {e.gender}\nDate of birth: {e.dateOfBirth}");

                for (int i = 0; i < e.dependents.Length; i++)

                {

                    if (e.dependents[i] != null)

                    {

                        Console.WriteLine($"Dependent {i + 1}: {e.dependents[i]}");

                    }

                }

                Console.WriteLine("Do you want to update dependents?\n1.Yes\n2.No");
                int ch = int.Parse(Console.ReadLine());
                if (ch == 1)

                {
                    Console.WriteLine("Enter dependent Id");
                    int did = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter new name");
                    string uname = Console.ReadLine();
                    bool ur = e.UpdateDependents(uname, did);

                    if (ur)
                    {
                        Console.WriteLine("Dependent updated");
                        Console.WriteLine($"Employee details\nEmployee Id: {e.employeeId}\nName: {e.employeeName}\nGender: {e.gender}\nDate of birth: {e.dateOfBirth}");
                        for (int i = 0; i < e.dependents.Length; i++)
                        {
                            if (e.dependents[i] != null)
                            {
                                Console.WriteLine($"Dependent {i + 1}: {e.dependents[i]}");
                            }
                        }

                        Console.WriteLine("Do you want to add new employee\n1.Yes\n2.No");
                        int opt = int.Parse(Console.ReadLine());

                        if (opt == 2)
                        {
                            Console.WriteLine("Exiting");
                            c = 0;
                        }
                    }
                    else

                    {
                        Console.WriteLine("Incorrect dependent id");
                    }

                }

                else if (ch == 2)

                {
                    Console.WriteLine("Do you want to add new employee\n1.Yes\n2.No");
                    int opt = int.Parse(Console.ReadLine());
                    if (opt == 2)
                    {

                        Console.WriteLine("Exiting");

                        c = 0;

                    }

                }



            }

        }



        DateTime dateOfBirth;

        string[] dependents;

        int employeeId;
        string employeeName;
        string gender;
        static int nextEmployeeNumber;
        short numberOfDependents;

        int AddDependent(string dependentName)

        {
            int result = 0;
            for (int i = 0; i < numberOfDependents; i++)
            {
               if (dependents[i] == null)
                {
                    dependents[i] = dependentName;
                    result = 1;
                    break;
                }
            }
            return result;
        }

        static Employee()

        {

            nextEmployeeNumber = 1001;

        }

        Employee()

        {

            this.employeeId = nextEmployeeNumber;
            this.dependents = new string[3];
            nextEmployeeNumber++;

        }

        Employee(string employeeName, DateTime dateOfBirth, string gender) : this()

        {



            this.employeeName = employeeName;

            this.dateOfBirth = dateOfBirth;

            this.gender = gender;

        }

        public Employee(string employeeName, DateTime dateOfBirth, string gender, short numberOfDependents) : this()

        {

            this.employeeName = employeeName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;

            if (numberOfDependents < 0)
            {
                this.numberOfDependents = 0;
            }
            else if (numberOfDependents > 3)
            {
                this.numberOfDependents = 3;
            }
            else
            {
                this.numberOfDependents = numberOfDependents;
            }
        }

        bool UpdateDependents(string dependentName, int dependentId)

        {

            bool result = false;

            if (0 <= dependentId - 1 && dependentId - 1 <= numberOfDependents)

            {
                dependents[dependentId - 1] = dependentName;
                result = true;
            }

            return result;

        }

    }

}