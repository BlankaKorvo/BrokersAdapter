﻿using MarketDataModules;
using MarketDataModules.Models.Candles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis.Signals.Helpers
{
    interface ISignal
    {
        bool AdxLongSignal(CandlesList candleList, decimal deltaPrice);
        bool AdxFromLongSignal(CandlesList candleList, decimal deltaPrice);
    }
}
