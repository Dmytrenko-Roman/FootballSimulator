class ATA {
  string name = "Atalanta";
  string city = "Bergamo";
  string coach = "Gian Piero Gasperini";
  string[] start = {
    "Sportiello",
    "Toloi", "Caldara", "Djimsiti", 
    "Castange", "Tameze", "de Roon", "Meijers",
    "Gomez",
    "Zapata", "Malinovskiy"
  };
  int[] rating = { 86, // Sportiello
    82, // Toloi
    83, // Caldara
    82, // Djimsiti
    83, // Castange
    80, // Tameze
    84, // de Roon
    82, // Meijers
    90, // Gomez
    86, // Zapata
    85 // Malinovskiy
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

class JUV {
  string name = "Juventus";
  string city = "Turin";
  string coach = "Mauricio Sarri";
  string[] start = {
    "Buffon",
    "Sandro", "De Ligt", "Chiellini", "Cuadrado",
    "Bentancur", "Pjanic",
    "Dybala",
    "Costa", "Higuain", "Ronaldo"
  };
  int[] rating = { 86, // Buffon
    87, // Sandro
    88, // De Ligt
    90, // Chiellini
    87, // Cuadrado
    86, // Bentancur
    87, // Pjanic
    92, // Dybala
    88, // Costa
    89, // Higuain
    97 // Ronaldo
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