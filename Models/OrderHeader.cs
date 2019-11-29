using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcShopping.Models
{
    [DisplayName("訂單主文件")]
    [DisplayColumn("DisplayName")]
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("訂購會員")]
        [Required]
        public virtual Member Member { get; set; }

        [DisplayName("收件人")]
        [Required(ErrorMessage = "請輸入收件人姓名")]
        [MaxLength(40, ErrorMessage = "收件人姓名不可超過40字")]
        [Description("訂購人不一定是收件人")]
        public string ContactName { get; set; }

        [DisplayName("聯絡電話")]
        [Required(ErrorMessage = "請輸入您的聯絡電話")]
        [MaxLength(25, ErrorMessage = "電話號碼長度不可超過25字")]
        [DataType(DataType.PhoneNumber)]
        public string ContactPhoneNo { get; set; }

        [DisplayName("寄送地址")]
        [Required(ErrorMessage = "請輸入商品寄送地址")]
        public string ContactAddress { get; set; }

        [DisplayName("訂單金額")]
        [Required]
        [DataType(DataType.Currency)]
        [Description("金額可能受優惠活動等異動價格，因此必須保留購買當下算出的金額")]
        public int TotalPrice { get; set; }

        [DisplayName("訂單備註")]
        [DataType(DataType.MultilineText)]
        public string Memo { get; set; }

        [DisplayName("訂購時間")]
        public DateTime BuyOn { get; set; }

        [NotMapped]
        public string DisplayName
        {
            get { return this.Member.Name + "於" + this.BuyOn + "訂購的商品"; }
        }

        public virtual ICollection<OrderDetail> OrderDetailItems { get; set; }

    }
}