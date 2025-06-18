using System;

namespace _05_StructRefOut_Classwork
{
    public struct FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public FullName( string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString() 
        { 
            return $"{LastName} \t{FirstName}";
        }
    }
    public class Worker
    {
        public FullName WorkerName { get; set; }
        private int age;
        private decimal salary;
        private DateTime hireDate;

        public int Age 
        {
            get {return age;}
            set 
            {
                if (value < 18 || value > 100)
                {
                    throw new ArgumentException("Вік працівника має бути від 18 до 100 років.");
                }                    
                age = value;
            }
        }
        public decimal Salary
        {
            get { return salary; }
            set 
            {
                if (value <=0)
                {
                    throw new ArgumentException("Зарплата має бути додатним числомю");
                }
                salary = value;
            }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Дата прийняття на роботу не може бути в майбутньому");
                }
            }
        }

        public Worker(string lastName, string firstName,  int age, decimal salary, DateTime hireDay)
        {
            WorkerName = new FullName(firstName, lastName);
            Age = age;
            Salary = salary;
            HireDate = hireDay;
        }

        public int GetWorkExperience()
        {
            return DateTime.Now.Year - HireDate.Year;
        }
    }
}
