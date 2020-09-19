using System;
using System.Text;
namespace Lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Введ:");
            Student st1 = new Student();

            Console.WriteLine(st1.Name);
            Student.Age();
        }
    }
    class Student
    {
        static int countOfObj = 0;
        public const int countOfSt = 5;
        static public string dateOfBirth = "09012002";
        public readonly int id;
        public string name;
        public string Surname { get; set; }
        public string address { get; set; }
        public int phone { get; set; }
        public string faculty { get; set; }
        public int course { get; set; }
        public int group { get; set; }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }
                name = value;
            }
        }
        private Student(int a)
        {

        }
        public Student()
        {
            string bufName;
            Console.WriteLine("Введите имя:");
            bufName = Console.ReadLine();

        }
        Student(int a, int b)
        {

        }
        public static void Info(int id, int name, int surname, int address, int phone, int faculty, int course, int group)
        {

        }
        public static void Age()
        {
            int year = Convert.ToInt32(dateOfBirth.Substring(4, 4));
            int month = Convert.ToInt32(dateOfBirth.Substring(2, 2));
            int date = Convert.ToInt32(dateOfBirth.Substring(0, 2));
            DateTime bDay = new DateTime(year, month, date);
            DateTime now = DateTime.Today;
            int age = now.Year - bDay.Year;
            if (bDay > now.AddYears(-age))
                age--;
            Console.WriteLine(age);
        }
        class partial
        {

        }
    }
}