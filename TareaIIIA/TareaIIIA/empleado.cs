using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaIIIA
{
    public class empleado
    {

        public Int64 Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String sexo { get; set; }
        public String status { get; set; }

        public empleado() { }

        public empleado(Int64 pId, String pNombre, String pApellido, String pSexo, String pStatus)

        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.sexo = pSexo;
            this.status = pStatus;

        }


    }
}