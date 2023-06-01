using System.ComponentModel.DataAnnotations;

namespace CuaHangThucPham.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập dòng sản phẩm.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập quốc gia.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập thông tin giới thiệu.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập thông tin liên hệ.")]
        public string ContactInfo { get; set; }

        // Các thuộc tính khác của sản phẩm, ví dụ: giá, hình ảnh, đánh giá, v.v.

        [DataType(DataType.Currency)]
        [Range(0, 9999999, ErrorMessage = "Giá sản phẩm không hợp lệ.")]
        public decimal Price { get; set; }
    }
}
