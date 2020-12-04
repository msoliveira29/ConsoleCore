using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : IJogador
    {
        private readonly string _nome;

        public Jogador1(string nome = "Marcelo")
        {
            _nome = nome;
        }

        public string Chuta()
        {
            return $"{_nome} está chutando.";
        }

        public string Corre()
        {
            return $"{_nome} está correndo.";
        }

        public string Passe()
        {
            return $"{_nome} está passando.";
        }
    }
}