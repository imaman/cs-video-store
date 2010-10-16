
using NUnit.Framework;


namespace shop {



[TestFixture]
public class Customer_Tests {

   private Customer c;

   [SetUp]
   public void setUp() {
      c = new Customer("George");
   }

   [Test]
   public void testGetName() {
      Assert.AreEqual("George", c.getName());
   }

   [Test]
   public void testStatementChildren() {
      c.addRental(new Rental(new Movie("a", Movie.CHILDREN), 1));

      compare(c.statement(), "Record for George", "\ta\t1.5",
         "Amount owed is 1.5", "You earned 1 bonus points");
   }

   [Test]
   public void testStatementChildrenFourDays() {
      c.addRental(new Rental(new Movie("a", Movie.CHILDREN), 4));

      compare(c.statement(), "Record for George", "\ta\t3.0",
         "Amount owed is 3.0", "You earned 1 bonus points");
   }

   [Test]
   public void testStatementStandard() {
      c.addRental(new Rental(new Movie("b", Movie.STANDARD), 1));

      compare(c.statement(), "Record for George", "\tb\t2.0",
         "Amount owed is 2.0", "You earned 1 bonus points");
   }

   [Test]
   public void testStatementStandardThreeDays() {
      c.addRental(new Rental(new Movie("b", Movie.STANDARD), 3));

      compare(c.statement(), "Record for George", "\tb\t3.5",
         "Amount owed is 3.5", "You earned 1 bonus points");
   }

   [Test]
   public void testStatementPopular() {
      c.addRental(new Rental(new Movie("c", Movie.POPULAR), 1));

      compare(c.statement(), "Record for George", "\tc\t3.0",
         "Amount owed is 3.0", "You earned 1 bonus points");
   }

   [Test]
   public void testStatementPopularTwoDays() {
      c.addRental(new Rental(new Movie("c", Movie.POPULAR), 2));

      compare(c.statement(), "Record for George", "\tc\t6.0",
         "Amount owed is 6.0", "You earned 2 bonus points");
   }

   [Test]
   public void shouldSumAmount() {
      c.addRental(new Rental(new Movie("c", Movie.POPULAR), 1));
      c.addRental(new Rental(new Movie("d", Movie.POPULAR), 2));

      compare(c.statement(), "Record for George", "\tc\t3.0", "\td\t6.0",
         "Amount owed is 9.0", "You earned 3 bonus points");
   }
      
      
   private void compare(string text, params string[] lines) {
      int i = -1;
      foreach(string line in text.Split('\n')) 
         Assert.AreEqual(lines[++i], line);
      
      Assert.AreEqual(lines.Length - 1, i);
   }
      
}

	
}