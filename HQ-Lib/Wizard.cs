namespace HQ_Lib;

public class Wizard : Heroes, IPrintReport
{
    public string PlayerName {get; set;} = string.Empty;
    public bool SpellCaster { get; set; } = true;

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

    public override bool EquibtItem(Item i)
    {
        return base.EquibtItem(i);
    }

        public string Report()
    {
        string s = string.Empty;
        s = $"{CharacterName} (played by: {PlayerName})";
        s += " " + (SpellCaster? "Is a Spellcaster": "") + "\n";
        s += $"Attack: {Attack}\n";
        s += $"Defence: {Defence}\n";
        s += $"MaxBody: {MaxBody}\n";
        s += $"MaxMind: {MaxMind}\n";
        s += $"CurrentBody: {CurrentBody}\n";
        s += $"CurrentMind: {CurrentMind}\n";
        s += $"Holds: {Gold} Oc\n";
        s += $"Has the following Weapons: ";
        foreach (var w in weapons)
        {   
            s += " " + w.Name;
        }
        s += "\n";
        s += $"Has the following Items: ";
        foreach (var i in items)
        {
            s += " " + i.Name;
        }
        s += "\n";

        s += $"Has Equibt the following Weapons: ";
        foreach (var w in weapons)
        {
            if(w.Isequibt)   
                s += " " + w.Name;
        }
        s += "\n";

        s += $"Has Equibt the following Items: ";
        foreach (var i in items)
        {
            s += " " + i.Name;
        }
        s += "\n";

        return s;
    }
}
