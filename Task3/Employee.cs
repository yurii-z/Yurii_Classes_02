using System;
namespace Task3
{
    public class Employee
    {
        readonly string name;
        readonly string surname;
        readonly string positions;
        readonly int experience;
        double tax;

        public string Name { get; set; }
        public string Surname { get; set; }

        public Employee( string name, string surname, string positions, int experience )
        {
            this.name = name;
            this.surname = surname;
            this.positions = positions;
            this.experience = experience;
        }

        public double Salary()
        {
            double? result = null;

            if (positions == "junior")
            {
                result = 500;
            }
            else if (positions == "middle")
            {
                result = 2000;
            }
            else if (positions == "senior")
            {
                result = 4000;
            }
            else
            {
                Console.WriteLine("Error: wrong positions");
            }

            if (experience <= 2)
            {
                result *= 1;
            }
            else if (experience > 2 && experience <= 5)
            {
                result *= 1.5;
            }
            else if (experience > 10)
            {
                result *= 2;
            }
            else
            {
                Console.WriteLine("Error: wrong experience");
            }

            tax = (double)(result * 0.05);

            return (double)result;
        }


        public void Show()
        {
            Console.WriteLine(
                $"Name: {name}\n" +
                $"Surname: {surname}\n" +
                $"Positions: {positions}\n" +
                $"Experience: {experience}\n" +
                $"Tax: {tax}\n"
                );
        }
    }
}
