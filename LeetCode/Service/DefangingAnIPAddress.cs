namespace LeetCode.Service;

public class DefangingAnIPAddress
{
    public string DefangIPaddress(string address) 
        => address.Replace(".", "[.]");
}
    