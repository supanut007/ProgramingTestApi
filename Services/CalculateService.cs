using CalcurateApi.Models;
using CalcurateApi.Services.Interfaces;

namespace CalcurateApi.Services;

public class CalculateService : ICalculateService
{
    public PrimeNumberResponse CheckPrime(int number)
    {
        var isPrime = IsPrime(number);

        return new PrimeNumberResponse
        {
            Number = number,
            IsPrime = isPrime,
            Message = isPrime
                ? $"{number} is a prime number"
                : $"{number} is not a prime number"
        };
    }

    private bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}