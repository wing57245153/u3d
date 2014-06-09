using System;
using System.Collections;

namespace Game.Utils
{
    public class Singleton<T> where T : new()
    {
        protected static T _instance = default(T);
        private static Object _objLock = new System.Object();

        protected Singleton()
        {
        }

        public static T instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_objLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new T();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
