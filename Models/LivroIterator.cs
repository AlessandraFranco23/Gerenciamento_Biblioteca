using System.Collections;

namespace Models
{

    public interface Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract int Key();

        public abstract object Current();

        public abstract bool MoveNext();

        public abstract void Reset();
    }

    public interface IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
    public class LivroIterator : Iterator
    {
        private BibliotecaModel _collection;

        private int _position = -1;

        public LivroIterator(BibliotecaModel collection)
        {
            this._collection = collection;
        }

        public  object Current()
        {
            return this._collection.getItems()[_position];
        }


        public  int Key()
        {
            return this._position;
        }


        public  bool MoveNext()
        {
            int updatedPosition = this._position +  1;

            if (updatedPosition >= 0 && updatedPosition < this._collection.getItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public  void Reset()
        {
            this._position = 0;
        }
    }
}