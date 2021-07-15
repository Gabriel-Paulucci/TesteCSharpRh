using System;

namespace OOP
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; }

        public PessoaFisica(string nome, string sobreNome, string cpf) : base(nome, sobreNome)
        {
            if (cpf is null && cpf.Length != 11)
            {
                throw new Exception("Cpf invlido");
            }
            Cpf = cpf;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Cpf: {Cpf}";
        }

        public override bool Equals(object obj)
        {
            return obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + Cpf.GetHashCode();
        }
    }
}
