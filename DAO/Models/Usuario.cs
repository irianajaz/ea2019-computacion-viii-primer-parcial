using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAO.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int Id { get; set; }

        [Required, MaxLength(12)]
        public string Nombre { get; set; }

        [Required, MaxLength(300)]
        public string Contraseña { get; set; }
        
        [Required, MaxLength(200)]
        public string CorreoElectronico { get; set; }

        [MaxLength(30)]
        public string Telefono { get; set; }

        [Required, MaxLength(50)]
        public string Nombres { get; set; }

        [Required, MaxLength(50)]
        public string Apellidos { get; set; }

        [Required]
        public int RolId { get; set; }

        // utilizado por EFCore
        public Rol Rol { get; set; }
    }
}