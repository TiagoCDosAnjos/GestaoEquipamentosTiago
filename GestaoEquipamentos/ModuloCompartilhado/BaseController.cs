using GestaoEquipamentos.ModuloEquipamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ModuloCompartilhado
{
    public class BaseController
    {
        public RepositorioEquipamentos _repositorioEquipamentos { get; set; }
        public UserControl UserControl { get; set; }
    }
}
