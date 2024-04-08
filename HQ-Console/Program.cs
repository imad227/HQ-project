// See https://aka.ms/new-console-template for more information
using HQ_Lib;

Console.WriteLine("Hello, to the Hero Quest World!");

var dag1 = new Dagger();
var dag2 = new Dagger();

var wizard = new Wizard();
wizard.CharacterName = "Ged";
wizard.PlayerName = "Hamid";

wizard.AddWeapon(dag1);
wizard.AddWeapon(dag2);

wizard.EquibtWeapon(dag2);
System.Console.WriteLine(wizard.Report());

var barb = new Barbarian();
barb.CharacterName = "BarbaJohn";
barb.PlayerName = "John";

barb.AddGold(1235);

wizard.TransferWeapon(barb, dag1);
wizard.TransferWeapon(barb,dag2);


Console.WriteLine(wizard.Report());
Console.WriteLine(barb.Report());

