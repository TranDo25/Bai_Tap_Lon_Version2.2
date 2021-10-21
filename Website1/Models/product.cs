using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Website1.Models
{
    public class product
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string pro_name { get; set; }

        [Required]
        public int pro_category_id { get; set; }

        [Required]
        public int pro_price { get; set; }

        [Required]
        public int pro_author_id { get; set; }

        [Required]
        public int discount { get; set; }

        [Required]
        public int final_price { get; set; }

        [Required]
        public int pro_quantity { get; set; }

        [Required]
        public String pro_description { get; set; }

        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime created_at { get; set; }

        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime updated_at { get; set; }

        [Required]
        public int size_S { get; set; }

        [Required]
        public int size_M { get; set; }

        [Required]
        public int size_L { get; set; }
    }
}
