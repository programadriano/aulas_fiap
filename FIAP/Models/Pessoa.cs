namespace FIAP.Models
{
    public class Pessoa
    {
        public Pessoa(string cabeca, string tromco, string membros)
        {
            Cabeca = cabeca;
            Tromco = tromco;
            Membros = membros;
        }

        public string Cabeca { get; private set; }
        public string Tromco { get; private set; }
        public string Membros { get; private set; }

        public void Andar()
        {

        }

        public void Pular()
        {

        }

        public void Comer()
        {

        }
    }
}
