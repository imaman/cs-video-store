
using NUnit.Framework;

namespace shop {

[TestFixture]   
public class Movie_Tests {

   [Test]
   public void testGetTitle() {
      Movie m = new Movie("a", Movie.CHILDREN);
      Assert.AreEqual("a", m.getTitle());
   }

   [Test]
   public void testGetPriceCode() {
      Movie m = new Movie("a", Movie.CHILDREN);
      Assert.AreEqual(Movie.CHILDREN, m.getPriceCode());
   }

   [Test]
   public void testSetPriceCode() {
      Movie m = new Movie("a", Movie.CHILDREN);
      m.setPriceCode(Movie.POPULAR);
      Assert.AreEqual(Movie.POPULAR, m.getPriceCode());
   }
}
   
}
