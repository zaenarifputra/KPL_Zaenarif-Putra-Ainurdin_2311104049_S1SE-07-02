using System;

class Program
{
    static void Main(string[] args)
    {
        var config = BankTransferConfig.LoadConfig();
        string lang = config.lang;

        // Step 1: Input Amount
        Console.WriteLine(lang == "en"
            ? "Please insert the amount of money to transfer:"
            : "Masukkan jumlah uang yang akan di-transfer:");

        string? inputAmount = Console.ReadLine();
        if (!int.TryParse(inputAmount, out int amount))
        {
            Console.WriteLine("Invalid amount input.");
            return;
        }

        // Step 2: Calculate Fee & Total
        int fee = amount <= config.transfer.threshold
            ? config.transfer.low_fee
            : config.transfer.high_fee;
        int total = amount + fee;

        if (lang == "en")
        {
            Console.WriteLine($"Transfer fee = {fee}");
            Console.WriteLine($"Total amount = {total}");
        }
        else
        {
            Console.WriteLine($"Biaya transfer = {fee}");
            Console.WriteLine($"Total biaya = {total}");
        }

        // Step 3: Show transfer methods
        Console.WriteLine(lang == "en" ? "Select transfer method:" : "Pilih metode transfer:");
        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        // Step 4: Confirm transaction
        Console.WriteLine();
        Console.WriteLine(lang == "en"
            ? $"Please type \"{config.confirmation.en}\" to confirm the transaction:"
            : $"Ketik \"{config.confirmation.id}\" untuk mengkonfirmasi transaksi:");

        string? confirmInput = Console.ReadLine();
        bool confirmed = (lang == "en" && confirmInput == config.confirmation.en) ||
                         (lang == "id" && confirmInput == config.confirmation.id);

        Console.WriteLine();
        if (confirmed)
        {
            Console.WriteLine(lang == "en"
                ? "The transfer is completed"
                : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(lang == "en"
                ? "Transfer is cancelled"
                : "Transfer dibatalkan");
        }
    }
}
