namespace GestaoEquipamentos.ModuloCompartilhado
{
    public abstract class BaseModel
    {
        public int Indice { get; set; }
        public abstract string Validar();

        protected BaseModel()
        {
            Indice = -1;
        }
    }
}
