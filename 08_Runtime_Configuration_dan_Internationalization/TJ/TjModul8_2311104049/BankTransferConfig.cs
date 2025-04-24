using System.Text.Json;
using System.IO;
using System.Collections.Generic;

public class BankTransferConfig
{
    public string lang { get; set; } = "en";
    public Transfer transfer { get; set; } = new Transfer();
    public List<string> methods { get; set; } = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
    public Confirmation confirmation { get; set; } = new Confirmation();

    public class Transfer
    {
        public int threshold { get; set; } = 25000000;
        public int low_fee { get; set; } = 6500;
        public int high_fee { get; set; } = 15000;
    }

    public class Confirmation
    {
        public string en { get; set; } = "yes";
        public string id { get; set; } = "ya";
    }

    public static BankTransferConfig LoadConfig()
    {
        string fileName = "bank_transfer_config.json";
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            var config = JsonSerializer.Deserialize<BankTransferConfig>(json);
            return config ?? new BankTransferConfig();
        }
        return new BankTransferConfig();
    }
}
