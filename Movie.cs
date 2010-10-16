namespace shop {

public class Movie {
   public const int STANDARD = 0;
   public const int CHILDREN = 1;
   public const int POPULAR = 2;

   private string title;
   private int priceCode;

   public Movie(string title_, int kind_) {
      title = title_;
      priceCode = kind_;
   }

   public string getTitle() {
      return title;
   }

   public int getPriceCode() {
      return priceCode;
   }

   public void setPriceCode(int arg) {
      priceCode = arg;
   }
}

}