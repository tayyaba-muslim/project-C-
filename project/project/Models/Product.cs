using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Product
    {
        [Key]
        public int pid { get; set;  }
        [Required]
        public string pname { get; set;  }
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$")]
        public string email { get; set;  }
        [Required]
        public int price { get; set;  }
        [Required]
        public int qty { get; set;  }
    }
}
