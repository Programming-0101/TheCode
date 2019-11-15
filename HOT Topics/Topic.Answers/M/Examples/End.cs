using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.M.Examples
{
    public class End
    {
        public readonly char Label;
        public End(char label)
        {
            if (!char.IsLetter(label))
                throw new ArgumentOutOfRangeException("Unacceptable character for a label; labels must be letters");
            Label = label;
        }
        public override string ToString()
        {
            return Label.ToString();
        }
    }
    public class Path
    {
        private End[] Ends = new End[2];
        public Path(End oneEnd, End otherEnd)
        {
            Ends[0] = oneEnd;
            Ends[1] = otherEnd;
        }
        public End Traverse(End start)
        {
            if (!Ends.Contains(start))
                throw new ArgumentOutOfRangeException(nameof(start),$"The end '{start}' is not connected to this path");
            if (Ends[0] == start)
                return Ends[1];
            else
                return Ends[0];
        }

        public override string ToString()
        {
            return $"{Ends[0]}---{Ends[1]}";
        }
    }
    /// <summary>
    /// A Route is an ordered collection of connected paths.
    /// </summary>
    public class Route : ICollection<Path>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Path item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Path item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Path[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Path> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Path item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
