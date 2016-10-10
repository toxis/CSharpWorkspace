using System;

namespace BaseTests.Common
{
    public class Entity<T>
    {
        private T _data;
        public T Data
        {
            get { return _data; }
            set
            {
                var oldValue = _data;
                _data = value;

                var args = new EntityEventArgs<T>()
                {
                    OldValue = oldValue,
                    NewValue = value
                };
                OnValueChanged(args);
            }
        }

        public event EventHandler<EntityEventArgs<T>> ValueChanged;

        public void OnValueChanged(EntityEventArgs<T> e)
        {
            ValueChanged?.Invoke(this, e);
        }

        public Entity()
        {
            _data = default(T);
        }
    }

    public class EntityEventArgs<T> : EventArgs
    {
        public T OldValue { get; set; }
        public T NewValue { get; set; }
    }
}
