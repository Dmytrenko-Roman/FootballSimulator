/* using System;

class PLAYOFF {
  public static void Main() {
    MU team1 = new MU();
    BAY team2 = new BAY();
    BAR team3 = new BAR();
    RM team4 = new RM();
    BD team5 = new BD();
    LIV team6 = new LIV();
    PSG team7 = new PSG();
    CHE team8 = new CHE();

    object teams = new object() {team1, team2, team3, team4, team5, team6, team7, team8};

    foreach (object t in teams) {
    Team first = new Team(t.Name(), teamfirst.City(), teamfirst.Coach(), teamfirst.Start(), teamfirst.Rating());
    Team second = new Team(teamsecond.Name(), teamsecond.City(), teamsecond.Coach(), teamsecond.Start(), teamsecond.Rating());

    first.Information();
    Console.WriteLine("Average rating: " + first.AverageRating());

    Console.WriteLine();

    second.Information();
    Console.WriteLine("Average rating: " + second.AverageRating());
    
    Random rnd = new Random();

    int balance = 70;
    int firstkoef = first.AverageRating() / balance;
    int secondkoef = second.AverageRating() / balance;
    int firstscore = rnd.Next(0, 5) * firstkoef;
    int secondscore = rnd.Next(0, 5) * secondkoef;
    
    Console.WriteLine(first.Name() + " " + firstscore + ":" + secondscore + " " + second.Name());
    Console.WriteLine("Scorers: ");

    int minfirst = 1;
    if (firstscore != 0) Console.WriteLine(first.Name() + ":");
    for (int i = 0; i < firstscore; i++) {
      minfirst = rnd.Next(minfirst, 95);
      int accident = rnd.Next(0, 3);
      if (accident == 2) {
        int scorer = rnd.Next(1, 10);
        Console.WriteLine(first.Start()[scorer] + " " + minfirst + "'");
      } else {
        int scorer = rnd.Next(1, 11);
        int assistant = rnd.Next(1, 11);
        if (assistant != scorer) {
          Console.WriteLine(first.Start()[scorer] + "(" + first.Start()[assistant] + ") " + minfirst + "'");
        } else Console.WriteLine(first.Start()[scorer] + "(pen) " + minfirst + "'");
        
      }
    }

    int minsecond = 1;
    if (secondscore != 0) Console.WriteLine(second.Name() + ":");
    for (int i = 0; i < secondscore; i++) {
      minsecond = rnd.Next(minsecond, 95);
      int accident = rnd.Next(0, 3);
      if (accident == 2) {
        int scorer = rnd.Next(1, 10);
        Console.WriteLine(second.Start()[scorer] + " " + minsecond + "'");
      } else {
        int scorer = rnd.Next(1, 11);
        int assistant = rnd.Next(1, 11);
        if (assistant != scorer) {
          Console.WriteLine(second.Start()[scorer] + "(" + second.Start()[assistant] + ") " + minsecond + "'");
        } else Console.WriteLine(second.Start()[scorer] + "(pen) " + minsecond + "'");
      } 
    }

    if (firstscore == 0 && secondscore == 0) Console.WriteLine("No goals.");
    }

  }
} */