public class InsuranceService
{
    public double CalculateInsurance(double price, string type)
    {
        double insurance = 0;

        if (price >= 500 && price < 2000)
            insurance = 1000;

        else if (price >= 2000)
            insurance = 2000;

        if (type == "Smartphone" || type == "Laptop")
            insurance += 500;

        return insurance;
    }
}