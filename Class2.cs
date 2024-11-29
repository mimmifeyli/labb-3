public class MoldRiskService
{
    // Metod för att beräkna mögelrisken
    public double CalculateMoldRisk(double temperature, double humidity)
    {
        // En enkel formel för att beräkna mögelrisken
        if (humidity > 80 && temperature < 20)
        {
            return 1.0;  // Hög mögelrisk
        }
        else if (humidity > 60 && temperature < 18)
        {
            return 0.75; // Medelhög mögelrisk
        }
        else
        {
            return 0.0;  // Låg mögelrisk
        }
    }
}
