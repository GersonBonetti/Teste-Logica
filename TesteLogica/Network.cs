using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogica
{
    public class Network
    {
        private int[] integersArray;

        public Network() {}

        public Network(int numElements)
        {
            if (numElements <= 0)
            {
                throw new ArgumentException("O número de elementos precisa ser maior do que zero");
            }

            integersArray = new int[numElements];
            for (int i = 0; i < numElements; i++)
            {
                integersArray[i] = i;
            }
        }

        private int Find(int x)
        {
            if (integersArray[x] != x)
            {
                integersArray[x] = Find(integersArray[x]);
            }

            return integersArray[x];
        }

        private void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            integersArray[rootX] = rootY;
        }

        public void Connect(int x, int y)
        {
            if (x < 0 || x >= integersArray.Length || y < 0 || y >= integersArray.Length)
            {
                throw new ArgumentException("Número(s) inválido(s).");
            }

            Union(x, y);
        }

        public bool Query(int x, int y)
        {
            if (x < 0 || x >= integersArray.Length || y < 0 || y >= integersArray.Length)
            {
                throw new ArgumentException("Número(s) inválido(s).");
            }

            return Find(x) == Find(y);
        }
    }

}
