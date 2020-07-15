using System;

class Team {
  string name;
  string city;
  int players;
  int[] rating;

  public Team(string n, string c, int p, int[] r) {
    name = n;
    city = c;
    players = p;
    rating = r;
  } 
  public int AverageRating() {
    int sum = 0;
    for (int i = 0; i < rating.Length; i++) {
      sum += rating[i];
    }
    return sum / players;
  }
}
