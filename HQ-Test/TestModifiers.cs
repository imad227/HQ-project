using HQ_Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HQ_Test;

[TestClass()]
public class TestModifiers
{
    [TestMethod]
    public void TestAddAttack()
    {
        var wizard = new Wizard();
        wizard.AddAttack(5);
        Assert.AreEqual(6, wizard.Attack);
    }

    [TestMethod]
    public void TestTransferGoldSucsess()
    {
        var wizard = new Wizard();
        var barbarian = new Barbarian();
        barbarian.AddGold(100);
        var result = barbarian.TransferGold(wizard,50);

        Assert.IsTrue(result);
        Assert.AreEqual(50, barbarian.Gold);
        Assert.AreEqual(50, wizard.Gold);
    }

        [TestMethod]
    public void TestTransferGoldInvalidAmount()
    {
        var wizard = new Wizard();
        var barbarian = new Barbarian();
        barbarian.AddGold(100);
        var result = barbarian.TransferGold(wizard,150);

        Assert.IsFalse(result);
        Assert.AreEqual(100, barbarian.Gold);
        Assert.AreEqual(0, wizard.Gold);
    }

}
