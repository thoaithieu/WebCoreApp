using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebCoreApp.Infrastructure.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    [Table("AnnouncementBills")]
    public class AnnouncementBill:DomainEntity<int>
    {
        public AnnouncementBill(string annoucementId, bool? hasRead)
        {
            AnnoucementId = annoucementId;
            HasRead = hasRead;
        }
        [Required]
        public string AnnoucementId { get; set; }
        public bool? HasRead { get; set; }
        [ForeignKey("AnnoucementId")]
        public virtual Announcement Announcement { get; set; }
    }
}
