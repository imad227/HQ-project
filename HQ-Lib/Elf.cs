namespace HQ_Lib;

public class Elf : Heroes
{
    public string PlayerName {get; set;} = string.Empty;
    public bool SpelCaster { get; set; } = true;

    public Elf() : base()
    {
        CharacterName = "Elf";
        Attack = 2;
        Defence = 2;
        MaxBody = 6;
        MaxMind = 4;
        CurrentBody = MaxBody;
        CurrentMind = MaxMind;
    }
}
