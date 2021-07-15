namespace SalvarPessoa.Models
{
    public class Pessoa
    {
        public ulong Id { get; set; }
        public virtual long Matricula { get; set; }
        public virtual string Nome { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} Matricula: {Matricula}";
        }
    }
}
