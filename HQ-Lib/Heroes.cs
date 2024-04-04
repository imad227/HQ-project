using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace HQ_Lib;
/// <summary>
/// Base Class for Heroes. 
/// name: The name of your character
/// user: The name of the player. Use ~~~ to link to your user page.
/// character: Barbarian, Dwarf, Elf, or Wizard
/// attack: The number of attack dice
/// defend: The number of defend dice
/// body: Starting Body Points for the character.
/// mind: Starting Mind Points for the character.
/// weapon: The weapon your character wields.
/// armor: The armor your character wears.
/// spells: The name the character's spell group(s). Air, Earth, Fire and Water.
/// currbody: Your character's current Body Points.
/// gold: The amount of gold coins your character has.
/// items: Other items your character has.
/// completed: The quests this character has completed.
/// </summary>
public class Heroes
{
    public int Id { get; set; }
    public string CharacterName { get; set; } = string.Empty;
    public int Attack { get; set; }
    public int Defence { get; set; }
    public int MaxBody { get; set; }
    public int MaxMind { get; set; }
    public int CurrentBody { get; set; }
    public int CurrentMind { get; set; }
    public double Gold { get; set; }
    public List<Weapon> weapons { get; set; }
    public List<Item> items { get; set; }

    public Heroes()
    {
        weapons = new List<Weapon>();
        items = new List<Item>();
    }
}


