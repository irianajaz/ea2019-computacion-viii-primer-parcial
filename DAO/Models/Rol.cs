using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAO.Models
{
    [Table("Roles")]
    public class Rol
    {
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Nombre { get; set; }

        [Required, MaxLength(200)]
        public string Descripcion { get; set; }
        
        [Required]
        public int Nivel { get; set; }

        // utilizado por EFCore
        public List<Permiso> Permisos { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}