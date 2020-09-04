using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebCoreApp.Data.Enums;
using WebCoreApp.Infrastructure.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    [Table("Publishers")]
    public class Publisher : DomainEntity<int>
    {
        public Publisher()
        {

        }

        public Publisher(string name, Status status)
        {
            PublisherName = name;

            Status = status;
        }

        public Publisher(int id, string name, Status status)
        {
            Id = id;
            PublisherName = name;
            Status = status;
        }

        public string PublisherName { get; set; }

        public Status Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
