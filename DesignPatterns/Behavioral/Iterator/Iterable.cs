using System.Collections;

namespace DesignPatterns.Behavioral.Iterator
{
    // The .NET framework has special interfaces that supports iteration.
    // Implementing the IEnumerable interface, like this class does, lets
    // you iterate over an object of this class using foreach.
    public class Iterable : IEnumerable
    {
        private readonly int[] numbers;

        public Iterable()
        {
            numbers = new[] { 1, 2, 3, 5, 7, 11 };
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var i in numbers)
            {
                // Using 'yield' here will make this method return the next number in the array
                // until the last number in the array has been returned.
                yield return i;
            }
        }
    }
}
