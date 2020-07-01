using HappyCode.Management.Core.Business;
using System;
using System.Collections.Generic;

namespace HappyCode.Management.Core.Model
{
    public class Professor
    {
        #region Constructor
        public Professor()
        {
            _objBUS = new ProfessorBUS(new DAO.ProfessorDAO());
        }
        #endregion

        #region Attributes
        public int Id_Professor { get; set; }
        public string Tx_Nome { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        public string Tx_CPF { get; set; }
        public string Tx_Sexo { get; set; }
        public string Tx_Rua { get; set; }
        public string Tx_Numero { get; set; }
        public string Tx_Complemento { get; set; }
        public string Tx_Bairro { get; set; }
        public string Tx_CEP { get; set; }
        public string Tx_Municipio { get; set; }
        public string Tx_UF { get; set; }
        public int Nu_FoneDDD { get; set; }
        public int Nu_Fone { get; set; }
        public int Nu_CelDDD { get; set; }
        public int Nu_Cel { get; set; }
        public string Tx_Email { get; set; }
        public string Tx_Responsavel { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public bool St_Ativo { get; set; }

        public string Tx_CPFPont
        {
            get
            {
                long.TryParse(Tx_CPF, out long nuCPF);
                return nuCPF.ToString(@"000\.000\.000\-00");
            }
        }
        public string Tx_Telefone
        {
            get
            {
                if (Nu_FoneDDD > 0 && Nu_Fone > 0)
                {
                    return $"({Nu_FoneDDD}) {Nu_Fone:0000-0000}";
                }
                return "";
            }
        }
        public string Tx_Celular
        {
            get
            {
                if (Nu_CelDDD > 0 && Nu_Cel > 0)
                {
                    return $"({Nu_CelDDD}) {Nu_Cel:00000-0000}";
                }
                return "";
            }
        }

        private ProfessorBUS _objBUS;
        #endregion

        #region Methods
        public List<Professor> ToList()
        {
            return _objBUS.ToList();
        }
        public int Save()
        {
            return Id_Professor > 0 ? _objBUS.Update(this) : _objBUS.Insert(this);
        }
        public int Delete()
        {
            return _objBUS.Delete(this);
        }
        #endregion
    }
}
