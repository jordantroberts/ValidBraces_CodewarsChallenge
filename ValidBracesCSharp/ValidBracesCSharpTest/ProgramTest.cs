using System;
using System.Collections;
using NUnit.Framework;

[TestFixture]
public class BraceTests
{

    [Test]
    public void Test1()
    {
        Assert.AreEqual(true, Brace.validBraces("()"));
    }
    [Test]
    public void Test2()
    {
        Assert.AreEqual(false, Brace.validBraces("[(])"));
    }
  
}
