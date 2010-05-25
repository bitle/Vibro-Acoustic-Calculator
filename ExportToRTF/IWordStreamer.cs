
namespace ExportToRTF
{
    public interface IWordStreamer
    {
        void RenderToStream(System.IO.Stream ms);
    }
}