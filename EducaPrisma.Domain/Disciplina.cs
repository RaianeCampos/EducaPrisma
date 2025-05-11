using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaPrisma.Domain
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string NomeDisciplina { get; set; }
        public int ParticipanteMinistranteId { get; set; } // ID do professor
        public List<int> ParticipantesAlunoIds { get; set; } // Lista de IDs dos alunos
        public bool Ativo { get; set; }
    }
}
