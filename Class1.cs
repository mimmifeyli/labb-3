public class TemperatureData
{
    public DateTime Date { get; set; }
    public double OutdoorTemperature { get; set; }
    public double OutdoorHumidity { get; set; }
    public double IndoorTemperature { get; set; }
    public double IndoorHumidity { get; set; }
    public double MoldRisk { get; set; }  // Du kan lägga till fler egenskaper här beroende på vad som behövs
}
