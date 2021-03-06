using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Marvel.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new Marvel.App(), args);
            host.Run();
        }
    }
}
