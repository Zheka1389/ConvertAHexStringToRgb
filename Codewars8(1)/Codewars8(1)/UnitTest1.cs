
using NUnit.Framework;

namespace Codewars8_1_
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("#FFFFFF", ExpectedResult = "r:255, g:255, b:255")]
        [TestCase("#7b2b22", ExpectedResult = "r:123, g:43, b:34")]
        [TestCase("#6739f5", ExpectedResult = "r:103, g:57, b:245")]
        public static string StringToRGB(string str) => ConvertToRGB.StringToRGB(str);

    }
}
