namespace FIAP.Models
{
    public class Produto
    {
        public string Nome { get; set; }

        private static List<string> _produtoList = new List<string>();

        public Produto(){ }

        // public Produto(string nome)
        // {
        //     Nome = nome;
        //     ValidateEntity();
        //     SalvarProduto();
        // }



        public string SalvarProduto()
        {
            if (string.IsNullOrEmpty(Nome))
                return "Produto é obrigatório!";

            if (Nome.Length > 30)
                return "O nome deve ter até 30 caracteres!";

            _produtoList.Add(Nome);

            return "Produto salvo com sucesso!";
        }

        public string BuscarProdutoPorNome(string nomeDoProduto)
        {
            return _produtoList.FirstOrDefault(x => x == nomeDoProduto, "Produto não encontrado");
        }

        public void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O nome não pode estar vazio!");
            AssertionConcern.AssertArgumentLength(Nome, 30, "O nome deve ter até 30 caracteres!");
        }
    }
}
