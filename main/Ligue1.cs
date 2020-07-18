class PSG {
  string name = "Paris Saint-Germain";
  string city = "Paris";
  string coach = "Thomas Tuhel";
  string[] start = {
    "Navas",
    "Kehrer", "Kimpembe", "Silva", "Bernat", 
    "Marquinhos", "Verratti", 
    "Mbappe", "Neymar", "Di Maria",
    "Icardi"
  };
  public int[] rating = { 90, // Navas
    82, // Kehrer
    84, // Kimpembe
    86, // Silva
    85, // Bernat
    87, // Marquinhos
    88, // Verratti
    95, // Mbappe
    96, // Neymar
    89, // Di Maria
    88 // Icardi
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