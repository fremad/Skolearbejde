using System;
using System.Collections.Generic;
using System.Linq;

namespace HeapManagement
{
    public class Worstfit : IFindebufferStrat
    {
           

        int IFindebufferStrat.FindBuffer(int size, List<Block> candidates)
        {
            if (candidates.Count == 0) throw new HeapManagementException("Unable to allocate memory", 0, size);

            Block tmp = null;
            tmp = candidates.First();
            foreach (var item in candidates)
            {
                if (item.Length > tmp.Length)
                {
                    tmp = item;
                }
            }

            return tmp.StartAddr;
        }
    }
}