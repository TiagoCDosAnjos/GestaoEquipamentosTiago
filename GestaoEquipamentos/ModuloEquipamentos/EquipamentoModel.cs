using GestaoEquipamentos.ModuloCompartilhado;


namespace GestaoEquipamentos.ModuloEquipamentos
{
    public class EquipamentoModel : BaseModel
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Fabricante { get; set; }
        public DateTime DataUltimaManutencao { get; set; }

        public  override string Validar()
        { 
            string error = string.Empty;

            if (Nome == string.Empty || Nome.Length < 6)
            {
                 error += "Nome Inválido! Deve ter no minimo 6 caracteres";
            }
            return error;
        }
    }
}
