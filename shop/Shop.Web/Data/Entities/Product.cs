
namespace Shop.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode =false)]
        public decimal Price { set; get; }

        [Display(Name = "Image")]
        public string ImageURL { set; get; }
        [Display(Name ="Last Sale")]
        public DateTime LastSale { set; get; }

        [Display(Name ="Last Purchase")]
        public DateTime LastPurchase { set; get; }

        [Display(Name ="Is Avialable?")]
        public bool IsAvialable { set; get; }

        [DisplayFormat(DataFormatString ="{0:N2}",ApplyFormatInEditMode =false)]
        public double Stock { set; get; }
    }
}
