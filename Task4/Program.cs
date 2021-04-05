using System;

namespace Task4
{
    //Создать класс Invoice.
    //В теле класса создать три поля int account, string customer, string provider,
    //которые должны быть проинициализированы один раз( при создании экземпляра данного класса)
    //без возможности их дальнейшего изменения.
    //В теле класса создать два закрытых поля string article, int quantity
    //Создать метод расчета стоимости заказа с НДС и без НДС.
    //Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

    class Program
    {
        static void Main( string[] args )
        {
            Invoice invoice = new Invoice(100500, "mr. White", "Pro");

            invoice.SumWithOrWithoutVAT();
        }
    }
}
