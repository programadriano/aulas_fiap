using System.Net.NetworkInformation;

namespace FIAP.Models
{
    public class Produto
    {
        public static List<string> produtoLista = new List<string>();
        public string Nome { get; set; }

        public Produto(string nome)
        {
            Nome = nome;
            ValidateEntity();
            SalvarProduto();
        }

        public string SalvarProduto()
        {
            produtoLista.Add(Nome);
            return $"Produto {Nome} salvo com sucesso!";
        }

        public string BuscarProdutoPorNome(string nomeDoProduto)
        {
            return produtoLista.FirstOrDefault(x => x == nomeDoProduto, "Produto não encontrado");
        }

        public void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O nome não pode estar vazio!");
            AssertionConcern.AssertArgumentLength(Nome, 30, $"O nome não pode ser maior que 30 caracteres!");
            AssertionConcern.AssertArgumentLength(Nome, 5, 30, $"O nome não pode ser maior que 30 caracteres e nem menor que 5 caracteres!");
        }

        public bool Deletar(string nomeDoProduto)
        {
            return produtoLista.Remove(nomeDoProduto);
        }

        public string Atualizar(string nomeAntigo, string nomeNovo)
        {
            var produto = BuscarProdutoPorNome(nomeAntigo);

            if (produto is null)
                return "Produto não encontrato";

            _ = Deletar(produto);

            Nome = nomeNovo;
            SalvarProduto();

            return "Produto atualizado com sucesso";
        }

        public List<string> ListarTodos()
        {
            
            return produtoLista.ToList();
        }
        
    }
}
