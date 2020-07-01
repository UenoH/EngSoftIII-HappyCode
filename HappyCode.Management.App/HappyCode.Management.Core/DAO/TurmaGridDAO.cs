using HappyCode.Management.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyCode.Management.Core.DAO
{
    public class TurmaGridDAO
    {
        private readonly string _SQLList = @"SELECT t.Id_Turma
                                          ,COALESCE(c.Tx_Nome, 'Não Identificado') as Tx_Curso
                                          ,COALESCE(p.Tx_Nome, 'Não Identificado') as Tx_Professor
                                          ,Dt_Inicio
                                          ,Dt_Termino
                                          ,St_Concluido
                                    FROM Turma t
                                    LEFT JOIN Curso c ON (t.Id_Curso=c.Id_Curso)
                                    LEFT JOIN Professor p on (t.Id_Professor=p.Id_Professor)";

        public List<TurmaGrid> ToList()
        {
            List<TurmaGrid> LstTurmas = new List<TurmaGrid>();
            using (SQLServer DBContext = new SQLServer())
            {
                System.Data.SqlClient.SqlDataReader Reader = DBContext.CommandReader(_SQLList);
                while (Reader.Read())
                {
                    LstTurmas.Add(new TurmaGrid()
                    {
                        Id_Turma = int.Parse(Reader["Id_Turma"].ToString()),
                        Tx_Curso = Reader["Tx_Curso"].ToString(),
                        Tx_Professor = Reader["Tx_Professor"].ToString(),
                        Dt_Inicio = DateTime.Parse(Reader["Dt_Inicio"].ToString()),
                        Dt_Termino = DateTime.Parse(Reader["Dt_Termino"].ToString()),
                        St_Concluido = bool.Parse(Reader["St_Concluido"].ToString())
                    });
                }
                if(LstTurmas.Count > 0)
                {
                    var LstAulas = new Aula().ToList();
                    foreach(var item in LstTurmas)
                    {
                        var Aulas = LstAulas.Where(x => x.Id_Turma == item.Id_Turma).ToList();
                        var Avaliacoes = Aulas.Where(x => x.St_Avaliacao).ToList();
                        item.Tx_Aulas = $"{(Aulas.Where(x=>x.St_Concluida).Count())}/{Aulas.Count}";
                        item.Tx_Avaliacoes = $"{(Avaliacoes.Where(x => x.St_Concluida).Count())}/{Avaliacoes.Count}";
                    }
                }
            }
            return LstTurmas;
        }
    }
}
