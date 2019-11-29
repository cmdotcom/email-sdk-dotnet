using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using JetBrains.Annotations;

namespace CM.Email.Sdk
{
    /// <summary>
    /// Helper class to compose a url with optional query string parameters.
    /// </summary>
    [PublicAPI]
    public sealed class QueryStringBuilder
    {
        private string _result;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryStringBuilder" /> class.
        /// A specified uri will be the start of the resulting query.
        /// </summary>
        /// <param name="uri">An optional URI to start the resulting query.</param>
        public QueryStringBuilder([CanBeNull] string uri = "")
        {
            this._result = uri ?? "";
        }

        /// <summary>
        /// Adds the specified key and value to the query string.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Key is null or empty</exception>
        public QueryStringBuilder Add([NotNull] string key, [CanBeNull] object value)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Key is null or empty", nameof(key));

            if (value == null)
                return this;

            this._result += this._result.Contains("?") ? "&" : "?";
            this._result += $"{key}={HttpUtility.UrlEncode(Convert.ToString(value, CultureInfo.InvariantCulture))}";

            return this;
        }

        /// <summary>
        /// Adds the specified key for each of the strings in the source.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="source">The value strings source.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Key is null or empty</exception>
        public QueryStringBuilder AddRange([NotNull] string key, [CanBeNull] IEnumerable source)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Key is null or empty", nameof(key));

            if (source == null)
                return this;

            foreach (var value in source)
            {
                if (value != null)
                    this.Add(key, value);
            }

            return this;
        }

        /// <summary>
        /// Adds the specified key for each of the sources.
        /// The transform function will be called for each item in sources.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key to add repeatedly.</param>
        /// <param name="source">The source to get items from.</param>
        /// <param name="transform">The transform function to apply to each item. If the result is null, the item will be skipped.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Key is null or empty</exception>
        public QueryStringBuilder AddRange<T>(
            [NotNull] string key,
            [CanBeNull] IEnumerable<T> source,
            [NotNull] Func<T, object> transform)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Key is null or empty", nameof(key));
            if (transform == null)
                throw new ArgumentNullException(nameof(transform));
            if (source == null)
                return this;

            this.Add(key, source.Select(transform).Where(value => value != null));

            return this;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="QueryStringBuilder" /> to the resulting query string.
        /// </summary>
        /// <param name="builder">The builder to convert.</param>
        /// <returns>
        /// The resulting query string.
        /// </returns>
        public static implicit operator string(QueryStringBuilder builder)
        {
            return builder.ToString();
        }

        /// <summary>
        /// Returns the resulting query string.
        /// </summary>
        /// <returns>
        /// The resulting query string.
        /// </returns>
        public override string ToString()
        {
            return this._result;
        }
    }
}
