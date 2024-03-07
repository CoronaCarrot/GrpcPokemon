namespace GrpcPokemon
{
  public class Bulbasaur : IPokemon
  {
    public string ASCIIArt { get; set; } = BulbasaurArt.Draw();
    public string FightSpriteF { get; set; } = @"
⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⢾⣿⣿⣶⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢀⢤⣶⣿⣫⣽⣿⣿⣿⣿⣿⣿⣦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⣀⣰⣟⣿⣿⠿⠿⠿⠿⠿⠿⢿⣿⣿⣿⣿⡷⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠸⠉⢩⠉⠋⠀⠀⠀⠀⢀⣤⠀⠀⠀⢉⠹⠉⠀⣸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⣿⡷⣦⡱⢄⠷⡆⠀⢿⣿⢇⣴⣶⠟⢷⠀⢾⣿⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⢠⠹⢇⣘⣹⡇⠀⠀⠉⠀⠀⣾⣏⣻⡄⣸⠀⠈⣿⡿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⢸⠀⢀⣤⣾⣦⣓⣘⣦⣶⣶⣶⣶⣤⡀⠈⠀⢠⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣠⣾⣿⣿⣼⣿⣿⣿⣿⣿⣿⣿⣯⣿⣿⠗⣠⡜⠁⢸⣆⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⣜⣿⠈⠻⠿⠫⣭⣭⣭⣭⣭⣭⣭⣭⡭⠻⠖⠉⢠⠀⣼⡏⢧⡀⠀⠀⠀⠀⠀⠀⠀⠀
⢿⣿⣶⠸⣿⡆⠀⢹⣿⣿⣿⣿⣿⡿⠁⣾⣿⠇⠀⣸⣿⣿⡾⠃⠀⠀⠀⠀⠀⠀⠀⠀
⢈⡻⡿⢷⣤⣤⣀⢾⣏⠿⠿⠿⠿⡷⣄⡀⢀⡠⢾⠿⣿⡿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠈⠛⠛⠛⠜⠋⠛⠁⠀⠀⠀⠀⠀⠛⠜⠣⠛⠛⠃⠀⠀⠀⠀⠀⠀
";
    public string FightSpriteB { get; set; } = @"
⠀⠀⠀⠀⠀⠀⢠⡌⠱⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢸⡟⢣⡄⠈⢣⣤⣤⣤⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢸⡇⢸⣧⡄⠀⠀⠘⠛⣤⠛⠛⠛⣤⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢠⣼⡇⢸⣿⣧⡄⠀⠀⠀⠀⠀⠛⠛⣤⡄⠘⢣⡄⢠⡜⠛⠓⣄⠀⠀
⠀⠀⣀⣾⣿⡿⠃⠈⢹⣿⡇⠀⠀⠀⠀⠀⠀⠀⠈⠻⢇⡀⢸⡇⠀⢀⣀⠟⠀⠀
⣀⣶⣿⣿⣿⡇⠀⠀⢸⣿⣿⣶⠀⠀⠀⠀⠀⠀⠀⠀⢸⡇⢸⡇⠀⢀⣹⠶⣀⠀
⣿⠉⣿⣿⣿⡇⠀⠀⠸⢿⣿⣿⣶⠀⠀⠀⠀⠀⠀⠀⢸⣇⣸⡇⢰⣎⣉⣶⣿⠀
⣿⠀⣿⣿⣿⣇⠀⠀⠀⢸⣿⣿⣿⣶⣀⠀⠀⠀⢀⣠⣾⣿⣿⣷⣾⣿⣿⣿⣿⣶
⣿⣀⣿⣿⣿⣿⣧⡄⠀⠀⠻⣿⣿⣿⣿⣤⣤⣤⣿⣿⣿⣿⡟⢻⣿⣿⣿⣿⠿⠛
⠀⠛⣧⡟⢻⣿⣿⣿⣿⣧⣤⣤⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⢣⣼⡟⠋⠀⠀⠀
";
    public string Name { get; set; } = "Bulbasaur";
    public PokemonInfo.Type Type { get; set; } = PokemonInfo.Type.Grass;
    public int Level { get; set; } = 1;
    public int Health { get; set; } = 100;
        public List<Attacks> Attacks { get; set; } = new List<Attacks>(); //[new Attacks() { Name = "Growl", BaseDamage = 5 }];
    public string DateOfCapture { get; set; } = DateTime.Now.ToString();
  }
}
