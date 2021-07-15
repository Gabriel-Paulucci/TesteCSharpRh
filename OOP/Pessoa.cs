using System;

namespace OOP
{
    public class Pessoa
    {
        private int _idade;

        public string Nome { get; }
        public string SobreNome { get; }
        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Idade não pode ser negativo");
                }

                _idade = value;
            }
        }
        public string NomeInteiro
        {
            get
            {
                return $"{Nome} {SobreNome}";
            }
        }

        public Pessoa(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
        }

        public override string ToString()
        {
            return $"Nome: {NomeInteiro} Idade: {Idade}";
        }

        public override bool Equals(object obj)
        {
            return obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            return NomeInteiro.GetHashCode() + Idade.GetHashCode();
        }
    }
}
