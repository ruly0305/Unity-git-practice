using NUnit.Framework;

public class CsharpPracticeTest
{
    [Test(Description = "測試兩個數字相加")]
    [TestCase(2 , 2 , 4)]
    [TestCase(-1,3,2)]
    [TestCase(-1,-3,-4)]
    public void Add_Two_Number(int a, int b, int expected)
    {
        CsharpPractice csharpPractice = new CsharpPractice();

        var result = csharpPractice.Add(a,b);

        Assert.AreEqual(expected,result);
    }
}