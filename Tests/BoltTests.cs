using Bolt.ClassesAndInterfaces;

namespace Tests
{
    [TestClass]
    public class BoltTests
    {
        [TestMethod]
        public void ChangePassword_Test1()
        {
            RegisteredUser user = new RegisteredUser("Ірина", "Деліжан", 123456789, "12345678");
            user.Code = 1234;
            Assert.IsTrue(user.ChangePassword(1234, "87654321"));
        }
        [TestMethod]
        public void ChangePassword_Test2()
        {
            RegisteredUser user = new RegisteredUser("Ірина", "Деліжан", 123456789, "12345678");
            user.Code = 1234;
            Assert.IsFalse(user.ChangePassword(1235, "87654321"));
        }
        [TestMethod]
        public void ChangePassword_Test3()
        {
            RegisteredUser user = new RegisteredUser("Ірина", "Деліжан", 123456789, "12345678");
            user.Code = 1234;
            Assert.IsFalse(user.ChangePassword(1235, "87654321"));
        }
        [TestMethod]
        public void CheckAge_Test1()
        {
            Assert.IsTrue(RegisteredUser.CheckAge(14));
        }
        [TestMethod]
        public void CheckAge_Test2()
        {
            Assert.IsFalse(RegisteredUser.CheckAge(11));
        }
        [TestMethod]
        public void CheckAge_Test3()
        {
            Assert.IsTrue(RegisteredUser.CheckAge(18));
        }
        [TestMethod]
        public void DefineSpeed_Test1()
        {
            RegisteredUser user = new RegisteredUser("Ірина", "Деліжан", 123456789, "12345678");
            user.Age = 16;
            Assert.AreEqual(15, user.DefineSpeed(user.Age));
        }
        [TestMethod]
        public void DefineSpeed_Test2()
        {
            RegisteredUser user = new RegisteredUser("Ірина", "Деліжан", 123456789, "12345678");
            user.Age = 18;
            Assert.AreEqual(25, user.DefineSpeed(user.Age));
        }
        [TestMethod]
        public void DefineSpeed_Test3()
        {
            RegisteredUser user = new RegisteredUser("Ірина", "Деліжан", 123456789, "12345678");
            user.Age = 25;
            Assert.AreEqual(25, user.DefineSpeed(user.Age));
        }
        [TestMethod]
        public void CompareTo_Test1()
        {
            IssuePoint issuePoint = new IssuePoint(3, "Харків", "Чкалова", 12);
            Scooter scooter = new Scooter(2, 11, 12, "12.12.2023", 1212, 0, issuePoint);
            Assert.ThrowsException<ArgumentException>(() => scooter.CompareTo(null));
        }
        [TestMethod]
        public void UseDiscount_Test1()
        {
            IssuePoint issuePoint = new IssuePoint(3, "Харків", "Чкалова", 12);
            Scooter scooter = new Scooter(2, 11, 12, "12.12.2023", 1212, 0, issuePoint);
            RegisteredUser user = new RegisteredUser("Ірина", "Деліжан", 123456789, "12345678");
            scooter.Id = 0;
            user.Scooters = new List<Scooter> { scooter };
            user.Discount = 30;
            Assert.AreEqual(0, user.UseDiscount("12.12.2023", 11));
        }
        [TestMethod]
        public void UseDiscount_Test2()
        {
            IssuePoint issuePoint = new IssuePoint(3, "Харків", "Чкалова", 12);
            Scooter scooter = new Scooter(2, 11, 12, "12.12.2023", 1212, 0, issuePoint);
            RegisteredUser user = new RegisteredUser("Ірина", "Деліжан", 123456789, "12345678");
            scooter.Id = 0;
            user.Scooters = new List<Scooter> { scooter };
            user.Discount = 30;
            Assert.AreEqual(-1, user.UseDiscount("11.12.2023", 11));
        }

    }
}