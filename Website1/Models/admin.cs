using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Website1.Models
{
    [Table("admins")]
    public class admin

    {
        [Key, Column(Order = 0)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public String name { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        public String email { get; set; }

        [Required]
        public String phone { get; set; }

        [Required]
        public String avatar { get; set; }

        [Required]
        public String password { get; set; }

        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime created_at { get; set; }

        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime updated_at { get; set; }

        [NotMapped]
        [Required]
        public string ConfirmPassword { get; set; }
    }
}