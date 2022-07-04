using parquimetro.Entities.Enums;
using System.Text;
using System.Globalization;

namespace parquimetro.Entities
{
    class Payment
    {
        public PaymentCategory PaymentType { get; set; }
        public int OperationNumber { get; set; }
        public double Amount { get; set; }

        public Payment()
        {
        }

        public Payment(PaymentCategory paymentType, int operationNumber, double amount)
        {
            PaymentType = paymentType;
            OperationNumber = operationNumber;
            Amount = amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Operation Number: " + OperationNumber + "    Payment type: " + PaymentType + "   Amount: $" + Amount.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
