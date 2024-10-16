/*
 * Trade API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: current
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// DEPO position.  Позиция DEPO.
    /// </summary>
    [DataContract(Name = "PositionRow")]
    public partial class PositionRow : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Market
        /// </summary>
        [DataMember(Name = "market", EmitDefaultValue = false)]
        public Market? Market { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PositionRow" /> class.
        /// </summary>
        /// <param name="securityCode">Security Code.  Тикер инструмента..</param>
        /// <param name="market">market.</param>
        /// <param name="balance">Current position, items.  Текущая позиция, шт..</param>
        /// <param name="currentPrice">Current price in price_currency.  Текущая цена в валюте цены инструмента..</param>
        /// <param name="equity">Positions equity.  Оценка позиции по инструменту в валюте риска..</param>
        /// <param name="averagePrice">Balanced price of security in price_currency.  Балансовая цена в валюте цены инструмента..</param>
        /// <param name="currency">Risk currency.  Валюта риска..</param>
        /// <param name="accumulatedProfit">P/L for initial position, in risk currency.  Прибыль/убыток по входящей позиции, в валюте риска..</param>
        /// <param name="todayProfit">Daily P/L, in risk currency.  Прибыль/убыток по сделкам за день, в валюте риска..</param>
        /// <param name="unrealizedProfit">Unrealized P/L, in average_price_currency.  Нереализованные прибыль/убытки по балансовой цене в валюте инструмента..</param>
        /// <param name="profit">P/L in price_currency.  Прибыль/убытки в валюте цены инструмента..</param>
        /// <param name="maxBuy">Max lots to buy.  Максимальное кол-во лотов, доступных для покупки..</param>
        /// <param name="maxSell">Max lots to sell.  Максимальное кол-во лотов, доступных для продажи..</param>
        /// <param name="priceCurrency">Security price currency.  Валюта цены инструмента..</param>
        /// <param name="averagePriceCurrency">Balanced price currency.  Валюта балансовой цены..</param>
        /// <param name="averageRate">Risk Currency to Price currency Cross rate.  Кросс-курс валюты балансовой цены к валюте риска..</param>
        public PositionRow(string securityCode = default(string), Market? market = default(Market?), long balance = default(long), double currentPrice = default(double), double equity = default(double), double averagePrice = default(double), string currency = default(string), double accumulatedProfit = default(double), double todayProfit = default(double), double unrealizedProfit = default(double), double profit = default(double), long maxBuy = default(long), long maxSell = default(long), string priceCurrency = default(string), string averagePriceCurrency = default(string), double averageRate = default(double))
        {
            this.SecurityCode = securityCode;
            this.Market = market;
            this.Balance = balance;
            this.CurrentPrice = currentPrice;
            this.Equity = equity;
            this.AveragePrice = averagePrice;
            this.Currency = currency;
            this.AccumulatedProfit = accumulatedProfit;
            this.TodayProfit = todayProfit;
            this.UnrealizedProfit = unrealizedProfit;
            this.Profit = profit;
            this.MaxBuy = maxBuy;
            this.MaxSell = maxSell;
            this.PriceCurrency = priceCurrency;
            this.AveragePriceCurrency = averagePriceCurrency;
            this.AverageRate = averageRate;
        }

        /// <summary>
        /// Security Code.  Тикер инструмента.
        /// </summary>
        /// <value>Security Code.  Тикер инструмента.</value>
        [DataMember(Name = "securityCode", EmitDefaultValue = true)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// Current position, items.  Текущая позиция, шт.
        /// </summary>
        /// <value>Current position, items.  Текущая позиция, шт.</value>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        public long Balance { get; set; }

        /// <summary>
        /// Current price in price_currency.  Текущая цена в валюте цены инструмента.
        /// </summary>
        /// <value>Current price in price_currency.  Текущая цена в валюте цены инструмента.</value>
        [DataMember(Name = "currentPrice", EmitDefaultValue = false)]
        public double CurrentPrice { get; set; }

        /// <summary>
        /// Positions equity.  Оценка позиции по инструменту в валюте риска.
        /// </summary>
        /// <value>Positions equity.  Оценка позиции по инструменту в валюте риска.</value>
        [DataMember(Name = "equity", EmitDefaultValue = false)]
        public double Equity { get; set; }

        /// <summary>
        /// Balanced price of security in price_currency.  Балансовая цена в валюте цены инструмента.
        /// </summary>
        /// <value>Balanced price of security in price_currency.  Балансовая цена в валюте цены инструмента.</value>
        [DataMember(Name = "averagePrice", EmitDefaultValue = false)]
        public double AveragePrice { get; set; }

        /// <summary>
        /// Risk currency.  Валюта риска.
        /// </summary>
        /// <value>Risk currency.  Валюта риска.</value>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// P/L for initial position, in risk currency.  Прибыль/убыток по входящей позиции, в валюте риска.
        /// </summary>
        /// <value>P/L for initial position, in risk currency.  Прибыль/убыток по входящей позиции, в валюте риска.</value>
        [DataMember(Name = "accumulatedProfit", EmitDefaultValue = false)]
        public double AccumulatedProfit { get; set; }

        /// <summary>
        /// Daily P/L, in risk currency.  Прибыль/убыток по сделкам за день, в валюте риска.
        /// </summary>
        /// <value>Daily P/L, in risk currency.  Прибыль/убыток по сделкам за день, в валюте риска.</value>
        [DataMember(Name = "todayProfit", EmitDefaultValue = false)]
        public double TodayProfit { get; set; }

        /// <summary>
        /// Unrealized P/L, in average_price_currency.  Нереализованные прибыль/убытки по балансовой цене в валюте инструмента.
        /// </summary>
        /// <value>Unrealized P/L, in average_price_currency.  Нереализованные прибыль/убытки по балансовой цене в валюте инструмента.</value>
        [DataMember(Name = "unrealizedProfit", EmitDefaultValue = false)]
        public double UnrealizedProfit { get; set; }

        /// <summary>
        /// P/L in price_currency.  Прибыль/убытки в валюте цены инструмента.
        /// </summary>
        /// <value>P/L in price_currency.  Прибыль/убытки в валюте цены инструмента.</value>
        [DataMember(Name = "profit", EmitDefaultValue = false)]
        public double Profit { get; set; }

        /// <summary>
        /// Max lots to buy.  Максимальное кол-во лотов, доступных для покупки.
        /// </summary>
        /// <value>Max lots to buy.  Максимальное кол-во лотов, доступных для покупки.</value>
        [DataMember(Name = "maxBuy", EmitDefaultValue = false)]
        public long MaxBuy { get; set; }

        /// <summary>
        /// Max lots to sell.  Максимальное кол-во лотов, доступных для продажи.
        /// </summary>
        /// <value>Max lots to sell.  Максимальное кол-во лотов, доступных для продажи.</value>
        [DataMember(Name = "maxSell", EmitDefaultValue = false)]
        public long MaxSell { get; set; }

        /// <summary>
        /// Security price currency.  Валюта цены инструмента.
        /// </summary>
        /// <value>Security price currency.  Валюта цены инструмента.</value>
        [DataMember(Name = "priceCurrency", EmitDefaultValue = true)]
        public string PriceCurrency { get; set; }

        /// <summary>
        /// Balanced price currency.  Валюта балансовой цены.
        /// </summary>
        /// <value>Balanced price currency.  Валюта балансовой цены.</value>
        [DataMember(Name = "averagePriceCurrency", EmitDefaultValue = true)]
        public string AveragePriceCurrency { get; set; }

        /// <summary>
        /// Risk Currency to Price currency Cross rate.  Кросс-курс валюты балансовой цены к валюте риска.
        /// </summary>
        /// <value>Risk Currency to Price currency Cross rate.  Кросс-курс валюты балансовой цены к валюте риска.</value>
        [DataMember(Name = "averageRate", EmitDefaultValue = false)]
        public double AverageRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PositionRow {\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  CurrentPrice: ").Append(CurrentPrice).Append("\n");
            sb.Append("  Equity: ").Append(Equity).Append("\n");
            sb.Append("  AveragePrice: ").Append(AveragePrice).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AccumulatedProfit: ").Append(AccumulatedProfit).Append("\n");
            sb.Append("  TodayProfit: ").Append(TodayProfit).Append("\n");
            sb.Append("  UnrealizedProfit: ").Append(UnrealizedProfit).Append("\n");
            sb.Append("  Profit: ").Append(Profit).Append("\n");
            sb.Append("  MaxBuy: ").Append(MaxBuy).Append("\n");
            sb.Append("  MaxSell: ").Append(MaxSell).Append("\n");
            sb.Append("  PriceCurrency: ").Append(PriceCurrency).Append("\n");
            sb.Append("  AveragePriceCurrency: ").Append(AveragePriceCurrency).Append("\n");
            sb.Append("  AverageRate: ").Append(AverageRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
