class Exercise
{
    void ShowEmployee(int employeeNumber, string fullName, string gender, double hourlySalary=500.00D)
    {
        System.Console.WriteLine("Employee Record");
        System.Console.WriteLine("-----------------------------");

        System.Console.Write("Employee #:    ");
        System.Console.WriteLine(employeeNumber);
        System.Console.Write("Full Name:     ");
        System.Console.WriteLine(fullName);
        System.Console.Write("Gender:        ");
        System.Console.WriteLine(gender);
        System.Console.Write("Hourly Salary: ");
        System.Console.WriteLine(hourlySalary);
    }

    static int Main()
    {
        Exercise exo = new Exercise();
        exo.ShowEmployee(572948, "Sompong Jaidee", "M", 450.00D);
        exo.ShowEmployee(572948, "Somchai Jaided", "M");
        exo.ShowEmployee(572948, "Sommai Jaisoo");
        System.Console.ReadKey();
        return 0;
    }
}