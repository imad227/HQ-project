namespace HQ_Lib;

public class Rough : Heroes
{
    public string PlayerName {get; set;} = string.Empty;
    public bool SpelCaster { get; set; } = false;


    public Rough() : base()
    {
        CharacterName = "Rough";
    }
}
