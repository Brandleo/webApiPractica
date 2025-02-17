
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace webApiPractica.Models
{
    public class marcas
    {

        [Key]

        public int id_marca { get; set; }

        public string nombre_marca { get; set; }

        public string estado { get; set; }

    }
}
