using GundamFighterLibrary;

namespace TestGundamProject
{

    public class UnitTest1
    {
        [Fact]
        public void TestZakuBlock()
        {
            //Arrange
            Zaku zaku = new Zaku("Zaku", 45, 20, 80, 35, 25, "zoom");
            int expectedBlock = 0;
            int actualBlock = 0;

            //Act
            expectedBlock = 20;
            actualBlock = zaku.CalcBlock();

            //Assert
            Assert.Equal(expectedBlock, actualBlock);
        }

        [Fact]
        public void TestZakuHitChance()
        {
            //Arrange
            Zaku zaku = new Zaku("Zaku", 45, 20, 80, 35, 25, "zoom");
            int expectedHitChance = 0;
            int actualHitChance = 0;

            //Act
            expectedHitChance = 45;
            actualHitChance = zaku.CalcHitChance();

            //Assert
            Assert.Equal(expectedHitChance, actualHitChance);
        }

        [Fact]
        public void TestDOMTrooperBlock()
        {
            //Arrange
            DOMTrooper domTrooper = new DOMTrooper("DOM Trooper", 45, 20, 80, 35, 25, "whoosh");
            int expectedBlock = 0;
            int actualBlock = 0;

            //Act
            expectedBlock = 20;
            actualBlock = domTrooper.CalcBlock();

            //Assert
            Assert.Equal(expectedBlock, actualBlock);
        }

        [Fact]
        public void TestDOMTrooperHitChance()
        {
            //Arrange
            DOMTrooper domTrooper = new DOMTrooper("DOM Trooper", 45, 20, 80, 35, 25, "whoosh");
            int expectedHitChance = 0;
            int actualHitChance = 0;

            //Act
            expectedHitChance = 45;
            actualHitChance = domTrooper.CalcHitChance();

            //Assert
            Assert.Equal(expectedHitChance, actualHitChance);
        }

        [Fact]
        public void TestplayerGMHitChance()
        {
            //Arrange

            Player playerGM = new Player("GM", 10, 10, 10, 80, MSEnums.GM);
            int expectedHitChance = 0;
            int actualHitChance = 0;

            //Act
            expectedHitChance = 70;
            actualHitChance = playerGM.CalcHitChance();

            //Assert
            Assert.Equal(expectedHitChance, actualHitChance);
        }






    }

}