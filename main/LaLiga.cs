class BAR {
  string name = "Barcelona";
  string city = "Barcelona";
  string coach = "Kike Setien";
  string[] start = { 
    "Ter Stegen", 
    "Roberto", "Pique", "Umtiti", "Alba", 
    "Busquets", "De Jong",
    "Messi",
    "Dembele", "Suarez", "Griezmann"
  };
  int[] rating = { 93, // Ter Stegen
    86, // Roberto
    89, // Pique
    86, // Umtiti
    90, // Alba
    87, // Busquets
    87, // De Jong
    98, // Messi
    87, // Dembele
    91, // Suarez
    89 // Griezmann
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

class RM {
  string name = "Real Madrid";
  string city = "Madrid";
  string coach = "Zinedine Zidane";
  string[] start = {
    "Courtois",
    "Carvahal", "Ramos", "Varane", "Mendy",
    "Modric", "Valverde", "Kroos",
    "Asensio", "Benzema", "Hazard"
  };
  int[] rating = {
    91, // Courtois
    88, // Carvahal
    92, // Ramos
    90, // Varane
    86, // Mendy
    89, // Modric
    88, // Valverde
    90, // Kroos
    87, // Asensio
    90, // Benzema
    91 // Hazard
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