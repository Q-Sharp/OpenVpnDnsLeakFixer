using System;
using System.IO;
using System.Linq;

namespace OpenVpnDnsLeakFixer
{
    class Program
    {
        static void Main() => Directory.GetFiles(Directory.GetCurrentDirectory()).Where(x => Path.GetExtension(x) == ".ovpn").ToList().ForEach(f =>
        {
            if (!File.ReadAllText(f).Contains("block-outside-dns"))
                File.AppendAllText(f, Environment.NewLine + "block-outside-dns");
        });
    }
}
