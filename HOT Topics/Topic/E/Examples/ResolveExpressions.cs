using System;
using System.Linq;

namespace Topic.E.Examples
{
    internal class ResolveExpressions
    {
        public static double Sample1
        { get { return 10.0 + 15 / 2 + 4.3; } }

        public static double Sample3
        { get { return 10.0 + 15.0 / 2 + 4.3; } }

        public static double Sample4
        { get { return 3.0 * 4 / 6 + 6; } }

        public static double Sample5
        { get { return 3.0 * (4 % 6) + 6; } }

        public static double Sample6
        { get { return 3 * 4.0 / 6 + 6; } }

        public static double Sample7
        { get { return 20.0 - 2 / 6 + 3; } }

        public static int Sample8
        { get { return 10 + 17 % 3 + 4; } }

        public static double Sample9
        { get { return (10 + 17) % 3 + 4.0; } }

        public static double Sample10
        { get { return 10 + 17 / 4.0 + 4; } }
    }
}
