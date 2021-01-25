using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_IEnumerable.Models
{
    public class DemoLinkedList<TItem> : IEnumerable<TItem>
    {
        public DemoLinkedItem<TItem> FirstElement { get; set; }
        public DemoLinkedItem<TItem> LastElement { get; set; }
        public int Size { get; set; }


        public DemoLinkedList()
        {
            FirstElement = null;
            LastElement = null;
            Size = 0;
        }

        public void Add(TItem content)
        {
            DemoLinkedItem<TItem> item = new DemoLinkedItem<TItem>(content);

            if (FirstElement == null)
            {
                // Si la liste est vide => Premier element
                FirstElement = item;
            }
            else
            {
                // S'il y a un element => Définition de l'element suivant
                LastElement.NextElement = item;
            }

            // L'item devient le dernier element de la list
            LastElement = item;

            Size++;
        }

        #region IEnumerable => On doit pouvoir obtenir un générateur
        public IEnumerator<TItem> GetEnumerator()
        {
            return new DemoLinkedListEnumerator<TItem>(FirstElement);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        #endregion
    }

    public class DemoLinkedListEnumerator<TItem> : IEnumerator<TItem>
    {
        private DemoLinkedItem<TItem> StartElement { get; }
        private DemoLinkedItem<TItem> CurrentElement { get; set; }

        public DemoLinkedListEnumerator(DemoLinkedItem<TItem> firstElement)
        {
            StartElement = firstElement;
            CurrentElement = null;
        }

        public TItem Current
        {
            get { return CurrentElement.Content; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            CurrentElement = (CurrentElement == null) ? StartElement : CurrentElement.NextElement;
            return CurrentElement != null;
        }

        public void Reset()
        {
            CurrentElement = null;
        }

        public void Dispose()
        { }
    }
}
