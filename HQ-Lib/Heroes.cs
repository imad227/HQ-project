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

    /// <summary>
    /// Increase the Attack of Hero by:
    /// (cannot be negative amount)
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool AddAttack(int item)
    {
        if(item > 0)
        {
            Attack += item;
            return true;
        }
        return false;
    }

    /// <summary>
    /// Increase the Defence of Hero by:
    /// (cannot be negative amount)
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool AddDefence(int item)
    {
        if(item > 0)
        {
            Defence += item;
            return true;
        }
        return false;
    }

    /// <summary>
    /// Increase the Amount of Gold by: 
    /// (cannot be negative amount)
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool AddGold(int item)
    {
        if(item > 0)
        {
            Gold += item;
            return true;
        }
        return false;
    }

    /// <summary>
    /// Transfre Gold to Hero.
    /// </summary>
    /// <param name="H"></param>
    /// <param name="amount"></param>
    /// <returns></returns>
    public bool TransferGold(Heroes H, double amount)
    {
        if(amount > 0 && Gold > amount)
        {
            Gold -= amount;
            H.Gold += amount;
            return true;
        }
        else 
            return false;
    }

        public bool SubtractAttack(int item)
    {
        if(item > 0 && (Attack > item+1))
        {
            Attack -= item;
            return true;
        }
        return false;
    }

    /// <summary>
    /// Decrease the Defence amount.
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool SubtractDefence(int item)
    {
        if(item > 0 && (Defence > item+1))
        {
            Defence -= item;
            return true;
        }
        return false;
    }

    /// <summary>
    /// Remove the specified amount of Gold 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool SubtractGold(int item)
    {
        if(item > 0)
        {
            Gold -= item;
            return true;
        }
        return false;
    }

    /// <summary>
    /// Add a weapon to Hero's Itenary.
    /// </summary>
    /// <param name="w"></param>
    /// <returns></returns>
    public bool AddWeapon(Weapon w)
    {
        weapons.Add(w);
        if(weapons.Contains(w))
            return true;
        return false;
    }

    /// <summary>
    /// Add item to Hero's Itenry
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public bool AddItem(Item i)
    {
        items.Add(i);
        if(items.Contains(i))
            return true;
        return false;
    }

    /// <summary>
    /// Equibt the current weapon.
    /// </summary>
    /// <param name="w"></param>
    /// <returns></returns>
    public bool EquibtWeapon(Weapon w)
    {
        if(weapons.Contains(w))
        {
            if(w.Isequibt == false)
            {
                w.Isequibt = true;
                Attack += w.AttackModifier;
                Defence += w.DefenceModifier;
                CurrentBody += w.BodyModifier;
            }
        }
        return false;
    }

    /// <summary>
    /// Equibt the current item.
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public virtual bool EquibtItem(Item i)
    {
        if(items.Contains(i))
        {
            if(i.Isequibt == false)
            {
                i.Isequibt= true;
                Attack += i.AttackModifier;
                Defence += i.DefenceModifier;
                MaxBody += i.MaxBodyModifier;
                CurrentBody += i.CurrentBodyModifier;
                MaxMind += i.MaxMindModifier;
                CurrentMind += i.CurrentMindModifier;
                Gold += i.GoldModifier;
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// UnEquibt the current weapon.
    /// </summary>
    /// <param name="w"></param>
    /// <returns></returns>
    public bool UnEquibtWeapon(Weapon w)
    {
        if(weapons.Contains(w))
        {
            if(w.Isequibt == true)
            {
                w.Isequibt = false;
                Attack -= w.AttackModifier;
                Defence -= w.DefenceModifier;
                CurrentBody -= w.BodyModifier;
            }
        }
        return false;
    }

    /// <summary>
    /// UnEquibt the current item.
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
        public bool UnEquibtItem(Item i)
    {
        if(items.Contains(i))
        {
            if(i.Isequibt == true)
            {
                i.Isequibt= false;
                Attack -= i.AttackModifier;
                Defence -= i.DefenceModifier;
                MaxBody -= i.MaxBodyModifier;
                CurrentBody -= i.CurrentBodyModifier;
                MaxMind -= i.MaxMindModifier;
                CurrentMind -= i.CurrentMindModifier;
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Transfer the weapon to another Hero.
    /// </summary>
    /// <param name="H"></param>
    /// <param name="w"></param>
    /// <returns></returns>
    public bool TransferWeapon(Heroes H, Weapon w)
    {
        if(!weapons.Contains(w))
            return false;
        else
        {
            if(w.Isequibt)
            UnEquibtWeapon(w);

        weapons.Remove(w);
        H.weapons.Add(w);
        return true;
        }
    }

    /// <summary>
    /// Transfer the item to another Hero.
    /// </summary>
    /// <param name="H"></param>
    /// <param name="i"></param>
    /// <returns></returns>
        public bool TransferItem(Heroes H, Item i)
    {
        if(!items.Contains(i))
            return false;
        else
        {
            if(i.Isequibt)
            UnEquibtItem(i);

        items.Remove(i);
        H.items.Add(i);
        return true;
        }
    }

}


