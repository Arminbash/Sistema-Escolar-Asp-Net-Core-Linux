using System.ComponentModel.DataAnnotations;

namespace Project.Dto
{
    public class UserDto
    {
        [Key]
        public  int Id { get; set; }
        [Required(ErrorMessage = "Debe ingresar un usuario")]
        [MaxLength(100)]
        public  string UserName { get; set; }
        [Required(ErrorMessage = "Debe ingresar una contrasena")]
        [MaxLength(100)]
        public  string Password { get; set; }
        //public byte[]   Salt { get; set; }
        //public byte[] Password { get; set; }
        public bool Status { get; set; }
    }
}