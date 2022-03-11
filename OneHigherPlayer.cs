using System;

namespace ShootingDice
{
  // TODO: Complete this class

  // Override the Play method to make a Player who always roles one higher than the other player
  public class OneHigherPlayer : Player
  {

    public int Roll(int otherRoll)
    {
      return otherRoll + 1;
    }
    public override void Play(Player other)
    {
      // call roll for "this" object and for the "other" object
      int otherRoll = other.Roll();
      int myRoll = otherRoll + 1;

      Console.WriteLine($"{Name} rolls a {myRoll}");
      Console.WriteLine($"{other.Name} rolls a {otherRoll}");

      if (myRoll > otherRoll)
      {
        Console.WriteLine($"{Name} wins!");
      }
      else if (myRoll < otherRoll)
      {
        Console.WriteLine($"{other.Name} wins!");
      }
      else
      {
        // if the rolls are equal it is a tie
        Console.WriteLine("It is a tie");
      }
    }
  }
}