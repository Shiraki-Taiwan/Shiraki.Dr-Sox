using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shiraki.Dr_Sox.Models
{
    public class ShopViewModels
    {
        public OrderDetail Order { get; set; }
        public List<OrderItem> Products { get; set; }

        public ShopViewModels()
        {
            Order = new OrderDetail();
            Products = new List<OrderItem>();
        }
    }

    public class OrderDetail
    {
        [Required]
        [Display(Name = "訂購者姓名")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "聯絡電話")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "行動電話")]
        public string MobileNumber { get; set; }
        [Required]
        [Display(Name = "電子郵件")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "收貨人姓名")]
        public string RecipientName { get; set; }
        [Required]
        [Display(Name = "郵遞區號")]
        public string RecipientAreaCode { get; set; }
        [Required]
        [Display(Name = "縣／市")]
        public string RecipientCity { get; set; }
        [Required]
        [Display(Name = "鄉鎮區市")]
        public string RecipientTown { get; set; }
        [Required]
        [Display(Name = "鄉鎮區市")]
        public string RecipientAddr { get; set; }
        [Display(Name = "備註")]
        public string Memo { get; set; }
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public bool IsNew { get; set; }
        public bool IsHot { get; set; }
    }
}