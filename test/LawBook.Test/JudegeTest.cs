using System;
using Xunit;

namespace LawBook.Test
{
    public class JudegeTest
    {
        [Fact]
        public void ObjectValidationByValidadeTest()
        {
            Car myCar = new Car("Gasoline", 4, 4);

            var exception = Record.Exception(() => myCar.Validate());

            Assert.Null(exception);
        }

        [Fact]
        public void ObjectValidationByValidateThrowsTest()
        {
            Car myCar = new Car("Water", 4, 4);

            Assert.Throws<GuiltyException>(() => myCar.Validate());
        }

        [Fact]
        public void ObjectValidationByJudgeTest()
        {
            Car myCar = new Car("Gasoline", 4, 4);

            Assert.True(Judge.Sentence(myCar, false));

        }

        [Fact]
        public void ObjectValidationByJudgeThrowsTest()
        {
            Car myCar = new Car("Water", 4, 4);

            Assert.Throws<GuiltyException>(() => Judge.Sentence(myCar, false));
        }

        [Fact]
        public void ObjectValidationByJudgeSilencedPassTest()
        {
            Car myCar = new Car("Gasoline", 4, 4);

            Assert.True(Judge.Sentence(myCar, true));

        }

        [Fact]
        public void ObjectValidationByJudgeSilencedFailTest()
        {
            Car myCar = new Car("Water", 4, 4);

            Assert.False(Judge.Sentence(myCar, true));
        }
    }
}
