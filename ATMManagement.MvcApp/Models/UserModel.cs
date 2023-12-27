using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATMManagement.MvcApp.Models
{
    [Table("Tbl_Atm")]
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string? CardNumber { get; set; }
        public int Pin { get; set; }
        public int? Balance { get; set; }
    }
}
