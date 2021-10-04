using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Marvel.UnitTests
{
    //UNO does not support Unit Test, but this an idea how it works 
    [TestClass]
    public class CharacterViewModelTest
    {
        [TestMethod]
        public void Search_InvalidNumber_ReturnsNull()
        {
            //Arrange
            //int characterId = 121212;
            //var characterViewModel = new CharacterViewModel();

            //Act
            //characterViewModel.CharacterId = characterId;
            //characterViewModel.ExecuteSearch().Execute(null);
            //Assert
            //Assert.IsNull(characterViewModel.Hero);
        }
        
        [TestMethod]
        public void Search_ValidNumber_ReturnsHero()
        {
            //Arrange
            //int characterId = 1009610;
            //var characterViewModel = new CharacterViewModel();

            //Act
            //characterViewModel.CharacterId = characterId;
            //characterViewModel.ExecuteSearch().Execute(null);
            //Assert
            //Assert.IsNotNull(characterViewModel.Hero);
        }
    }
}
