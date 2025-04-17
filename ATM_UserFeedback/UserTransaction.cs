using System;

namespace ATM_UserFeedback
{
    internal class UserTransaction
    {
        internal TransactionType TransactionType { get; set; }
        internal DateTime TimeStamp { get; set; }
        internal double Amount { get; set; }
    }
}
