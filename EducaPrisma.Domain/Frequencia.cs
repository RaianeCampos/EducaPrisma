using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaPrisma.Domain
{
    public class Frequencia
    {
        public int Id { get; set; }
        public int ParticipanteAlunoId { get; set; }
        public string ParticipanteAlunoNome { get; set; }
        public int DisciplinaId { get; set; }
        public string DisciplinaNome { get; set; }
        public bool Presenca { get; set; }
        public DateTime DataFrequencia { get; set; }
    }
}
