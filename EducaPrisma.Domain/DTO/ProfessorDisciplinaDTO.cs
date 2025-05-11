using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaPrisma.Domain.DTO
{
    public class ProfessorDisciplinaDTO
    {
        public int ProfessorId { get; set; }
        public string ProfessorNome { get; set; } // Adicionado para facilitar exibição
        public int DisciplinaId { get; set; }
        public string DisciplinaNome { get; set; } // Adicionado para facilitar exibição
    }
}
