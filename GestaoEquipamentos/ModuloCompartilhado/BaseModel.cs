using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ModuloCompartilhado
{
    public abstract class BaseModel
    {
        public  int Indice { get; set; }
        public abstract string Validar();

        protected BaseModel() 
        {
            Indice = -1;
        }

    }
}
