using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloaderFactory torrentDownloader = new DownloaderFactory();

            Torrent t1 = torrentDownloader.Download("sample.mp4", "http://myfiles.com", 12450);
            Torrent t2 = torrentDownloader.Download("sample2.mp4", "http://myfiles.com", 1250);
            Torrent t3 = torrentDownloader.Download("sample3.mp4", "http://myfiles.com", 12800);
            Torrent t4 = torrentDownloader.Download("sample.mp4", "http://myfiles.com", 2140);
            Torrent t5 = torrentDownloader.Download("sample.mp3", "http://myfiles.com", 3521);

            Console.WriteLine(t1.filename + ", " + t1.url + ", " + t1.filesize + "bytes.");
            Console.WriteLine(t4.filename + ", " + t4.url + ", " + t4.filesize + "bytes.");
            Console.ReadKey();
        }
    }
}
