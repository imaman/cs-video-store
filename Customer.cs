
using System.Collections.Generic;   
using System; 


namespace shop {

   


public class Customer {
   private string name;
   private List<Rental> rentals = new List<Rental>();

   public Customer(string name_) {
      name = name_;
   }

   public string getName() {
      return name;
   }

   public void addRental(Rental arg) {
      rentals.Add(arg);
   }

   public string statement() {
      double total = 0;
      int points = 0;
      string result = "Record for " + getName() + "\n";

      foreach(Rental rental in rentals) {
         double amount = 0;
		   int pc = rental.getMovie().getPriceCode();
         switch (pc) {
		 
         case Movie.STANDARD:
            amount += 2;
            if (rental.getDaysRented() > 2)
               amount += (rental.getDaysRented() - 2) * 1.5;
            break;         
            
         case Movie.POPULAR:
            amount += rental.getDaysRented() * 3;
            break;

         case Movie.CHILDREN:
            amount += 1.5;
            if (rental.getDaysRented() > 3)
               amount += (rental.getDaysRented() - 3) * 1.5;
            break;
         }            
            
         points++;
         if (rental.getMovie().getPriceCode() == Movie.POPULAR
            && rental.getDaysRented() > 1)
            points++;            
            
         result += string.Format("\t{0}\t{1:0.0}\n", rental.getMovie().getTitle(), amount);
         total += amount;            
      }

      result += string.Format("Amount owed is {0:0.0}\n", total);
      result += "You earned " + points + " bonus points";

      return result;
   }
}

	
}