using System;

namespace Assessment_1
{
    internal class CustomerQueue
    {
        private Customer[] queue;
        private int head; // Points to the first element in the queue.
        private int tail; // Points to the position where the next element will be inserted.
        private int count; // Tracks the number of elements currently in the queue.
        private int capacity; // The maximum number of elements the queue can hold.

        /// <summary>
        /// Initializes a new instance of the CustomerQueue class with a specified capacity.
        /// Time Complexity: O(1)
        /// </summary>
        public CustomerQueue(int capacity)
        {
            this.capacity = capacity;
            queue = new Customer[capacity];
            head = 0;
            tail = 0;
            count = 0;
        }

        /// <summary>
        /// Adds a customer to the end of the queue.
        /// Time Complexity: O(1)
        /// </summary>
        public void Enqueue(Customer customer)
        {
            if (count == capacity)
            {
                throw new InvalidOperationException("Queue is full");
            }
            queue[tail] = customer;
            tail = (tail + 1) % capacity;
            count++;
        }

        /// <summary>
        /// Removes and returns the customer at the beginning of the queue.
        /// Time Complexity: O(1)
        /// </summary>
        public Customer Dequeue()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            Customer customer = queue[head];
            head = (head + 1) % capacity;
            count--;
            return customer;
        }

        /// <summary>
        /// Returns the customer at the beginning of the queue without removing it.
        /// Time Complexity: O(1)
        /// </summary>
        public Customer Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return queue[head];
        }

        /// <summary>
        /// Displays all customers in the queue.
        /// Time Complexity: O(n)
        /// </summary>
        public void DisplayQueue()
        {
            int current = head;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(queue[current].GetInformation());
                current = (current + 1) % capacity;
            }
        }

        /// <summary>
        /// Returns the customer with the highest amount owed in the queue.
        /// Time Complexity: O(n)
        /// </summary>
        public Customer GetCustomerWithHighestAmountOwed()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            Customer highest = queue[head];
            int current = head;
            for (int i = 0; i < count; i++)
            {
                if (queue[current].AmountOwed > highest.AmountOwed)
                {
                    highest = queue[current];
                }
                current = (current + 1) % capacity;
            }
            return highest;
        }

        /// <summary>
        /// Calculates the total amount owed by all customers in the queue.
        /// Time Complexity: O(n)
        /// </summary>
        public float CalculateTotalAmountOwed()
        {
            float totalAmountOwed = 0;
            int current = head;
            for (int i = 0; i < count; i++)
            {
                totalAmountOwed += queue[current].AmountOwed;
                current = (current + 1) % capacity;
            }
            return totalAmountOwed;
        }

        /// <summary>
        /// Returns the customer at a specific index based on the order in the queue.
        /// Time Complexity: O(1)
        /// </summary>
        public Customer GetCustomerByIndex(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }

            int actualIndex = (head + index) % capacity;
            return queue[actualIndex];
        }

        // Provides a public read-only property to access the count of items in the queue.
        public int Count => count;
    }
}
