using Xunit;

namespace lab1
{
    public class testclass
    {
        private Calculator calculator=new Calculator();
        [Fact]
        public void Test_Plus(){
           Assert.Equal(calculator.Plus(2,2),4);
        }

        [Fact]
        public void Test_Minus()
        {
            Assert.Equal(calculator.Minus(5,2),3);
        }

        [Fact]
        public void Test_Multiplication()
        {
            Assert.Equal(calculator.Multiplication(2,2),4);
        }

        [Fact]
        public void Test_Division()
        {
            Assert.Equal(calculator.Division(2,2),1);
        }
        
        [Fact]
        public void Test_Mod()
        {
            Assert.Equal(calculator.Mod(5,2),1);
        }
    }
}
