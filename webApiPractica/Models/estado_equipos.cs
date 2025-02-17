using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace webApiPractica.Models
{
    public class estado_equipos
    {

        [Key]

        public int id_estados_equipo {  get; set; }

        public string descripcion { get; set; }

        public string estado {  get; set; }


    }
}
