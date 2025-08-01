﻿namespace Tools
{
    public sealed class Log
    {
        private static Log _instance = null;
        private string _path;
        //Esto es para proteger la instancia de otros hilos cuando
        //se esta trabajando con hilos
        private static object _protect = new object();

        public static Log GetInstance(string path)
        {
            lock (_protect)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }

            return _instance;
        }

        private Log(string path) 
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
