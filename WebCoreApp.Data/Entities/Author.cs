using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebCoreApp.Data.Enums;
using WebCoreApp.Infrastructure.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    [Table("Authors")]
    public class Author:DomainEntity<int>
    {
        public Author()
        {

        }
        public Author(string authorName, Status status)
        {
            AuthorName = authorName;
            Status = status;
        }
        public Author(int id, string authorName, Status status)
        {
            Id = id;
            AuthorName = authorName;
            Status = status;
        }
        public string AuthorName { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
