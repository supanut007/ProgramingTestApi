using CalcurateApi.Models;

namespace CalcurateApi.Services.Interfaces;

public interface ICalculateService
{
    PrimeNumberResponse CheckPrime(int number);
}