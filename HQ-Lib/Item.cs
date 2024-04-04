namespace HQ_Lib;

public class Item
{
    public int Id { get; set; }
    public bool IsSpell {get; set;}
    public string Name { get; set;} = string.Empty;
    public int AttackModifier { get; set; }
    public int DefenceModifier { get; set; }
    public int MaxBodyModifier {get ; set;}
    public int CurrentBodyModifier {get ; set;}
    public int MaxMindModifier { get; set; }
    public int CurrentMindModifier { get; set; }

    public string WeaponDescription { get; set; } = string.Empty;
}
