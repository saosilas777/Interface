using System;
using System.Globalization;

namespace Course.Entities {
    class Contract {

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public Contract(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public override string ToString() {
            return "Number : " + Number +
                "\nDate: " + Date +
                "\nTotal: " + TotalValue.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
