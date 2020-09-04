using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebCoreApp.Infrastructure.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    [Table("SlideImages")]
    public class SlideImage : DomainEntity<int>
    {
        public int SlideId { get; set; }

        [ForeignKey("SlideId")]
        public virtual Slide Slide { get; set; }

        public string Path { get; set; }

        public string Caption { get; set; }
    }
}
