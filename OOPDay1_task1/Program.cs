namespace OOPDay1_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.id = 1;
            employee.name = "khaled";
            employee.setSalary(7000);
            employee.phoneNumber("01128109017");
            employee.IncreaseSalary(300);


            Employee employee2 = new Employee();
            employee2.id = 2;
            employee2.name = "ali";
            employee2.setSalary(20000);
            employee2.phoneNumber("01528109017");


            Employee employee3 = new Employee();
            employee3.id = 3;
            employee3.name = "mohamed";
            employee3.setSalary(5000);
            employee3.phoneNumber("01028109017");
            employee3.IncreaseSalary(1000);


            Employee[] allEmployee = new Employee[3];
            allEmployee[0] = employee;
            allEmployee[1] = employee2;
            allEmployee[2] = employee3;


            for (int i = 0; i < allEmployee.Length; i++)
            {
                allEmployee[i].Display();
            }



        }
    }
}
