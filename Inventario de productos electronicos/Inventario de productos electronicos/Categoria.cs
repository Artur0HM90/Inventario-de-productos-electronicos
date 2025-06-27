using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_de_productos_electronicos.Modelos
{
    public class Categoria
    {
        public string Nombre { get; set; } = string.Empty;

        public override string ToString()
        {
            return Nombre;
        }
    }
}
