namespace FIAP.Models
{
    public class Produto
    {
        private static List<string> _produtoLista = new List<string>();
        public string Nome { get; set; }

        public Produto(string nome)
        {
            Nome = nome;
            ValidateEntity();
            SalvarProduto();
        }

        public string SalvarProduto()
        {
            _produtoLista.Add(Nome);
            return $"Produto {Nome} salvo com sucesso!";
        }

        public string BuscarProdutoPorNome(string nomeDoProduto)
        {
            return _produtoLista.FirstOrDefault(x => x == nomeDoProduto, "Produto não encontrado");
        }

        public void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O nome não pode estar vazio!");
            AssertionConcern.AssertArgumentLength(Nome, 30, $"O nome não pode ser maior que 30 caracteres!");
        }
    }
}
