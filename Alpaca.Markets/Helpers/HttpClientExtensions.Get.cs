﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Alpaca.Markets
{
    internal static partial class HttpClientExtensions
    {
        public static Task<TApi> GetAsync<TApi, TJson>(
            this HttpClient httpClient,
            UriBuilder uriBuilder,
            CancellationToken cancellationToken,
            IThrottler? throttler = null)
            where TJson : TApi =>
            callAndDeserializeAsync<TApi, TJson>(
                httpClient, HttpMethod.Get, uriBuilder.Uri, cancellationToken, throttler);

        public static Task<TApi> GetAsync<TApi, TJson>(
            this HttpClient httpClient,
            String endpointUri,
            CancellationToken cancellationToken,
            IThrottler? throttler = null)
            where TJson : TApi =>
            callAndDeserializeAsync<TApi, TJson>(
                httpClient, HttpMethod.Get, asUri(endpointUri), cancellationToken, throttler);

        public static async Task<IReadOnlyDictionary<TKeyApi, TValueApi>> GetAsync
            <TKeyApi, TValueApi, TKeyJson, TValueJson>(
                this HttpClient httpClient,
                UriBuilder uriBuilder,
                IEqualityComparer<TKeyApi> comparer,
                Func<KeyValuePair<TKeyJson, TValueJson>, TValueApi> elementSelector,
                CancellationToken cancellationToken,
                IThrottler? throttler = null)
            where TKeyApi : notnull
            where TKeyJson : TKeyApi
            where TValueJson : TValueApi
        {
            var response = await httpClient
                .GetAsync<Dictionary<TKeyJson, TValueJson>, Dictionary<TKeyJson, TValueJson>>(
                    uriBuilder, cancellationToken, throttler)
                .ConfigureAwait(false);

            return response
                .Where(_ => _.Value is not null)
                .ToDictionary(_ => _.Key, elementSelector, comparer);
        }
    }
}
