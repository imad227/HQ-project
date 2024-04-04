using Microsoft.VisualStudio.TestTools.UnitTesting;
using HQ_Lib;

namespace HQ_Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        // -- Arrange
        Heroes testhero = new();
        // -- Test
        Wizard wiz = new Wizard();
        // -- Assert
        Assert.AreNotEqual(wiz.CharacterName,"");
    }
}