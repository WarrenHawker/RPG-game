using System;
using System.Globalization;
using System.Linq;

public class Game(Character[] cCharacters)
{
  public Character[] characters = cCharacters;
  public Character activeCharacter = cCharacters[0];
  public bool isGameOver = false;
}