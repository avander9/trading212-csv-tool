using System.Globalization;
using Trading212Tools.Models;

namespace Trading212Tools.Services;

public class CSVParserService
{
    public List<InputLine> ParseFile(string file)
    {
        var lines = File.ReadAllLines(file).ToList();

        lines.RemoveAt(0);

        var linesParsed = new List<InputLine>();

        foreach (var line in lines)
        {
            var splitedLine = line.Split(',');

            var inputLine = new InputLine.Builder()
                .WithAction(splitedLine[0])
                .WithTime(DateTime.Parse(splitedLine[1]))
                .WithIsin(splitedLine[2])
                .WithTicker(splitedLine[3])
                .WithName(splitedLine[4])
                .WithNumberOfShares(float.Parse(splitedLine[5],  CultureInfo.InvariantCulture))
                .WithPrice(ParseDecimal(splitedLine[6]))
                .WithPriceCurrency(splitedLine[7])
                .WithTotal(ParseDecimal(splitedLine[9]))
                .WithWithholdingTax(ParseDecimal(splitedLine[10]))
                .WithWithholdingTaxCurrency(splitedLine[11])
                .Build();

            linesParsed.Add(inputLine);
        }

        return linesParsed;
    }

    private static decimal ParseDecimal(string value)
    {
        return decimal.Parse(value,  CultureInfo.InvariantCulture);
    }
}