using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class List<T>
    {
        // 
        private T[] buffer;
        private int size;
        private const int MIN_CAPACITY = 4;

        public List()
        {
            buffer = null;
            size = 0;
        }

        // methods

        public int Size => size;
        public int Capacity => buffer.Length;        

        // Adds an element at the end of the list.
        public void PushBack(T value)
        {
            if (buffer == null)
            {
                buffer = new T[MIN_CAPACITY];
            }
            else if (size == buffer.Length)
            {
                Reserve(size * 2);
            }

            // Size it the index of the first free cell in the array. 
            buffer[size] = value;
            size++;
        }

        // Remove the last occupied cell

        public void PopBack()
        {
            if (size == 0)
            {
                throw new IndexOutOfRangeException("List is empty");
            }
            size--;
            buffer[size] = default(T);
        }

        public void InsertAt(int index, T value)
        {
            if (index == size)
            {
                PushBack(value);
                return;
            }

            PushBack(Last);

            for (int i = size-2; i > index; i--)
            {
                buffer[i] = buffer[i - 1];
            }

            buffer[index] = value;

        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < size-1; i++)
            {
                buffer[i] = buffer[i + 1];
            }

            PopBack();
        }

        public void RemoveRange(int begin, int end)
        {
            int rangeSize = end - begin;

            for (int i = 0; i < size - rangeSize; i++)
            {
                buffer[i] = buffer[i + rangeSize];
            }

            for (int i = 0; i < rangeSize; i++)
            {
                PopBack();
            }
        }

        // Common methods
        public void Reserve(int newSize)
        {
            // Because the methos is public we have to check that
            // the new size i bigger;
            if (newSize < size)
            {
                return;
            }
            // Creates a new array;
            var newBuffer = new T[newSize];

            //Copies the elements from the smaller array till index size.
            for (int i = 0; i < size; i++)
            {
                newBuffer[i] = buffer[i];
            }

            buffer = newBuffer;
        }

        public void SrinkToFit()
        {
            Reserve(size);
        }

        public void Clear()
        {
            size = 0;
            buffer = new T[MIN_CAPACITY]; // optional
        }

        public T this[int index]
        {
            get
            {
                return buffer[index];
            }

            set
            {
                buffer[index] = value;
            }
        }

        public T Last
        {
            get
            {
                return buffer[size-1];
            }
            set
            {
                buffer[size-1] = value;
            }
        }
    }
}
