namespace HappyCode.Management.Core.Model
{
    public class AulaPresAval
    {
        public int Id_Aula { get; set; }
        public int Id_Matricula { get; set; }
        public string Tx_Aluno { get; set; }
        public bool St_Presenca { get; set; }
        public decimal Vl_Nota { get; set; }

        public AulaAvaliacao objAvaliacao { get; set; }
        public AulaPresenca objPresenca { get; set; }
    }
}