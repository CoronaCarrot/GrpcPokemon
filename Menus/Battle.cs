using GrpcPokemon.Menus.Display;
using System.ComponentModel;

namespace GrpcPokemon
{
  public class Battle
  {
    public BattleUi UI = new BattleUi(new Bulbasaur());
    public int playerTurn = 0;

    public Action StartBattle()
    {
      return () => { };
    }

    public void HandleAction(Action playerAction)
    {
      throw new NotImplementedException();
    }

  }
}
