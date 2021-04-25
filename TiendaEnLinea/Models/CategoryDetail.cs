using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TiendaEnLinea.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }
        
        [Required(ErrorMessage ="Nombre de categoria requerido")]
        [StringLength(100,ErrorMessage ="Minimo de 3 y 5, y maximo 100 caracteres",MinimumLength =3)]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }

    public class ProductDetail
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Nombre del producto requerido")]
        [StringLength(100, ErrorMessage = "Minimo 3 y 5, y maximo 100 caracteres aqui", MinimumLength = 3)]
        public string ProductName { get; set; }

        [Required]
        [Range(1, 50)]
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> IsActive { get; set; }

        public Nullable<int> IsDelete { get; set; }

        public Nullable <System.DateTime> CreatedDate { get; set; }

        public Nullable<System.DateTime> ModifiedDate { get; set; }

        [Required(ErrorMessage ="Descripcion requerida")]
        public Nullable<System.DateTime>Descripcion { get; set; }

        public string ProductImage { get; set; }

        public Nullable<bool> IsFeatured { get; set; }

        [Required]
        [Range(typeof(int),"1","500", ErrorMessage ="Cantidad invalida")]
        public Nullable<int> Quantity { get; set; }

        [Required]
        [Range(typeof(decimal),"1","100",ErrorMessage ="Cantidad invalida")]
        public Nullable<decimal> Price { get; set; }
        public SelectList Categories { get; set; }
    }
}