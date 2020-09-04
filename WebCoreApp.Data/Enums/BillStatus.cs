using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebCoreApp.Data.Enums
{
    public enum BillStatus
    {
        [Description(" Unapproved ")]
        New,
        [Description(" Paid ")]
        Paid,
        [Description(" Delivered to carrier ")]
        InDelivery,
        [Description(" Return Order ")]
        Returned,
        [Description(" Order canceled ")]
        Cancelled,
        [Description(" Shipped ")]
        Completed
    }
}
