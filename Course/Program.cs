using System;
using System.Globalization;
using Course.Entities;


namespace Course {
    class Program {
        static void Main(string[] args) {


            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double total = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installment = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, total);


            


            


        }

    }
}
