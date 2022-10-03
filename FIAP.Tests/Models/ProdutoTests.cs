using FIAP.Models;
using FluentAssertions;

namespace FIAP.Tests.Models
{
    public class ProdutoTests
    {
        Produto _produto;
        public ProdutoTests()
        {
            _produto = new Produto();
            _produto.SalvarProduto("Cadeira");
            _produto.SalvarProduto("Mesa");
            _produto.SalvarProduto("Mouse");
        }

        [Fact]
        public void Deve_salvar_Produto()
        {
            //Arrange
          
            //Act
            var resultado = _produto.BuscarProdutoPorNome("Cadeira");

            //Assert
            resultado.Should().NotBeNull();

        }

        [Fact]
        public void Deve_Buscar_Produto_Por_Nome_Retornar_Sucesso()
        {
            //Arrange          

            //Act
            var resultado = _produto.BuscarProdutoPorNome("Cadeira");

            //Assert
            resultado.Should().BeEquivalentTo("Cadeira");

        }

        [Fact]
        public void Deve_Buscar_Produto_Por_Nome_Retornar_Valor_Default()
        {
            //Arrange          

            //Act
            var resultado = _produto.BuscarProdutoPorNome("Cadeira Giratória");

            //Assert
            resultado.Should().BeEquivalentTo("Produto não encontrado");

        }
    }
}
