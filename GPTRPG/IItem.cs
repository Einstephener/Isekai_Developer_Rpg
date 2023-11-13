public interface IItem
{
    bool IsEquipped { get; set; }
    int ItemAtk { get; }
    int ItemDef { get; }
    string ItemDescription { get; set; }
    int ItemGold { get; }
    string ItemName { get; }
}