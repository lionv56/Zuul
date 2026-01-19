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
    public void Damage(int amount)
    {
        health -= amount;
        if (health < 0)
        {
            health = 0;
        }
    }
    public bool IsAlive()
    {
        return health > 0;
    }
    public int GetHealth()
    {
        return health;
    }
}