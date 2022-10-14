using FIAP.Models;
using FluentAssertions;

namespace FIAP.Tests.Models
{
    public class ProdutoTests
    {
        Produto _produto;

        public ProdutoTests()
        {


        }

        [Fact]
        public void Deve_salvar_Produto()
        {
            //Arrange
            _produto = new Produto("Cadeira");
            // Act
            var resultado = _produto.BuscarProdutoPorNome("Cadeira");

            //Assert
            resultado.Should().NotBeNull();

        }

        [Fact]
        public void Deve_Validar_Se_Produto_Esta_Vazio_Sucesso()
        {
            //Act
            var result = Assert.Throws<DomainException>(() => new Produto(""));

            //Assert
            Assert.Equal("O nome não pode estar vazio!", result.Message);

        }

        [Fact]
        public void Deve_Salvar_Produto_Validar_Tamanho_Retornando_Exception()
        {

            var result = Assert.Throws<DomainException>(() => new Produto("Neste sentido, a valorização de fatores subjetivos exige a precisão e a definição do investimento em reciclagem técnica.\r\n"));

            //Assert
            Assert.Equal("O nome não pode ser maior que 30 caracteres!", result.Message);
        }

        [Fact]
        public void Deve_Salvar_Produto_Validar_Tamanho_Minimo_Retornando_Exception()
        {

            var result = Assert.Throws<DomainException>(() => new Produto("nome"));

            //Assert
            Assert.Equal("O nome não pode ser maior que 30 caracteres e nem menor que 5 caracteres!", result.Message);
        }

        [Fact]
        public void Deve_Buscar_Produto_Por_Nome_Retornar_Sucesso()
        {
            //Arrange          
            _produto = new Produto("Cadeira");

            //Act
            var resultado = _produto.BuscarProdutoPorNome("Cadeira");

            //Assert
            resultado.Should().BeEquivalentTo("Cadeira");

        }

        [Fact]
        public void Deve_Buscar_Produto_Por_Nome_Retornar_Valor_Default()
        {
            //Arrange          
            _produto = new Produto("Cadeira");

            //Act
            var resultado = _produto.BuscarProdutoPorNome("Cadeira Giratória");

            //Assert
            resultado.Should().BeEquivalentTo("Produto não encontrado");

        }

        //Teste de listar todos
        [Fact]
        public void Deve_Listar_Todos_Produtos_Retornar_Sucesso()
        {
            //Arrange  
            _produto = new Produto("Caneca");

            //Act
            var resultado = _produto.ListarTodos();

            //Assert
            resultado.Count().Should().Be(1);
        }

        //Deletar produto
        [Fact]
        public void Deve_Deletar_Produtos_Retornar_Sucesso()
        {
            //Arrange
            var nomeProduto = "Cadeira Giratória 123";
            _produto = new Produto(nomeProduto);

            //Act
            var resultado = _produto.Deletar(nomeProduto);

            //Assert
            resultado.Should().BeTrue();
        }

        //Atualizar
    }
}
