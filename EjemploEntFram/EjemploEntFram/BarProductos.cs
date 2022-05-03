using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEntFram
{
    internal class BarProductos
    {
        public int idProducto { get; set; }
        public string nomProd { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<int> estado { get; set; }
    }
}
