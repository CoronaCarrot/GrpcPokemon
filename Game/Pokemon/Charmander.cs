namespace GrpcPokemon
{
  public class Charmander : IPokemon
  {
    public string ASCIIArt { get; set; } = CharmanderArt.Draw();
    public string FightSpriteF { get; set; } = "" ;
    public string FightSpriteB { get; set; } = "";
    public string Name { get; set; } = "Charmander";
    public PokemonInfo.Type Type { get; set; } = PokemonInfo.Type.Fire;
    public int Level { get; set; } = 1;
    public int Health { get; set; } = 100;
    public List<Attacks> Attacks { get; set; } = new List<Attacks>() { };
    public string DateOfCapture { get; set; } = DateTime.Now.ToString();
  }
}
