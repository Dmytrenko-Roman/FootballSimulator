class BAY {
  string name = "Bayern Munich";
  string city = "München";
  string coach = "Hans-Dieter Flick";
  string[] start = { 
    "Neuer", 
    "Pavard", "Boateng", "Alaba", "Davis", 
    "Goretzka", "Kimmich",
    "Müller",
    "Gnabri", "Lewandowski", "Coman"
  };
  int[] rating = { 90, // Neuer
    86, // Pavard
    85, // Boateng
    87, // Alaba
    90, // Davis
    88, // Goretzka
    89, // Kimmich
    89, // Müller
    90, // Gnabri
    96, // Lewandowski
    88 // Coman
  };
  public string Name() {
    return name;
  }
  public string City() {
    return city;
  }
  public string Coach() {
    return coach;
  }
  public string[] Start() {
    return start;
  }
  public int[] Rating() {
    return rating;
  }
}

class BD {
  string name = "Borussia Dortmund";
  string city = "Dortmund";
  string coach = "Lucien Favr";
  string[] start = { 
    "Bürki", 
    "Hakimi", "Hummels", "Akanji", "Guerreiro", 
    "Witsel", "Can",
    "Brandt",
    "Sancho", "Haaland", "Reus"
  };
  int[] rating = { 86, // Bürki
    87, // Hakimi
    87, // Hummels
    85, // Akanji
    86, // Guerreiro
    86, // Witsel
    86, // Can
    88, // Brandt
    93, // Sancho
    92, // Haaland
    89 // Reus
  };
  public string Name() {
    return name;
  }
  public string City() {
    return city;
  }
  public string Coach() {
    return coach;
  }
  public string[] Start() {
    return start;
  }
  public int[] Rating() {
    return rating;
  }
}