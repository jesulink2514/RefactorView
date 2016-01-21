using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Web;

namespace RefactorView.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }
    }
}