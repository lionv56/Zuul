class Inventory
{
    // fields 
    private int maxWeight;
    private Dictionary<string, Item> items;
    // constructor 
    public Inventory(int maxWeight)
    {
        this.maxWeight = maxWeight;
        this.items = new Dictionary<string, Item>();
    }
    // methods 
    public bool Put(string itemName, Item item)
    {
        // TODO implementeer:
        // Check het gewicht van het Item
        // Is er genoeg ruimte in de Inventory? 
        // Past het Item? 
        // Zet Item in de Dictionary 
        // Return true/false voor succes/mislukt 
        return false;
    }
    public Item Get(string itemName)
    {
        // TODO implementeer: 
        // Zoek Item in de Dictionary 
        // Verwijder Item uit Dictionary (als gevonden)
        // Return Item of null 
        return null;
    }
    private int CurrentWeight()
    {
        // TODO implementeer: 
        // Bereken het totale gewicht van alle Items in de Inventory
        int totalWeight = 0;
        items.Values.ToList().ForEach(item => totalWeight += item.Weight);
        return totalWeight;
    }
    private bool CanFit(Item item)
    {
        // TODO implementeer: 
        // Check of het Item past in de Inventory
        if (item == null) return false;
        if (item.Weight <= maxWeight) return true;
        else
        {
            return false;
        }
    }
    private bool HasSpaceFor(Item item)
    {
        // TODO implementeer: 
        // Check of er genoeg ruimte is voor het Item 
        if (item == null) return false;
        if (item.Weight + CurrentWeight() <= maxWeight) return true;
        else
        {
            return false;
        }
    }
    private bool ItemExists(string itemName)
    {
        // TODO implementeer: 
        // Check of het Item al in de Inventory zit
        if (itemName == null) return false;
        itemName = itemName.Trim().ToLower();
        return items.ContainsKey(itemName);
    }
    private void AddItem(string itemName, Item item)
    {
        // TODO implementeer: 
        // Voeg het Item toe aan de Inventory
        if (itemName == null || item == null) return;
        itemName = itemName.Trim().ToLower();
        items[itemName] = item;
    }
} 