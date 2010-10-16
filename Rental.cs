namespace shop {

public class Rental {
   private Movie movie;
   private int daysRented;

   public Rental(Movie movie_, int daysRented_) {
      movie = movie_;
      daysRented = daysRented_;
   }

   public Movie getMovie() {
      return movie;
   }

   public int getDaysRented() {
      return daysRented;
   }
}
	
}