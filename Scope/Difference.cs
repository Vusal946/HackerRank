using System;

namespace Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        // Add your code here
        public int computeDifference()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = elements.Length-1; j > 0; j--)
                {
                    maximumDifference = Math.Abs(elements[i] - elements[j]) > maximumDifference
                        ? Math.Abs(elements[i] - elements[j])
                        : maximumDifference;
                }
            }
            return maximumDifference;
        }

    }
}