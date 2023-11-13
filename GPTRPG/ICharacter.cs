public interface ICharacter
{
    int Atk { get; }
    int Def { get; }
    int Gold { get; set; }
    int Hp { get; set; }
    List<Item> Inventory { get; }
    string Job { get; }
    int Level { get; }
    string Name { get; }

    void AddToInventory(Item item);
    void EquipItem(int input);
}