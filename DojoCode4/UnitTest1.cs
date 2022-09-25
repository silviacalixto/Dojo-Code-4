using DojoCodeApp4;
using NUnit.Framework;

namespace DojoCode4
{
    
    //15415,16 -> quinze mil quatrocentos e quinze reais e dezesseis centavos
    //0,05 -> cinco centavos
    //2,25 -> dois reais e vinte e cinco centavos

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_Pass_001_Should_Return_UmCentavo()
        {
            var result = app.ConvertNumberToWords(0.01);
            Assert.AreEqual("Um Centavo", result);
        }

        [Test]
        public void When_Pass_002_Should_Return_DoisCentavos()
        {
            var result = app.ConvertNumberToWords(0.02);
            Assert.AreEqual("Dois Centavos", result);
        }

        [Test]
        public void When_Pass_022_Should_Return_VinteEDoisCentavos()
        {
            var result = app.ConvertNumberToWords(0.22);
            Assert.AreEqual("Vinte e Dois Centavos", result);
        }

        [Test]
        public void When_Pass_055_Should_Return_CinquentaECincoCentavos()
        {
            var result = app.ConvertNumberToWords(0.55);
            Assert.AreEqual("Cinquenta e Cinco Centavos", result);
        }

        [Test]
        public void When_Pass_097_Should_Return_NoventaESeteCentavos()
        {
            var result = app.ConvertNumberToWords(0.97);
            Assert.AreEqual("Noventa e Sete Centavos", result);
        }

        [Test]
        public void When_Pass_1e53_Should_Return_UmRealECinquentaETrêsCentavos()
        {
            var result = app.ConvertNumberToWords(1.53);
            Assert.AreEqual("Um Real e Cinquenta e Três Centavos", result);
        }

        [Test]
        public void When_Pass_40e12_Should_Return_QuarentaReaisEDozeCentavos()
        {
            var result = app.ConvertNumberToWords(40.12);
            Assert.AreEqual("Quarenta Reais e Doze Centavos", result);
        }

        [Test]
        public void When_Pass_99e99_Should_Return_NoventaENoveReaisENoventaENoveCentavos()
        {
            var result = app.ConvertNumberToWords(99.99);
            Assert.AreEqual("Noventa e Nove Reais e Noventa e Nove Centavos", result);
        }

        [Test]
        public void When_Pass_172_Should_Return_CentoESetentaEDoisReais()
        {
            var result = app.ConvertNumberToWords(172);
            Assert.AreEqual("Cento e Setenta e Dois Reais", result);
        }

        [Test]
        public void When_Pass_199e99_Should_Return_CentoENoventaENoveReaisENoventaENoveCentavos()
        {
            var result = app.ConvertNumberToWords(199.99);
            Assert.AreEqual("Cento e Noventa e Nove Reais e Noventa e Nove Centavos", result);
        }

        private readonly Class1 app = new();
    }
}