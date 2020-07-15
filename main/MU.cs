using System;

class MU {
  static void Main() {
    int[] rat = { 90, // De Gea
    80, // Lindelof
    86, // Shaw
    87, // Wan-Bissaka
    88, // Maguaire
    90, // Fernandes
    84, // Matic
    85, // Pogba
    90, // Martial
    91, // Rashford
    87 // Greenwood
    };
    Team MU = new Team("Manchester United", "Manchester", 11, rat);
    Console.WriteLine("Average rating: " + MU.AverageRating());
  }
}