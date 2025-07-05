using Xunit;
using PalindromeChecker;

public class PalindromeValidatorTests
{
    [Fact]
    public void Test_Palindromo_Clasico()
    {
        Assert.True(PalindromeValidator.EsPalindromo("A man a plan a canal Panama"));
    }

    [Fact]
    public void Test_No_Es_Palindromo()
    {
        Assert.False(PalindromeValidator.EsPalindromo("Hello world"));
    }

    [Fact]
    public void Test_Cadena_Vacia_Lanza_Error()
    {
        Assert.Throws<System.ArgumentException>(() => PalindromeValidator.EsPalindromo(""));
    }

    [Fact]
    public void Test_Null_Lanza_Error()
    {
        Assert.Throws<System.ArgumentNullException>(() => PalindromeValidator.EsPalindromo(null));
    }
}
