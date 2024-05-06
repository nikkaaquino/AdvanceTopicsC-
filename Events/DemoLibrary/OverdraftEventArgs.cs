using System;

namespace DemoLibrary
{
    public class OverdraftEventArgs : EventArgs
    {
        public decimal AmountOverdrafted { get; private set; }

        public string MoreInfo { get; private set; }

        public bool CancelTransaction { get; set; } = false;

        public OverdraftEventArgs(decimal amountOverdrafted, string moreInfo)
        {
            AmountOverdrafted = amountOverdrafted;
            MoreInfo = moreInfo;
        }
    }
}
