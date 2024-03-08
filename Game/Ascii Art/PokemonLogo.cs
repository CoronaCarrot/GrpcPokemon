namespace GrpcPokemon
{
  public static class PokemonLogo
  {
    /// <summary>
    /// Set the text colour to yellow & draw the Pokemon logo to the screen
    /// </summary>
    /// <returns>The Pokemon logo</returns>
    public static string Draw()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
            return @"                                  ,'\                             
    _.----.        ____         ,'  _\   ___    ___     ____       
_,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.
\      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |
 \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |
   \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |
    \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
     \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
      \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
       \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
        \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                `'                            '-._|
";
    }
  }
}
