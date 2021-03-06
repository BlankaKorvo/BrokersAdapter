//using Analysis.TradeDecision;
//using DataCollector;
//using DataCollector.TinkoffAdapter;
//using MarketDataModules;
//using MarketDataModules.Candles;
//using MarketDataModules.Instruments;
//using MarketDataModules.Portfolio;
//using MarketDataModules.Trading;
//using Serilog;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace Trader
//{
//    public class AutoTrading
//    {
//        public CandleInterval CandleInterval { get; set; }
//        public int CandlesCount { get; set; }

//        //TinkoffTrading tinkoffTrading = new TinkoffTrading();
//        //MarketDataCollector marketDataCollector = new MarketDataCollector();
//        public async Task AutoTradingInstruments(InstrumentList instrumentList, int countStocks)
//        {
//            Log.Information("Start AutoTradingInstruments. countStocks = " + countStocks);
//            while (true)
//            {

//                Portfolio portfolio = await MarketDataCollector.GetPortfolioAsync();
//                List<Portfolio.Position> positions = portfolio.Positions;

//                foreach (var item in instrumentList.Instruments)
//                {
//                    Log.Information("Start AutoTradingInstruments Figi: " + item.Figi);
//                    var orderbook = await MarketDataCollector.GetOrderbookAsync(item.Figi, Provider.Tinkoff, 20);

//                    if (orderbook == null)
//                    {
//                        Log.Information("Orderbook null");
//                        Log.Information("Stop AutoTradingInstruments: " + item.Figi);
//                    }
//                    else
//                    {
//                        var candleList = await MarketDataCollector.GetCandlesAsync(item.Figi, CandleInterval, CandlesCount);
//                        Log.Information("candleList.Candles.Count" + candleList.Candles.Count);
//                        var bestAsk = orderbook.Asks.FirstOrDefault().Price;
//                        var bestBid = orderbook.Bids.FirstOrDefault().Price;
//                        int currentLots = CountStoksInPortfolioByFigi(portfolio, item.Figi);

//                        Log.Information("bestAsk: " + bestAsk);
//                        Log.Information("bestBid: " + bestBid);
//                        Log.Information("currentLots: " + currentLots);


//                        TradeTarget tradeTarget = new GmmaDecision(candleList, orderbook).TradeVariant();

//                        Log.Information("tradeTarget: " + tradeTarget + "figi: " + item.Figi);
//                        try
//                        {
//                            if
//                                (
//                                tradeTarget == TradeTarget.toLong
//                                &&
//                                countStocks > currentLots
//                                )
//                            {
//                                await new PostTinkoffTrading()
//                                {
//                                    transactionModel =
//                                    new TransactionModel()
//                                    { Figi = item.Figi, Price = bestAsk, TradeOperation = TradingOperationType.Buy, Quantity = countStocks - currentLots }
//                                }.TransactStoksAsyncs();

//                            }
//                            else if
//                                (
//                                tradeTarget == TradeTarget.fromLong
//                                &&
//                                currentLots > 0
//                                )
//                            {
//                                await new PostTinkoffTrading()
//                                {
//                                    transactionModel =
//                                new TransactionModel() { Figi = item.Figi, Price = bestBid, TradeOperation = TradingOperationType.Sell, Quantity = currentLots }
//                                }.TransactStoksAsyncs();
//                            }
//                            else if
//                                (
//                                tradeTarget == TradeTarget.toShort
//                                &&
//                                0 - countStocks < currentLots
//                                )
//                            {
//                                await new PostTinkoffTrading()
//                                {
//                                    transactionModel =
//                                new TransactionModel() { Figi = item.Figi, Price = bestBid, TradeOperation = TradingOperationType.Sell, Quantity = currentLots + countStocks }
//                                }.TransactStoksAsyncs();
//                            }
//                            else if
//                                (
//                                tradeTarget == TradeTarget.fromShort
//                                &&
//                                currentLots < 0
//                                )
//                            {
//                                await new PostTinkoffTrading()
//                                {
//                                    transactionModel =
//                                new TransactionModel() { Figi = item.Figi, Price = bestAsk, TradeOperation = TradingOperationType.Buy, Quantity = 0 - currentLots }
//                                }.TransactStoksAsyncs();
//                            }
//                            else
//                            {
//                                continue;
//                            }
//                        }
//                        catch (Exception exception)
//                        {
//                            Log.Information(exception.Message);
//                        }
//                    }
//                    Log.Information("Start AutoTradingInstruments Figi: " + item.Figi);
//                }
//            }
//        }

//        private int CountStoksInPortfolioByFigi(Portfolio portfolio, string figi)
//        {
//            var lots = from position in portfolio.Positions
//                       where position.Figi == figi
//                       select position.Lots;

//            return lots.Sum();
//        }

//    }

//}
