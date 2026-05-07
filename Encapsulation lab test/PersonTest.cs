using Encapsulation_lab;

namespace Encapsulation_lab_test
{
    public class PersonTest
    {
        [Fact]
        public void CanCreateLegitimatePerson()
        {
            //Arrange
            Person person = new Person("Anna", "Person", 35, 5000);

            //Act

            //Assert
            Assert.NotNull(person);
        }

        [Fact]
        public async Task CreateIllegalPerson()
        {
            //Arrange
            Person person = new Person("An", "Person", 35, 5000);

            //Act


            //Assert
            Assert.Null(person);

        }


    }
}
