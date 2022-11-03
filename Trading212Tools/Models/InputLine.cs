using Newtonsoft.Json;
using Trading212Tools.Constants;

namespace Trading212Tools.Models;

public class InputLine
{
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }
    [JsonProperty(PropertyName = "partitionKey")]
    public string PartitionKey { get; set; }
    public string Action { get; private init; }
    public DateTime Time { get; private init; }
    public string ISIN { get; private init; }
    public string Ticker { get; private init; }
    public string Name { get; private init; }
    public float NumberOfShares { get; private init; }
    public decimal Price { get; private init; }
    public string PriceCurrency { get; private init; }
    public decimal ExchangeRate { get; private init; }
    public decimal Total { get; private init; }
    public decimal WithholdingTax { get; private init; }
    public string WithholdingTaxCurrency { get; private init; }
    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }

    public class Builder
    {
        private string _action;
        private DateTime _time;
        private string _isin;
        private string _ticker;
        private string _name;
        private float _numberOfShares;
        private decimal _price;
        private string _priceCurrency;
        private decimal _exchangeRate;
        private decimal _total;
        private decimal _withholdingTax;
        private string _withholdingTaxCurrency;

        public Builder WithAction(string value)
        {
            _action = value;
            return this;
        }

        public Builder WithTime(DateTime value)
        {
            _time = value;
            return this;
        }

        public Builder WithIsin(string value)
        {
            _isin = value;
            return this;
        }

        public Builder WithTicker(string value)
        {
            _ticker = value;
            return this;
        }

        public Builder WithName(string value)
        {
            _name = value;
            return this;
        }

        public Builder WithNumberOfShares(float value)
        {
            _numberOfShares = value;
            return this;
        }

        public Builder WithPrice(decimal value)
        {
            _price = value;
            return this;
        }

        public Builder WithPriceCurrency(string value)
        {
            _priceCurrency = value;
            return this;
        }

        public Builder WithExchangeRate(decimal value)
        {
            _exchangeRate = value;
            return this;
        }

        public Builder WithTotal(decimal value)
        {
            _total = value;
            return this;
        }

        public Builder WithWithholdingTax(decimal value)
        {
            _withholdingTax = value;
            return this;
        }

        public Builder WithWithholdingTaxCurrency(string value)
        {
            _withholdingTaxCurrency = value;
            return this;
        }

        public InputLine Build()
        {
            var inputLine = new InputLine
            {
                Id = $"{_time.Ticks}{_isin}{_ticker}",
                PartitionKey = Trading212Constants.PrimaryKey,
                Action = _action,
                Time = _time,
                ISIN = _isin,
                Ticker = _ticker,
                Name = _name,
                NumberOfShares = _numberOfShares,
                Price = _price,
                PriceCurrency = _priceCurrency,
                ExchangeRate = _exchangeRate,
                Total = _total,
                WithholdingTax = _withholdingTax,
                WithholdingTaxCurrency = _withholdingTaxCurrency
            };

            return inputLine;
        }

    }
}