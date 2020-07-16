using System;

class Match {
  public static void Main() {
    LIV teamfirst = new LIV();
    PSG teamsecond = new PSG();

    Team first = new Team(teamfirst.name, teamfirst.city, teamfirst.coach, teamfirst.start, teamfirst.rating);
    Team second = new Team(teamsecond.name, teamsecond.city, teamsecond.coach, teamsecond.start, teamsecond.rating);

    first.Information();
    Console.WriteLine("Average rating: " + first.AverageRating());

    Console.WriteLine();

    second.Information();
    Console.WriteLine("Average rating: " + second.AverageRating());
    
    Random rnd = new Random();
    int firstscore = rnd.Next(0, 5);
    int secondscore = rnd.Next(0, 5);
    
    Console.WriteLine(first.Name() + " " + firstscore + ":" + secondscore + " " + second.Name());
    Console.WriteLine("Scorers: ");

    int minfirst = 1;
    if (firstscore != 0) Console.WriteLine(first.Name() + ":");
    for (int i = 0; i < firstscore; i++) {
      minfirst = rnd.Next(minfirst, 95);
      Console.WriteLine(first.Start()[rnd.Next(1, 10)] + " " + minfirst + "'"); // + " " + rnd.Next(1, 95) + "'");
    }

    int minsecond = 1;
    if (secondscore != 0) Console.WriteLine(second.Name() + ":");
    for (int i = 0; i < secondscore; i++) {
      minsecond = rnd.Next(minsecond, 95);
      if (rnd.Next(0, 8) == 7) {
        Console.WriteLine(second.Start()[rnd.Next(1, 10)] + "(pen)" + " " + minsecond + "'");
      } else Console.WriteLine(second.Start()[rnd.Next(1, 10)] + " " + minsecond + "'"); // + " " + rnd.Next(1, 95) + "'");
    }

    if (firstscore == 0 && secondscore == 0) {
      Console.WriteLine("No goals.");
    }
  }
}