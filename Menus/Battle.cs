using System.ComponentModel;

namespace GrpcPokemon
{
  public static class Battle
  {
    public static int playerTurn = 0;

    public static Action StartBattle()
    {
      return () => { };
    }

    public static void HandleAction(Action playerAction)
    {
      throw new NotImplementedException();
    }


    public static 

  }
}
