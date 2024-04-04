using HQ_Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HQ_Test;

[TestClass]
public class ElfTest
{
    [TestMethod]
    public void ElfTestName()
    {
        string name = "Elf";
        Elf elf = new();
        Assert.IsTrue(elf.SpelCaster);
        Assert.AreEqual(elf.CharacterName,name);
    }
}
