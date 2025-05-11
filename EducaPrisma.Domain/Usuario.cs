namespace EducaPrisma.Domain
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; } // Será criptografada em MD5
        public string CPF { get; set; }
        public string TipoUsuario { get; set; } // "Aluno", "Professor" ou "Coordenador"
        public bool Ativo { get; set; }
    }

}