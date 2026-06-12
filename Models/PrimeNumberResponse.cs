namespace CalcurateApi.Models;

public class PrimeNumberResponse
{
    public int Number { get; set; }

    public bool IsPrime { get; set; }

    public string Message { get; set; } = string.Empty;
}