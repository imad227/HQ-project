namespace HQ_Lib;

public class Weapon
{
    public int Id { get; set; }
    public string Name { get; set;} = string.Empty;
    public int AttackModifier { get; set; }
    public int DefenceModifier { get; set; }
    public int BodyModifier {get ; set;}
    public bool Isequibt { get; set; }
    public double Price {get; protected set;}

    public string WeaponDescription { get; set; } = string.Empty;
}
