namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new worker(),
                new Robot()

            };
            foreach (var worker in workers)
            {
                worker.Work();

            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            }; 
        }

    }
    interface Iworkwer
    {
        void Work();

    }
    interface IEat
    {
        void Eat();

    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : Iworkwer, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class worker : Iworkwer, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : Iworkwer
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}