using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebCoreApp.Data.Enums
{
    public enum PaymentMethod
    {
        [Description(" Pay on Delivery ")]
        CashOnDelivery,

        [Description("Paypal")]
        Paypal
    }
}
