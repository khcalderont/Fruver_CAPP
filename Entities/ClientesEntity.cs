using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClientesEntity
    {
        public int id_cliente { get; set; }
        public string tipo_documento { get; set; }
        public string numero_documento { get; set; }
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segudo_apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
    }
}
