using LeetCode.Service;

namespace LeetCodeTest
{
    public class DefangingAnIPAddressTest
    {
        [Fact]
        public void Test1()
        {
            var n = new DefangingAnIPAddress();
            var x = n.DefangIPaddress("1.1.1.1");

            Assert.Equal("1[.]1[.]1[.]1", x);
        }
    }
}