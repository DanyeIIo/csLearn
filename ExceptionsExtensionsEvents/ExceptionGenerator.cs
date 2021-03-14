using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExceptionsExtensionsEvents
{
    class ExceptionGenerator
    {
        public void Generate()
        {
            Run1();
        }
        private void Run1() { Run2(); }
        private void Run2() { Run3(); }
        private void Run3() 
        {
            try
            {
            Run4(); 
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("Something went wrong", ex);
            }
        }
        private void Run4() { Run5(); }
        private void Run5() { Run6(); }
        private void Run6() { File.ReadAllText(null); }

    }
}
