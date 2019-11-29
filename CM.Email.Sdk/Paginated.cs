namespace CM.Email.Sdk
{
    /// <summary>
    /// Container for a paginated result set
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Paginated<T>
    {
        /// <summary>
        /// The returned items of type T
        /// </summary>
        public T[] Items { get; }

        /// <summary>
        /// The amount of items that have been skipped
        /// </summary>
        public int Skip { get; }

        /// <summary>
        /// The amount of items that have been taken
        /// </summary>
        public int Take { get; }

        /// <summary>
        /// The total amount of items that are retrievable
        /// </summary>
        public int Total { get; }

        public Paginated(T[] items, int skip, int take, int total)
        {
            Items = items;
            Skip = skip;
            Take = take;
            Total = total;
        }
    }
}
