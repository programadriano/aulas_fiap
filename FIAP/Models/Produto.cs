namespace FIAP.Models
{
    public class Produto
    {
        private static List<string> _produtoList = new List<string>();

        public string SalvarProduto(string nomeDoProduto)
        {
            _produtoList.Add(nomeDoProduto);

            return "Produto salvo com sucesso!";
        }

        public string BuscarProdutoPorNome(string nomeDoProduto)
        {
            return _produtoList.FirstOrDefault(x => x == nomeDoProduto, "Produto não encontrado");
        }
    }
}
