using JornadaMilhasV1.Modelos;

namespace JornadaMilhas.Teste
{
    public class OfertaViagemTest
    {
        [Fact]
        public void TestandoOfertaValida()
        {
            Rota rota = new Rota("OrigemTeste", "DestinoTeste");
            Periodo periodo = new Periodo(new DateTime(2024, 02, 1), new DateTime(2024, 2, 5));
            double preco = 100.0;
            var validacao = true;
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);
            Assert.Equal(validacao, oferta.EhValido);
        }
        [Fact]
        public void TestandoOfertaComRotaNula()
        {
            //cenario
            Rota rota = null;
            Periodo periodo = new Periodo(new DateTime(2024, 02, 1), new DateTime(2024, 2, 5));
            double preco = 100.0;
            //a��o
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);
            //valida��o
            Assert.Contains("A oferta de viagem n�o possui rota ou per�odo v�lidos.", oferta.Erros.Sumario);
            Assert.False(oferta.EhValido);
        }
    }
}