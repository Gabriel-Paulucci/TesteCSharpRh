using System;

namespace OOP
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; }
        public string RazaoSocial { get; }

        public PessoaJuridica(string nome, string sobreNome, string cnpj, string razaoSocial) : base(nome, sobreNome)
        {
            if (cnpj is null && cnpj.Length != 18)
            {
                throw new Exception("Cnpj invalido");
            }
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
        }

        public override string ToString()
        {
            return $"RazaoSocial: {RazaoSocial} Cnpj: {Cnpj}";
        }

        public override bool Equals(object obj)
        {
            return obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + Cnpj.GetHashCode() + RazaoSocial.GetHashCode();
        }
    }
}
