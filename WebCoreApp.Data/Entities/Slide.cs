using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebCoreApp.Data.Enums;
using WebCoreApp.Infrastructure.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    [Table("Slides")]
    public class Slide : DomainEntity<int>
    {
        public Slide(int id, string image, Status status)
        {
            Id = id;
            Image = image;
            Status = status;
        }

        public Slide(string image, Status status)
        {
            Image = image;
            Status = status;
        }

        [Required]
        public string Image { set; get; }

        public Status Status { set; get; }

    }
}
