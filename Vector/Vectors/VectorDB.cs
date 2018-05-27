using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class VectorDB
    {
        List<Vector> db;

        public VectorDB()
        {
            Db = new List<Vector>();
        }
        internal List<Vector> Db { get => db; set => db = value; }
    }
}
