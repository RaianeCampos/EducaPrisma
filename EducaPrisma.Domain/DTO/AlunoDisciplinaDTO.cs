using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaPrisma.Domain.DTO
{
    public class AlunoDisciplinaDTO
    {
        public int AlunoId { get; set; }
        public string AlunoNome { get; set; } // Adicionado para facilitar exibição
        public int DisciplinaId { get; set; }
        public string DisciplinaNome { get; set; } // Adicionado para facilitar exibição
        public bool Ativo { get; set; } // Status do aluno na disciplina
    }
}
