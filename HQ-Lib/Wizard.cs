namespace HQ_Lib;

public class Wizard : Heroes
{
    public string PlayerName {get; set;} = string.Empty;
    public bool SpelCaster { get; set; } = true;

    public Wizard() : base()
    {
        CharacterName = "Wizard";
        Attack = 1;
        Defence = 2;
        MaxBody = 4;
        MaxMind = 6;
        CurrentBody = MaxBody;
        CurrentMind = MaxMind;
    }
}
