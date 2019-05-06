using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithGeometry
{
    static class Guard
    {
        public static bool Requires(bool statement, string message) =>
            statement ? statement : throw new ArgumentException(message);
    }
}
