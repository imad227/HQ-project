namespace HQ_Lib;

public class Elf : Heroes, IPrintReport
{
    public string PlayerName {get; set;} = string.Empty;
    public bool SpellCaster { get; set; } = true;

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

    public override bool EquibtItem(Item i)
    {
        return base.EquibtItem(i);
    }

    public string Report()
    {
        string s = string.Empty;
        s += PlayerName + " " + (SpellCaster? "Is a Spellcaster": "") + "\n";
        return s;
    }
}
