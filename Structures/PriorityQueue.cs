using System.Reflection;

namespace Structures
{
    /// <summary>
    /// Stores items, along with a priority for each item
    /// </summary>
    /// <typeparam name="T">the type of item stored</typeparam>
    public class PriorityQueue<T>
    {
        // Naive implementation - store items along with their priority
        // in a simple List
        private List<PrioritizedItem> contents = new List<PrioritizedItem> ();

        // note - no constructor defined, because we don't (so far) need
        // information from the outside when we create a new PriorityQueue.
        // We'll do any initialization we need in our declaration of fields.

        /// <summary>
        /// the number of items in the queue
        /// </summary>
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Enqueue(T value, int priority)
        {
            // create new custom object with given value and priority
            // add it to the end of our list (could be smarter, but... naive)
        }

        /// <summary>
        /// Returns the highest priority item from the queue
        /// Throws InvalidOperationException if queue is empty
        /// </summary>
        /// <returns>highest priority item</returns>
        /// <exception cref="NotImplementedException"></exception>
        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        // private structure, needed only by our PriorityQueue class
        // note - a struct is like a class, but...
        // --> it's a value type (not a reference type) so
        //     it uses less memory and is quicker to access
        // --> a little limited in its functionality/flexibility
        //
        // for more detail, see, for instance
        // https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct
        // our class here is immutable; it fits the criteria described in the article.
        private struct PrioritizedItem
        {
            // OK to have public fields, because not visible outside our class
            public readonly T Value;
            public readonly int Priority;

            public PrioritizedItem(T value, int priority)
            {
                this.Value= value;
                this.Priority= priority;
            }
        }
    }
}