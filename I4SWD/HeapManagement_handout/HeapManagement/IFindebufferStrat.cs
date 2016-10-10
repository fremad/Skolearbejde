using System.Collections.Generic;

namespace HeapManagement
{
    public interface IFindebufferStrat
    
    {
        int FindBuffer(int size, List<Block> candidates);
    }
}