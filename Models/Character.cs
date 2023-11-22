using System;
using System.Globalization;

public class Character(string cName, string cType, int cHealth, int cAttack, int cSpeed)
{
  // public properties
  public string id = RandomStringGenerator.GenerateRandomString(8);
  public int maxHealth = cHealth;
  public int attack = cAttack;
  public string type = cType;
  public string name = cName;
  public bool hasActed = false;
  public int speed = cSpeed;
  public string? target = null;

  //private properties
  private bool isDead = false;
  private int currentHealth = cHealth;

  //public methods
  public void TakeDamage(int value)
  {
    currentHealth -= value;
    CheckIsDead();
  }

  //private methods
  private void CheckIsDead()
  {
    if (currentHealth <= 0)
    {
      isDead = true;
    }
  }
}