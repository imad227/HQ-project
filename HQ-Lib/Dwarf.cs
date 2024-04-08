namespace HQ_Lib;

public class Dwarf : Heroes, IPrintReport
{
    public string PlayerName {get; set;} = string.Empty;
    public bool SpellCaster { get; set; } = false;

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

        public override bool EquibtItem(Item i)
    {
        if(i.IsSpell)
        {
            if(!SpellCaster)
            {
                return false;
            }
        }
        return base.EquibtItem(i);
    }

    public string Report()
    {
        string s = string.Empty;
        s += PlayerName + " " + (SpellCaster? "Is a Spellcaster": "") + "\n";
        return s;
    }
}
