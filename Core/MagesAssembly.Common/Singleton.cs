using System;

namespace MagesAssembly.Common
{
    public static class Singleton<T>
    {
        private static Lazy<T> _instance = new Lazy<T>();

        public static T Value
        {
            get { return _instance.Value; }
        }
    }
}
