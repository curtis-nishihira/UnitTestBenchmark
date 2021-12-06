using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace TestLibrary
{
    public class Test
    {
        int NumberOfItems = 100000;

        public bool GenerateList()
        {
            try
            {
                var list = new List<string>(NumberOfItems);
                for (int i = 0; i < NumberOfItems; i++)
                {
                    list.Add("Hello World!" + i);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
