using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebCoreApp.Data.Enums;
using WebCoreApp.Data.Interfaces;
using WebCoreApp.Infrastructure.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    [Table("Bills")]
    public class Bill:DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Bill() { }
        public Bill(string customerName, string customerAddress, string customerMobile, string customerMessage,
            BillStatus billStatus, PaymentMethod paymentMethod, Status status, Guid? customerId, DateTime dateCreated)
        {
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            DateCreated = dateCreated;
            DateModified = DateTime.Now;
            CustomerId = customerId;
        }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public int? ServiceId { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public int? DistrictId { get; set; }
        [Required]
        public string WardCode { get; set; }
        [Required]
        public int? CODAmount { get; set; }
        [Required]
        public string CustomerMobile { get; set; }
        public string CustomerMessage { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public BillStatus BillStatus { get; set; }
        [DefaultValue(Status.Active)]
        public Status Status { get; set; } = Status.Active;
        public DateTime DateCreated { get ; set ; }
        public DateTime DateModified { get; set ; }
        public Guid? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual AppUser User { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }

    }
}
