using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

namespace AWSLambdaTest.Tests;

public class FunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {

        // Invoke the lambda function and confirm the string was upper cased.
        var function = new Function();
        var context = new TestLambdaContext();
        var upperCase = function.FunctionHandler("hello world", context);

        Assert.Equal("HELLO WORLD", upperCase);


    }

    [Fact]
    public void TestPermute()
    {
        var function = new Function();
        var context = new TestLambdaContext();
        var result = function.MainPermuteFunction(3,2,context);

        Assert.Equal("Permute", result);
    }
}
