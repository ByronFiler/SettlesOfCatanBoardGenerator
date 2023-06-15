namespace KatanBoardGenerator.NewFolder
{
    /// <summary>
    /// Cytoscape Coordinates.
    /// </summary>
    public class Coordinates
    {
        /// <summary>
        /// Creates a new instance of <see cref="Coordinates"/>.
        /// </summary>
        /// <param name="x">X axis coordinate.</param>
        /// <param name="y">Y axis coordinate.</param>
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// X axis coordinate.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y axis coordinate.
        /// </summary>
        public int Y { get; set; }
    }
}
