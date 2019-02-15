using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAO.Models
{
    [Table("Permisos")]
    public class Permiso
    {
        public int Id { get; set; }
        [Required]
        public int RolId { get; set; }
        [Required, MaxLength(30)]
        public string Nombre { get; set; }
        [Required, MaxLength(200)]
        public string Descripcion { get; set; }
    }
}