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
    /* string[] firstscore = {"1:0", "2:0", "3:0", "4:0", "5:0",
    "2:1", "3:1", "4:1", "5:1",
    "3:2", "4:2", "5:2",
    "4:3", "5:3",
    "5:4"};
    string[] draw = {"0:0", "1:1", "2:2", "3:3", "4:4", "5:5"}; */
    Random rnd = new Random();
    int firstscore = rnd.Next(0, 7);
    int secondscore = rnd.Next(0, 7);
    /* if (first.AverageRating() < second.AverageRating()) {
      while (secondscore < firstscore) {
        firstscore = rnd.Next(0, 5);
        secondscore = rnd.Next(0, 5);
      }
    } else {
      while (secondscore > firstscore) {
        firstscore = rnd.Next(0, 5);
        secondscore = rnd.Next(0, 5);
      }
    } */
    Console.WriteLine(first.Name() + " " + firstscore + ":" + secondscore + " " + second.Name());
    Console.WriteLine("Scorers: ");
    if (firstscore != 0) Console.WriteLine(first.Name() + ":");
    for (int i = 0; i < firstscore; i++) {
      Console.WriteLine(first.Start()[rnd.Next(1, 10)]); // + " " + rnd.Next(1, 95) + "'");
    }
    if (secondscore != 0) Console.WriteLine(second.Name() + ":");
    for (int i = 0; i < secondscore; i++) {
      Console.WriteLine(second.Start()[rnd.Next(1, 10)]); // + " " + rnd.Next(1, 95) + "'");
    }
  }
}