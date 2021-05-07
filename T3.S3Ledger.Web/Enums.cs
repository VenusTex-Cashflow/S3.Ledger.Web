﻿namespace T3.S3Ledger.Web
{
    public class Enums
    {
        public enum CustomerType
        {
            None,
            Business,
            Individual
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
            None,
            Cash,
            Cheque,
            Debit,
            Credit
        }

        public enum BusinessType
        {
            None,
            Retail,
            Wholesale,
            Partner
        }

        public enum InvoiceStatus
        {
            None,
            Outstanding,
            PaymentReceived,
            Completed
        }

        public enum ChequeType
        {
            None,
            Cash,
            Account
        }

        public enum AddressType
        {
            None,
            Billing,
            Shipping
        }
    }
}
