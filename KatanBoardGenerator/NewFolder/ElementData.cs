namespace KatanBoardGenerator.NewFolder
{
    /// <summary>
    /// Cytscape Node or Edge.
    /// </summary>
    public class ElementData
    {
        /// <summary>
        /// Creates a new instance of <see cref="ElementData"/> for an edge.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="source">The source.</param>
        /// <param name="target">The target.</param>
        public ElementData(string id, string source, string target)
            : this(id)
        {
            Source = source;
            Target = target;
        }

        /// <summary>
        /// Creates a new instance of <see cref="ElementData"/> for a node.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public ElementData(string id)
        {
            Id = id;
        }

        /// <summary>
        /// Identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Source.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Target.
        /// </summary>
        public string Target { get; set; }
    }
}
