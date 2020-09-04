using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;
using System.Text;
using WebCoreApp.Infrastructure.SharedKernel;

namespace WebCoreApp.Data.Entities
{
    public class BillDetail:DomainEntity<int>
    {
        public BillDetail() { }
        public BillDetail(int id, int billId, int productId, int quantity, decimal price)
        {
            Id = id;
            BillId = billId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }
        public BillDetail(int billId, int productId, int quantity, decimal price)
        {
            BillId = billId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }
        public int BillId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("BillId")]
        public virtual Bill Bill { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
