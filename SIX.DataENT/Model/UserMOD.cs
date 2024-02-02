using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIX.DataENT.Model
{
    [Table("Usuario")]
    public class UserMOD
    {
        [Key]
        [Column("usuID")]
        public decimal usuID { get; set; }


        [Column("nombre")]
        public string nombre { get; set;}


        [Column("apellido")]
        public string apellido { get; set;}
    }
}
