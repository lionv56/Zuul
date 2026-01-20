class Player
{
    // auto property
    // fields
    public Room currentRoom { get; set; }
    private int health;
    // constructor 
    public Player()
    {
        currentRoom = null;
        health = 100;
    }
    public void Heal(int amount)
    {
        health += amount;
        if (health > 100)
        {
            health = 100;
        }
    }
    public void Damage()
    {
        health -= 10;
        if (health < 0)
        {
            health = 0;
        }
    }
    public bool IsAlive()
    {
         if (health > 0)
         {
            return true;
         }
         else
         {
            return false;
         }
    }
    public int GetHealth()
    {
        return health;
    }
}