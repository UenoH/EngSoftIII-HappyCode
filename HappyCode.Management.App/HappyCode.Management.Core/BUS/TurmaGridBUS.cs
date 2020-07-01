using HappyCode.Management.Core.DAO;
using HappyCode.Management.Core.Model;
using System.Collections.Generic;

namespace HappyCode.Management.Core.BUS
{
    public class TurmaGridBUS
    {
        public TurmaGridBUS(TurmaGridDAO IDAO)
        {
            _IDAO = IDAO;
        }

        private TurmaGridDAO _IDAO;

        public List<TurmaGrid> ToList()
        {
            return _IDAO.ToList();
        }
    }
}
