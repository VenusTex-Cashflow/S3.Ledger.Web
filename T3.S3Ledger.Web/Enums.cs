namespace T3.S3Ledger.Web
{
    public class Enums
    {
        public enum CustomerType
        {
            Select,
            BillToBill,
            Normal
        }

        public enum PaymentType
        {
            Select,
            BillToBill,
            Normal
        }

        public enum Role
        {
            SystemAdmin,
            OrgAdmin,
            Manager,
            User
        }

        public enum PayMode
        {
            Select,
            Cash,
            Cheque,
            Debit,
            Credit
        }

        public enum BusinessType
        {
            Select,
            Retail,
            Wholesale,
            Partner
        }

        public enum InvoiceStatus
        {
            Select,
            Outstanding,
            PaymentReceived,
            Completed
        }

        public enum ChequeType
        {
            Select,
            Cash,
            Account
        }

        public enum AddressType
        {
            Select,
            Billing,
            Shipping
        }

        public enum TransactionType
        {
            Cash,
            Bill
        }
    }
}
