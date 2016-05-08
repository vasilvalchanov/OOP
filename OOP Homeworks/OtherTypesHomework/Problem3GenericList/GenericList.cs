using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Problem4VersionAtribute;

namespace Problem3GenericList
{
    using System.Collections;
    
    [Version(3, 2, 11)]
    public class GenericList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] array;

        private int currentIndex;

        private int capacity;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.Capacity = capacity;
            this.array = new T[capacity];
            this.currentIndex = 0;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Capacity cannot be negative number");
                }

                this.capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return this.currentIndex;
            }
        }



        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < this.currentIndex; i++)
            {
                yield return this.array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(T elementToAdd)
        {
            this.array[this.currentIndex] = elementToAdd;
            this.currentIndex++;
            this.ResizeArray();
        }

        public T GetElementByIndex(int index)
        {
            this.ValidateIndexToBePositive(index);
            this.ValidateIndexToBeInRange(index);

            T element = default(T);
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (i == index)
                {
                    element = this.array[i];
                    break;
                }
            }

            return element;
        }

        public void RemoveElementByIndex(int index)
        {
            this.ValidateIndexToBePositive(index);
            this.ValidateIndexToBeInRange(index);


            for (int i = index; i < this.currentIndex - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }

            this.array[this.currentIndex] = default(T);
            this.currentIndex--;

        }

        public void InsertElementAtPosition(int position, T element)
        {
            this.ValidateIndexToBePositive(position);
            this.ValidateIndexToBeInRange(position);
            this.ResizeArray();

            for (int i = this.currentIndex + 1; i > position; i--)
            {
                this.array[i] = this.array[i - 1];
            }

            this.array[position] = element;
            this.currentIndex++;
        }

        public void Clear()
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                this.array[i] = default(T);
                
            }
            this.currentIndex = 0;
        }

        public int FindIndexByElementValue(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public T GetMin()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T min = this.array[0];

            for (int i = 1; i < this.currentIndex; i++)
            {
                if (this.array[i].CompareTo(min) < 0)
                {
                    min = this.array[i];
                }
            }

            return min;
        }

        public T GetMax()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T max = this.array[0];

            for (int i = 1; i < this.currentIndex; i++)
            {
                if (this.array[i].CompareTo(max) > 0)
                {
                    max = this.array[i];
                }
            }

            return max;
        }

        public VersionAttribute Version()
        {
            var type = typeof(GenericList<T>);
            var attributes = type.GetCustomAttributes(false);
            VersionAttribute versionAttribute = null;
            foreach (var attr in attributes)
            {
                if (attr != null && attr is VersionAttribute)
                {
                    versionAttribute = attr as VersionAttribute;
                }
            }

            return versionAttribute;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            if (this.Count > 0)
            {
                for (int i = 0; i < this.currentIndex; i++)
                {
                    sb.Append(this.array[i] + ", ");
                }

                sb.Remove(sb.Length - 2, 2);
                return sb.ToString();
            }
            else
            {
                return "List is empty";
            }
        }

        private void ValidateIndexToBePositive(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index cannot be negative number");
            }
        }

        private void ValidateIndexToBeInRange(int index)
        {
            if (index >= this.currentIndex)
            {
                throw new IndexOutOfRangeException("There isn't such index. Index is out of range");
            }
        }

        private void ResizeArray()
        {
            if (this.array.Length == this.currentIndex)
            {
                var newArray = new T[this.capacity * 2];
                Array.Copy(this.array, newArray, this.array.Length);
                this.array = newArray;
            }
        } 
    }
}
