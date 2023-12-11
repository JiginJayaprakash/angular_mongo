using webapiproj.Controllers;
namespace Binary.Tests;

public class UnitTest
{
    webapiproj.Controllers.BinaryController b = new webapiproj.Controllers.BinaryController(); 
    [Fact]
    public void Test1()
    {
       string result =  b.IfGood("1100");
       Assert.True(result == "good");
    }
    [Fact]
     public void Test2()
    {
       string result =  b.IfGood("1010");
       Assert.True(result == "good");
    }

    [Fact]
     public void Test3()
    {
       string result =  b.IfGood("101010101010");
       Assert.True(result == "good");
    }

    [Fact]
    public void Test4()
    {
       string result =  b.IfGood("101");
       Assert.True(result == "bad");
    }

    [Fact]
    public void Test5()
    {
       string result =  b.IfGood("1011");
       Assert.True(result == "bad");
    }
}