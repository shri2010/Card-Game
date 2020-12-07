using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    /// <summary>
    /// Generic class for adding and removing element
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ElementsCollection<T>
    {
        protected List<T> elements = new List<T>();

        public ElementsCollection()
        {

        }


        /// <summary>
        /// Add element to collection
        /// </summary>
        /// <param name="elem"></param>
        public void AddElement(T elem)
        {
            this.elements.Add(elem);
        }

        /// <summary>
        /// Remove element to collection
        /// </summary>
        /// <param name="elem"></param>
        public void RemoveElement(T elem)
        {
            if (elements.Contains(elem))
            {
                this.elements.Remove(elem);
            }
            else
            {
                throw new InvalidOperationException("Element Does not exist");
            }
            
        }


        

    }
}
