namespace GrpcPokemon
{
  public class Squirtle : IPokemon
  {
    public string ASCIIArt { get; set; } = SquirtleArt.Draw();
    public string Name { get; set; } = "Squirtle";
    public PokemonInfo.Type Type { get; set; } = PokemonInfo.Type.Water;
    public int Level { get; set; } = 1;
    public int Health { get; set; } = 100;
        public List<Attacks> Attacks { get; set; } = new List<Attacks>(); // [new Attacks() { Name = "Tail Whip", BaseDamage = 5 }];
    public string DateOfCapture { get; set; } = DateTime.Now.ToString();
  }
}
