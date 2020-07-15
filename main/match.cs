using System;

class Match {
  public static void Main() {
    Team first = new Team(MU.MUname, MU.MUcity, MU.MUcoach, MU.MUstart, MU.MUrating);
    Team second = new Team(LIV.LIVname, LIV.LIVcity, LIV.LIVcoach, LIV.LIVstart, LIV.LIVrating);
    first.Information();
    Console.WriteLine("Average rating: " + first.AverageRating());
    Console.WriteLine();
    second.Information();
    Console.WriteLine("Average rating: " + second.AverageRating());
  }
}