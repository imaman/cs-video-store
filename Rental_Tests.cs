using NUnit.Framework;

namespace shop {

[TestFixture]
public class Rental_Tests {

   [Test]
   public void testGetMovie() {
      Movie m = new Movie("b", Movie.STANDARD);
      Rental r = new Rental(m, 5);

      Assert.AreEqual(m, r.getMovie());
   }

   [Test]
   public void testGetDaysRented() {
      Movie m = new Movie("b", Movie.STANDARD);
      Rental r = new Rental(m, 5);

      Assert.AreEqual(5, r.getDaysRented());
   }
}
   
}
