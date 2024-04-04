namespace HQ_Lib;

public class Barbarian : Heroes
{
    public string PlayerName {get; set;} = string.Empty;
    public bool SpelCaster { get; set; } = false;

    public Barbarian() : base()
    {
        CharacterName = "Barbarian";
        Attack = 3;
        Defence = 2;
        MaxBody = 8;
        CurrentBody = MaxBody;
        MaxMind = 2;
        CurrentMind = MaxMind;
        Gold = 0;
    }
}
