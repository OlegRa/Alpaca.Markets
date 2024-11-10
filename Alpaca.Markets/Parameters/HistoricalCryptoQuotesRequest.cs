﻿namespace Alpaca.Markets;

/// <summary>
/// Encapsulates request parameters for
/// <see cref="IHistoricalQuotesClient{TRequest}.ListHistoricalQuotesAsync(TRequest,CancellationToken)"/> and
/// <see cref="IHistoricalQuotesClient{TRequest}.GetHistoricalQuotesAsync(TRequest,CancellationToken)"/> calls.
/// </summary>
[UsedImplicitly]
public sealed class HistoricalCryptoQuotesRequest : HistoricalRequestBase, IHistoricalRequest<HistoricalCryptoQuotesRequest, IQuote>
{
    /// <summary>
    /// Creates new instance of <see cref="HistoricalCryptoQuotesRequest"/> object.
    /// </summary>
    /// <param name="symbol">Asset symbol for data retrieval.</param>
    /// <param name="from">Filter data equal to or after this time.</param>
    /// <param name="into">Filter data equal to or before this time.</param>
    /// <exception cref="ArgumentNullException">
    /// The <paramref name="symbol"/> argument is <c>null</c>.
    /// </exception>
    public HistoricalCryptoQuotesRequest(
        String symbol,
        DateTime from,
        DateTime into)
        : this([symbol.EnsureNotNull()], from, into)
    {
    }

    /// <summary>
    /// Creates new instance of <see cref="HistoricalCryptoQuotesRequest"/> object.
    /// </summary>
    /// <param name="symbol">Asset symbol for data retrieval.</param>
    /// <param name="timeInterval">Inclusive time interval for filtering items in response.</param>
    /// <exception cref="ArgumentNullException">
    /// The <paramref name="symbol"/> argument is <c>null</c>.
    /// </exception>
    public HistoricalCryptoQuotesRequest(
        String symbol,
        Interval<DateTime> timeInterval)
        : this([symbol.EnsureNotNull()], timeInterval)
    {
    }

    /// <summary>
    /// Creates new instance of <see cref="HistoricalCryptoQuotesRequest"/> object.
    /// </summary>
    /// <param name="symbol">Asset symbol for data retrieval.</param>
    /// <exception cref="ArgumentNullException">
    /// The <paramref name="symbol"/> argument is <c>null</c>.
    /// </exception>
    public HistoricalCryptoQuotesRequest(
        String symbol)
        : this([symbol.EnsureNotNull()])
    {
    }

    /// <summary>
    /// Creates new instance of <see cref="HistoricalCryptoQuotesRequest"/> object.
    /// </summary>
    /// <param name="symbols">Asset symbols for data retrieval.</param>
    /// <param name="from">Filter data equal to or after this time.</param>
    /// <param name="into">Filter data equal to or before this time.</param>
    /// <exception cref="ArgumentNullException">
    /// The <paramref name="symbols"/> argument is <c>null</c>.
    /// </exception>
    public HistoricalCryptoQuotesRequest(
        IEnumerable<String> symbols,
        DateTime from,
        DateTime into)
        : base(symbols.EnsureNotNull(), from, into)
    {
    }

    /// <summary>
    /// Creates new instance of <see cref="HistoricalCryptoQuotesRequest"/> object.
    /// </summary>
    /// <param name="symbols">Asset symbols for data retrieval.</param>
    /// <param name="timeInterval">Inclusive time interval for filtering items in response.</param>
    /// <exception cref="ArgumentNullException">
    /// The <paramref name="symbols"/> argument is <c>null</c>.
    /// </exception>
    public HistoricalCryptoQuotesRequest(
        IEnumerable<String> symbols,
        Interval<DateTime> timeInterval)
        : base(symbols.EnsureNotNull(), timeInterval)
    {
    }

    /// <summary>
    /// Creates new instance of <see cref="HistoricalCryptoQuotesRequest"/> object.
    /// </summary>
    /// <param name="symbols">Asset symbols for data retrieval.</param>
    /// <exception cref="ArgumentNullException">
    /// The <paramref name="symbols"/> argument is <c>null</c>.
    /// </exception>
    public HistoricalCryptoQuotesRequest(
        IEnumerable<String> symbols)
        : base(symbols.EnsureNotNull(), new Interval<DateTime>())
    {
    }

    /// <summary>
    /// Creates new instance of <see cref="HistoricalCryptoQuotesRequest"/> object.
    /// </summary>
    /// <param name="symbol">Asset symbol for data retrieval.</param>
    /// <param name="timeInterval">Inclusive time interval for filtering items in response.</param>
    /// <exception cref="ArgumentNullException">
    /// The <paramref name="symbol"/> argument is <c>null</c>.
    /// </exception>
    [ExcludeFromCodeCoverage]
    [Obsolete("Use constructor with Interval<DateTime> argument instead of this one.", true)]
    public HistoricalCryptoQuotesRequest(
        String symbol,
        IInclusiveTimeInterval timeInterval)
        : this([symbol.EnsureNotNull()], timeInterval)
    {
    }

    /// <summary>
    /// Creates new instance of <see cref="HistoricalCryptoQuotesRequest"/> object.
    /// </summary>
    /// <param name="symbols">Asset symbols for data retrieval.</param>
    /// <param name="timeInterval">Inclusive time interval for filtering items in response.</param>
    /// <exception cref="ArgumentNullException">
    /// The <paramref name="symbols"/> argument is <c>null</c>.
    /// </exception>
    [ExcludeFromCodeCoverage]
    [Obsolete("Use constructor with Interval<DateTime> argument instead of this one.", true)]
    public HistoricalCryptoQuotesRequest(
        IEnumerable<String> symbols,
        IInclusiveTimeInterval timeInterval)
        : base(symbols.EnsureNotNull(), timeInterval)
    {
    }

    /// <summary>
    /// Creates new instance of <see cref="HistoricalCryptoQuotesRequest"/> object
    /// with the updated <see cref="Exchanges"/> list.
    /// </summary>
    /// <param name="exchanges">Crypto exchanges to add into the list.</param>
    /// <exception cref="ArgumentNullException">
    /// The <paramref name="exchanges"/> argument is <c>null</c>.
    /// </exception>
    /// <returns>The new instance of the <see cref="HistoricalCryptoQuotesRequest"/> object.</returns>
    [UsedImplicitly]
    [ExcludeFromCodeCoverage]
    [Obsolete("This method will be removed in the next major release.", true)]
    public HistoricalCryptoQuotesRequest WithExchanges(
        IEnumerable<CryptoExchange> exchanges) => this;

    /// <summary>
    /// Creates new instance of <see cref="HistoricalCryptoQuotesRequest"/> object
    /// with the updated <see cref="Exchanges"/> list.
    /// </summary>
    /// <param name="exchanges">Crypto exchanges to add into the list.</param>
    /// <exception cref="ArgumentNullException">
    /// The <paramref name="exchanges"/> argument is <c>null</c>.
    /// </exception>
    /// <returns>The new instance of the <see cref="HistoricalCryptoQuotesRequest"/> object.</returns>
    [UsedImplicitly]
    [ExcludeFromCodeCoverage]
    [Obsolete("This method will be removed in the next major release.", true)]
    public HistoricalCryptoQuotesRequest WithExchanges(
        params CryptoExchange[] exchanges) => this;

    /// <summary>
    /// Gets crypto exchanges list for data retrieval (empty list means 'all exchanges').
    /// </summary>
    [UsedImplicitly]
    [ExcludeFromCodeCoverage]
    [Obsolete("This property is not supported by API anymore and will be removed in the next major release.", true)]
    public IReadOnlyCollection<CryptoExchange> Exchanges => Array.Empty<CryptoExchange>();

    /// <inheritdoc />
    internal override Boolean HasSingleSymbol => false;

    /// <inheritdoc />
    protected override String LastPathSegment => "quotes";

    HistoricalCryptoQuotesRequest IHistoricalRequest<HistoricalCryptoQuotesRequest, IQuote>.GetValidatedRequestWithoutPageToken() =>
        new HistoricalCryptoQuotesRequest(Symbols, TimeInterval)
            {
                SortDirection = SortDirection
            }
            .WithPageSize(this.GetPageSize());
}
