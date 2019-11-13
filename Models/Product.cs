using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcShopping.Models
{
    [DisplayName("商品信息")]
    [DisplayColumn("Name")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("商品類別")]
        [Required]
        public ProductCategory ProductCategory { get; set; }

        [DisplayName("商品名稱")]
        [Required(ErrorMessage = "請輸入商品名稱")]
        [MaxLength(60, ErrorMessage = "商品名稱不可超過60字")]
        public string Name { get; set; }

        [DisplayName("商品簡介")]
        [Required(ErrorMessage = "請輸入商品簡介")]
        [MaxLength(250, ErrorMessage = "商品簡介請勿超過250字")]
        public string Description { get; set; }

        [DisplayName("商品顏色")]
        [Required(ErrorMessage = "請選擇商品顏色")]
        public string Color { get; set; }

        [DisplayName("商品售價")]
        [Required(ErrorMessage = "請輸入商品售價")]
        [Range(99, 10000, ErrorMessage = "商品售價須介於99~10,000之間")]
        public int Price { get; set; }

        [DisplayName("上架時間")]
        [Description("如果不設置上架時間，代表此商品永不上架")]
        public DateTime? PublishOn { get; set; }

    }
}