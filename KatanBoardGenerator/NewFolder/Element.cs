namespace KatanBoardGenerator.NewFolder
{
    /// <summary>
    /// Wrapper needed for Cytoscape to work with the serialized data.
    /// </summary>
    public class Element
    {
        /// <summary>
        /// Creates a new instance of <see cref="Element"/> for a Edge.
        /// </summary>
        /// <param name="data"></param>
        public Element(ElementData data)
        {
            Data = data;
        }

        /// <summary>
        /// Creates a new instance of <see cref="Element"/> for a Node.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="position"></param>
        public Element(ElementData data, Coordinates position) : this(data)
        {
            Position=position;
        }

        /// <summary>
        /// Data.
        /// </summary>
        public ElementData Data { get; set; }

        /// <summary>
        /// Position.
        /// </summary>
        public Coordinates Position { get; set; }

        /// <summary>
        /// Grabability setting.
        /// </summary>
        public bool Grabbable { get; set; } = false;
    }
}
