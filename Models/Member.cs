using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcShopping.Models
{
    [DisplayName("會員信息")]
    [DisplayColumn("Name")]

    public class Member
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("會員帳號")]
        [Required(ErrorMessage = "請輸入Email地址")]
        [MaxLength(100, ErrorMessage = "請勿超過100字")]
        [Description("我們直接以email當成會員帳號")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("會員密碼")]
        [Required(ErrorMessage = "請輸入密碼")]
        [MaxLength(40, ErrorMessage = "密碼請勿超過40字")]
        [Description("密碼將以SHA1進行雜湊計算，運算後的HEX表示法字符不超過40個字符")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("姓名")]
        [Required(ErrorMessage = "請輸入中文姓名")]
        [MaxLength(10, ErrorMessage = "姓名請勿超過10個字")]
        [Description("暫不考慮外國人用英文註冊的情況")]
        public string Name { get; set; }

        [DisplayName("暱稱")]
        [Required(ErrorMessage = "請輸入暱稱")]
        [MaxLength(10, ErrorMessage = "暱稱請勿超過10字")]
        public string Nickname { get; set; }

        [DisplayName("會員註冊時間")]
        public DateTime RegisterOn { get; set; }

        [DisplayName("會員啟用認證碼")]
        [MaxLength(36)]
        [Description("當AuthCode等於null代表此會員已通過Email有效性驗證")]
        public string AuthCode { get; set; }

        public virtual ICollection<OrderHeader> Orders { get; set; }

    }
}