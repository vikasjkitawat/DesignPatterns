using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class BookContainer : IEnumerator<string>
    {
        private string[] books = new string[100];

        private int index = -1;

        private int currentPosition = -1;

        public string Current
        {
            get
            {
                if (currentPosition<=index)
                {
                    return books[++currentPosition];
                }
                return null;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                if (currentPosition >= -1)
                {
                    return books[++currentPosition];
                }
                return null;
            }
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (currentPosition < index)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            currentPosition = -1;
        }

        public void Add(string data)
        {
            books[++index] = data;
            //currentPosition++;
        }

        public void Remove()
        {
            string data = books[index--];
        }
    }
}
