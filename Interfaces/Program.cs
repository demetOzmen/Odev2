//InterfacesIntro();

using Interfaces;
class Program
{
    static void Main(string[] args)
    {
        ICustomerDal[] customerDals = new ICustomerDal[2]
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal()
        };
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }

    }

    static void InterfacesIntro()
    {
        static void Main(string[] args, CustomerManager customerManager)

        {
            CustomerManager customerManagerr = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Demet", LastName = "Özmen", Address = "İstanbul" });
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Demet",
                LastName = "Özmen",
                Address = "İstanbul"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Ayşegül",
                LastName = "Özmen",
                Departmant = "Computer Sciences"
            };
            manager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }

    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
