﻿using MarketDataModules;
using MarketDataModules.Models.Candles;
using Serilog;
using Skender.Stock.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analysis.Signals.Helpers;

namespace Analysis.Signals
{
    public partial class Signal : IndicatorSignalsHelper
    {
        int stochLookbackPeriod = 14;
        int stochSignalPeriod = 3;
        int stochSmoothPeriod = 1;
        int stochanglesCount = 1;

        internal bool StochLongSignal(CandlesList candleList, decimal deltaPrice)
        {
            Log.Information("Start Stoch LongSignal. Figi: " + candleList.Figi);
            List<StochResult> stoch = Mapper.StochData(candleList, deltaPrice, stochLookbackPeriod, stochSignalPeriod, stochSmoothPeriod);
            Log.Information("Oscillator (%K) = " + stoch.Last().Oscillator);
            Log.Information("Signal (%D) = " + stoch.Last().Signal);
            Log.Information("PercentJ = " + stoch.Last().PercentJ);

            Log.Information("PreLast Oscillator (%K) = " + stoch[stoch.Count() - 2].Oscillator);
            Log.Information("PreLast Signal (%D) = " + stoch[stoch.Count() - 2].Signal);
            Log.Information("PreLast PercentJ = " + stoch[stoch.Count() - 2].PercentJ);

            var OscillatorDegreeAverageAngle = StochDegreeAverageAngle(stoch, stochanglesCount, Stoch.Oscillator);
            var SignalDegreeAverageAngle = StochDegreeAverageAngle(stoch, stochanglesCount, Stoch.Signal);
            var PercentJDegreeAverageAngle = StochDegreeAverageAngle(stoch, stochanglesCount, Stoch.PercentJ);

            Log.Information("OscillatorDegreeAverageAngle = " + OscillatorDegreeAverageAngle);
            Log.Information("SignalDegreeAverageAngle = " + SignalDegreeAverageAngle);
            Log.Information("PercentJDegreeAverageAngle = " + PercentJDegreeAverageAngle);


            if (
                OscillatorDegreeAverageAngle > 0
                &&
                SignalDegreeAverageAngle > 0
                &&
                PercentJDegreeAverageAngle > 0
                &&
                stoch.Last().Signal < 80
                &&
                stoch.Last().Signal < stoch.Last().Oscillator
                )
            {

                Log.Information("Stoch = Long - true for: " + candleList.Figi);
                return true;
            }
            else
            {
                Log.Information("Stoch = Long - false for: " + candleList.Figi);
                return false;
            }
        }
        double StochDegreeAverageAngle(List<StochResult> AdlValue, int anglesCount, Stoch line)
        {
            if (line == Stoch.Oscillator)
            {
                List<decimal?> values = AdlValue.Select(na => (decimal?)na.Oscillator).ToList();
                return DeltaDegreeAngle(values, anglesCount);
            }
            else if (line == Stoch.Signal)
            {
                List<decimal?> values = AdlValue.Select(na => (decimal?)na.Signal).ToList();
                return DeltaDegreeAngle(values, anglesCount);
            }
            else 
            {
                List<decimal?> values = AdlValue.Select(na => (decimal?)na.PercentJ).ToList();
                return DeltaDegreeAngle(values, anglesCount);
            }            
        }

        double StochLinearDegreeAverageAngle(List<StochResult> AdlValue, int anglesCount, Stoch line)
        {
            Log.Information("Start StochLinearDegreeAverageAngle");
            List<StochResult> calculatedValues = AdlValue.Skip(AdlValue.Count - (anglesCount + 1)).ToList();
            Log.Information("calculatedValues.count " + calculatedValues.Count);

            if (line == Stoch.Oscillator)
            {
                Log.Information("Stoch Oscillator");
                List<decimal> values = calculatedValues.Select(na => (decimal)na.Oscillator).ToList();
                Log.Information("Stop StochLinearDegreeAverageAngle");
                return LinearAngle(values);
            }
            else if (line == Stoch.Signal)
            {
                Log.Information("Stoch Signal");
                List<decimal> values = calculatedValues.Select(na => (decimal)na.Signal).ToList();
                Log.Information("Stop StochLinearDegreeAverageAngle");
                return LinearAngle(values);
            }
            else
            {
                Log.Information("Stoch PercentJ");
                List<decimal> values = calculatedValues.Select(na => (decimal)na.PercentJ).ToList();
                Log.Information("Stop StochLinearDegreeAverageAngle");
                return LinearAngle(values);
            }

        }

        //internal bool StochFromLongSignal(CandlesList candleList, decimal deltaPrice)
        //{

        //}

        enum Stoch
        {
            Oscillator,
            Signal,
            PercentJ
        }
    }
}
