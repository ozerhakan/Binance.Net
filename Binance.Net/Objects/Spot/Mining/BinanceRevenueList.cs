﻿using System;
using System.Collections.Generic;
using Binance.Net.Converters;
using Binance.Net.Enums;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Binance.Net.Objects.Spot.Mining
{
    /// <summary>
    /// Revenue list
    /// </summary>
    public class BinanceRevenueList
    {
        /// <summary>
        /// Total number of results
        /// </summary>
        public int TotalNum { get; set; }
        /// <summary>
        /// Page size
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// Revenue items
        /// </summary>
        public IEnumerable<BinanceRevenueItem> AccountProfits { get; set; } = Array.Empty<BinanceRevenueItem>();
    }

    /// <summary>
    /// Revenue
    /// </summary>
    public class BinanceRevenueItem
    {
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime Time { get; set; }
        /// <summary>
        /// Coin
        /// </summary>
        [JsonProperty("coinName")]
        public string Coin { get; set; } = string.Empty;
        /// <summary>
        /// Earning type
        /// </summary>
        [JsonConverter(typeof(BinanceEarningTypeConverter))]
        public BinanceEarningType Type { get; set; }
        /// <summary>
        /// Day hashrate
        /// </summary>
        public decimal DayHashRate { get; set; }
        /// <summary>
        /// Profit amount
        /// </summary>
        public decimal ProfitAmount { get; set; }
        /// <summary>
        /// Hash transfer
        /// </summary>
        public decimal HashTransfer { get; set; }
        /// <summary>
        /// Transfer amount
        /// </summary>
        public decimal TransferAmount { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public MinerStatus Status { get; set; }
    }
}
