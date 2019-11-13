using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcShopping.Models
{
    [DisplayName("訂單明細")]
    [DisplayColumn("Name")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("訂單主文件")]
        [Required]
        public OrderHeader OrderHeader { get; set; }

        [DisplayName("訂購商品")]
        [Required]
        public Product Product { get; set; }

        [DisplayName("商品售價")]
        [Required(ErrorMessage = "請輸入商品售價")]
        [Range(99, 10000, ErrorMessage = "商品售價須介於99~10,000之間")]
        [Description("由於商品價格經常異動，因此要保留購買當下價格")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [DisplayName("選購數量")]
        [Required]
        public int Amount{ get; set; }

    }
}