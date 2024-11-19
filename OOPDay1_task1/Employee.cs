namespace OOPDay1_task1
{
    internal class Employee
    {

      public  int id;
      public  string name;
      public  string address;
      private string phone;
      private int salary;

      public void setSalary(int s)
        {
            if (s < 6000)
            {
                salary = 6000;
            }
            else
            {
                salary = s;
            }
        }


        public bool phoneNumber(string number)
        {
            if (number[2] == '0')
            {
                return number[0] == '0' && number[1] == '1' & number.Length == 12 && isDigit(number);
            }

            else if (number[2] == '1')
            {
                return number[0] == '0' && number[1] == '1' & number.Length == 12 && isDigit(number);
            }


            else if (number[2] == '2')
            {
                return number[0] == '0' && number[1] == '1' & number.Length == 12 && isDigit(number);
            }

            else if (number[2] == '5')
            {
                return number[0] == '0' && number[1] == '1' & number.Length == 12 && isDigit(number);
            }

            else {
                return false;
            }

        }
       public bool isDigit(string input)
        {

            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;

        }

        public void IncreaseSalary(int increase)
        {
            salary += increase;
            Console.WriteLine(salary);

        }
        public void Display()
        {
            Console.WriteLine($"name is {name} \n id is {id} \n address is {address} \n phone is {phone}\n salary is {salary} ");
        }
        
    }
}
