using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminUserCancelling_ReturnTrue()
        {
            //Arrange
            var reservation = new Reservation();
            var adminUser = new User { IsAdmin = true };
            //Act   
            var result = reservation.CanBeCancelledBy(adminUser);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()
        {
            //Arrange
            var owerUser = new User();
            var reservation = new Reservation{ MadeBy= owerUser };
            //Act   
            var result = reservation.CanBeCancelledBy(owerUser);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
        {
            //Arrange
            var owerUser = new User();
            var reservation = new Reservation { MadeBy = owerUser };

            var newUser = new User();
            //Act   
            var result = reservation.CanBeCancelledBy(newUser);

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
