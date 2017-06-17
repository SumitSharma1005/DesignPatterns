using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SingletonPattern
{
    public sealed class PrimeMinister
    {
        private static PrimeMinister instance = null;
        private static object _lock = new object();

        private PrimeMinister()
        {         
        }

        public static PrimeMinister Instance
        {
            get {
                lock(_lock)
                {
                    if (instance==null)    // Lazy bining                 
                        instance = new PrimeMinister();                    
                    
                    return instance;
                }                
            }
        }
        public void Logger(Exception ex)
        {
           
        }
    }
}