using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebCoreApp.Data.Enums;
using WebCoreApp.Data.Interfaces;
using WebCoreApp.Infrastructure.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    [Table("Annoucements")]
    public class Announcement : DomainEntity<string>, ISwitchable, IDateTracking
    {
        public Announcement()
        {
            AnnouncementBills = new List<AnnouncementBill>();
        }
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        [ForeignKey("BillId")]
        public virtual Bill Bill { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get ; set ; }
        public virtual ICollection<AnnouncementBill> AnnouncementBills { get; set; }
    }
}
