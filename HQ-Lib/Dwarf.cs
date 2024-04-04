namespace HQ_Lib;

public class Dwarf : Heroes
{
    public string PlayerName {get; set;} = string.Empty;
    public bool SpelCaster { get; set; } = false;

    public Dwarf() : base()
    {
        CharacterName = "Dwarf";
        Attack = 2;
        Defence = 2;
        MaxBody = 7;
        MaxMind = 3;
        CurrentBody = MaxBody;
        CurrentMind = MaxMind;
    }
}
