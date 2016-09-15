namespace CompressionStocking
{
    public interface ICompressionCtrl
    {
        void Compress(ICompressionComplete here);
        void Decompress();

        
    }
}