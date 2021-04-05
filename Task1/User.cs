using System;
namespace Task1
{
    public class User
    {
        readonly string login;
        readonly string name;
        readonly string surname;
        readonly int age;
        readonly DateTime date;

        public DateTime Date { get { return date; } }

        public User()
        {
            date = DateTime.Now;
        }

        public User( string login, string name, string surname, int age )
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine(
                $"Login: {login}\n" +
                $"Name: {name}" +
                $"Surname: {surname}\n" +
                $"Age: {age}\n" +
                $"Date: {date}\n"
                );
        }
    }
}
