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

            //Act
            var resultado = _produto.BuscarProdutoPorNome("Cadeira");

            //Assert
            resultado.Should().NotBeNull();

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

        [Fact]
        public void Deve_salvar_Produto_Vazio_Retornar_Exception()
        {

            var result = Assert.Throws<DomainException>(() => new Produto(""));

            //Assert
            Assert.Equal("O nome não pode estar vazio!", result.Message);
        }

        [Fact]
        public void Deve_salvar_Produto_Validar_Tamanho_Retornar_Exception()
        {

            var result = Assert.Throws<DomainException>(() => new Produto("Neste sentido, a valorização de fatores subjetivos exige a precisão e a definição do investimento em reciclagem técnica.\r\n"));

            //Assert
            Assert.Equal("O nome deve ter até 30 caracteres!", result.Message);
        }

       
    }
}
