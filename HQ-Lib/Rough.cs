namespace HQ_Lib;

public class Rough : Heroes, IPrintReport
{
    public string PlayerName {get; set;} = string.Empty;
    public bool SpellCaster { get; set; } = false;


    public Rough() : base()
    {
        CharacterName = "Rough";
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
