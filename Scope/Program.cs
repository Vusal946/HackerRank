using System;
using System.Linq;

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

} // End of Difference Class

class Program
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}