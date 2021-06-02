using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public enum SquareState
    {
        Default,
        Missed,
        Hit,
        Sunken
    }

    struct Square
    {
        SquareState squareState;

        public SquareState SquareState
        {
            get { return squareState; }
        }
    }

    class LimitedQueue<T> : Queue<T>
    {
        public LimitedQueue(int length) { }
    }

    abstract class Grid
    {
        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public readonly int Rows;
        public readonly int Columns;
        protected readonly Square?[,] squares;

        private List<List<Square>> GetHorizontalPlacements(int length)
        {
            var result = new List<List<Square>>();
            for (int r = 0; r < Rows; ++r)
            {
                LimitedQueue<Square> gathered = new LimitedQueue<Square>(length);
                for (int c = 0; c < Columns; ++c)
                {
                    // instead of this:
                    // if (squares[r, c] != null && squares[r, c].Value.SquareState == SquareState.Default)
                    if (IsSquareAvailable(r, c))
                        gathered.Enqueue(squares[r, c].Value);
                    else
                        gathered.Clear();

                    if (gathered.Count == length)
                        result.Add(new List<Square>(gathered.ToArray<Square>()));
                }
            }
            return result;
        }

        protected abstract bool IsSquareAvailable(int row, int column);
    }

    class FleetGrid : Grid
    {
        public FleetGrid(int rows, int columns) : base(rows, columns)
        {

        }
        protected override bool IsSquareAvailable(int row, int column)
        {
            return squares[row, column] != null;
        }
    }

    class EvidenceGrid : Grid
    {
        public EvidenceGrid(int rows, int columns) : base(rows, columns)
        {

        }
        protected override bool IsSquareAvailable(int row, int column)
        {
            return squares[row, column].Value.SquareState == SquareState.Default;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
