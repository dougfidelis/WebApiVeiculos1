using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Moto : BaseModel
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}
