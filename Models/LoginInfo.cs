
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EYPractice.Model{
    public class LoginInfo{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get;set;}
        public string account {get; set;}
        public string password {get; set;}
    }
}