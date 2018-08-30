using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCPartCrawler.Entity
{
    [Table("price")]
    class Price<T>
    {
        public int Id { get; set; }
        public string MerchantName { get; set; }
        public string MerchantLinkReference { get; set; }
        public float BasePrice { get; set; }
        public float ShippingFee { get; set; }
        public float Promo { get; set; }
        public bool IsAvailable { get; set; }

        public int PartId { get; set; }
    
        [ForeignKey("PartId")]
        [NotMapped]
        public T Part { get; set; }
    }
}
