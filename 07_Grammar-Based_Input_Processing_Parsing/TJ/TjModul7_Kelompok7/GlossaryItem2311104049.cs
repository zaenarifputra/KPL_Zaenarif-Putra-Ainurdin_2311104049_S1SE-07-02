using System;
using System.IO;
using System.Text.Json;

namespace TjModul7_Kelompok7
{
    public class GlossDef
    {
        public string para { get; set; }
        public string[] GlossSeeAlso { get; set; }
    }

    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossList
    {
        public GlossEntry[] GlossEntry { get; set; } // <- sudah jadi array
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class GlossaryItem2311104049
    {
        public Glossary glossary { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_3_2311104049.json");
            GlossaryItem2311104049 glossaryItem = JsonSerializer.Deserialize<GlossaryItem2311104049>(jsonString);

            var entries = glossaryItem.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("GlossEntry List:");
            foreach (var entry in entries)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"ID: {entry.ID}");
                Console.WriteLine($"SortAs: {entry.SortAs}");
                Console.WriteLine($"GlossTerm: {entry.GlossTerm}");
                Console.WriteLine($"Acronym: {entry.Acronym}");
                Console.WriteLine($"Abbrev: {entry.Abbrev}");
                Console.WriteLine($"Definition: {entry.GlossDef.para}");
                Console.WriteLine("See Also: " + string.Join(", ", entry.GlossDef.GlossSeeAlso));
                Console.WriteLine($"See: {entry.GlossSee}");
            }
        }
    }
}
