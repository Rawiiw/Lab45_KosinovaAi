using Lab45_KosinovaAiLib;

namespace Tests45
{
    public class KosinovaAi_Tests45
    {
        private Func<float, int> getFunc;

        Func<float, int> GetFunc { get => getFunc; set => getFunc = value; }

        [SetUp]
        public void SetUp()
        {
            GetFunc = Converter.Do;
        }
        [Test]
        public void CanConvertN2000(int output) {
            output = GetFunc.Invoke(int.MinValue);
         Assert.That(output,Is.EqualTo(-2000));
        }
        [Test]
        public void CanConvertTointN2000(int output) {
            output = GetFunc.Invoke(-2000);
           Assert.That(output, Is.EqualTo(-2000));
        }
        [Test]
        public void CanConverttoM5(int output) { 
            output = GetFunc.Invoke(-15.5f);
            Assert.That(output, Is.EqualTo(-20));
        }
        [Test]
        public void CanConvertN2000UpBound(int output)
        {
           output = GetFunc.Invoke(-30.5f);
            Assert.That(output, Is.EqualTo(-2000));
        }


        [Test]
        public void CanConvertM5BotBound(int output) {
             output = GetFunc.Invoke(-30.4f);
            Assert.That(output, Is.EqualTo(-35));
        }



        [Test]
        public void CanConvertIntMinus5_UpperBound(int output)
        {
        output = GetFunc.Invoke(-0.1f);
            Assert.That(output, Is.EqualTo(-5));
        }


        [Test]
        public void GeneratesException(int output)
        {
            Assert.Throws<ArgumentException>(() => GetFunc.Invoke(0));
        }


        [Test]
        public void CanConvertIntBotBound(int output)
        {
            output = GetFunc.Invoke(0.1f);
            Assert.That(output, Is.EqualTo(0));
        }
        [Test]
        public void CanConvert1000UpBound(int output)
        {
            output = GetFunc.Invoke(float.MaxValue);
            Assert.That(output, Is.EqualTo(1000));
        }

        [Test]
        public void CanConvertIntInBound(int output)
        {
           output = GetFunc.Invoke(50.5f);
            Assert.That(output, Is.EqualTo(50));
        }

        [Test]
        public void CanConvertIntUpBound(int output)
        {
            output = GetFunc.Invoke(100.6f);
            Assert.That(output, Is.EqualTo(100));
        }


        [Test]
        public void CanConvert1000BotBound(int output)
        {
            output = GetFunc.Invoke(100.7f);
            Assert.That(output, Is.EqualTo(1000));
        }

        [Test]
        public void CanConvert1000InBound(int output)
        {
             output = GetFunc.Invoke(200);
            Assert.That(output, Is.EqualTo(1000));
        }

       
    }
}
