using HQ_Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HQ_Test;


[TestClass]
public class TestArmory
{
    [TestMethod]
    public void AddDaggerTest()
    {
        var dagger = new Dagger();
        var wizard = new Wizard();
        var barbie = new Barbarian();

        var test1 = wizard.AddWeapon(dagger);
        var test2 = wizard.TransferWeapon(barbie, dagger);
        var test3 = wizard.TransferWeapon(barbie, dagger);

        Assert.IsTrue(test1);
        Assert.IsTrue(test2);
        Assert.IsFalse(test3);
    }
}
