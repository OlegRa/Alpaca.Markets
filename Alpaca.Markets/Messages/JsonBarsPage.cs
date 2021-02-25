﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Alpaca.Markets
{
    [SuppressMessage(
        "Microsoft.Performance", "CA1812:Avoid uninstantiated internal classes",
        Justification = "Object instances of this class will be created by Newtonsoft.JSON library.")]
    internal sealed class JsonBarsPage : IPage<IAgg>
    {
        [JsonProperty(PropertyName = "bars", Required = Required.Always)]
        public List<JsonAlpacaBar> Bars { get; set; } = new List<JsonAlpacaBar>();

        [JsonProperty(PropertyName = "symbol", Required = Required.Always)]
        public String Symbol { get; set; } = String.Empty;

        [JsonProperty(PropertyName = "next_page_token", Required = Required.Always)]
        public String? NextPageToken { get; set; }

        [JsonIgnore]
        public IReadOnlyList<IAgg> Items => Bars.EmptyIfNull();
    }
}