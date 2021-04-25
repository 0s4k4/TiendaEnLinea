using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TiendaEnLinea.Models
{
    public class Shopping
    {

        public int ShippingDetailId { get; set; }
        [Required]
        public Nullable<int> MemberId { get; set; }

        [Required] 
        public string Adress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string ZipCode { get; set; }
        
        public Nullable<int>OrderId { get; set; }
        public Nullable<decimal>AmoutPaid { get; set; }
        [Required]
        public string PaymentType { get; set; }

    }
}