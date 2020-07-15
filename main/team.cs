using System;

class Team {
  string name;
  string city;
  string coach;
  int players = 11;
  string[] start;
  int[] rating;

  public Team(string n, string c, string co, string[] s, int[] r) {
    name = n;
    city = c;
    rating = r;
    coach = co;
    start = s;
  } 
  public int AverageRating() {
    int sum = 0;
    for (int i = 0; i < rating.Length; i++) {
      sum += rating[i];
    }
    return sum / players;
  }
  public void Information() {
    Console.WriteLine("Name: " + name);
    Console.WriteLine("City: " + city);
    Console.WriteLine("Coach: " + coach);
    Console.WriteLine("----------");
    Console.WriteLine("Start:");
    for (int i = 0; i < start.Length; i++) {
      Console.WriteLine(start[i]);
    }
  }
}
