using System;

namespace Task2
{
    //Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс Converter.
    //В теле класса создать пользовательский конструктор,
    //который принимает три вещественных аргумента,
    //и инициализирует поля соответствующие курсу 3-х основных валют,
    //по отношению к гривне – public Converter( double usd, double eur, double rub ).
    //Написать программу,
    //которая будет выполнять конвертацию из гривны в одну из указанных валют,
    //также программа должна производить конвертацию из указанных валют в гривну.

    class Program
    {
        static void Main( string[] args )
        {
            Converter converter = new Converter();

            converter.ConvertToUAH(100, "USD");
            converter.ConvertToUAH(100, "EUR");
            converter.ConvertToUAH(100, "qwerty");

            converter.ConvertFromUAH(28, "USD");

        }
    }
}
