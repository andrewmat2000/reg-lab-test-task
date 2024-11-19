using RegLabTestTask.Configuration.Domain.AggregatesModel.UserAggregate;

namespace RegLabTestTask.Configuration.UnitTests;

public class UserTests {
  [TestCase]
  public void CheckIdentitificator() {
    var user = new User() {
      BirthDay = new DateOnly(2001, 1, 24),
      FullName = "Andrey Matveev",
      Position = new() {
        Department = "Development",
        PositionName = "Software engineer"
      }
    };

    Assert.That(user.Identificator, Is.EqualTo("Andrey_Matveev_24_01_2001_0"));
  }
}