using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using HappyCode.Management.Core.DAO;
using HappyCode.Management.Core.Model;

namespace HappyCode.Management.Core.Business
{
    public class AulaPresencaBUS
    {
        #region Constructor
        public AulaPresencaBUS (AulaPresencaDAO IDAO)
        {
            _IDAO = IDAO;
        }
        #endregion

        #region Attributes
        private AulaPresencaDAO _IDAO;
        #endregion

        #region Methods
        public List<AulaPresenca> ToList()
        {
            return _IDAO.ToList();
        }
        public List<AulaPresenca> ToList(int Id_Aula)
        {
            return _IDAO.ToList($" WHERE Id_Aula={Id_Aula};");
        }
        internal List<AulaPresenca> ToListTurma(int Id_Turma)
        {
            return _IDAO.ToList($" WHERE Id_Aula IN (SELECT Id_Aula FROM Aula WHERE Id_Turma={Id_Turma});");
        }
        public int Insert(AulaPresenca obj)
        {
            return _IDAO.Insert(obj);
        }
        public int Update(AulaPresenca obj)
        {
            return _IDAO.Update(obj);
        }
        public int Delete(AulaPresenca obj)
        {
            return _IDAO.Delete(obj);
        }
        #endregion
    }
}
