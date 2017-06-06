using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class DownloaderFactory
    {
        public Dictionary<string, Torrent> torrents = new Dictionary<string, Torrent>();

        public Torrent Download(string filename, string url, long filesize)
        {
            Torrent torrent;
            var exists = torrents.ContainsKey(filename);

            if (!exists)
            {
                torrent = new Torrent(filename, url, filesize);
                torrents.Add(filename,torrent);
            }
            else
            {
                torrent = torrents[filename];
            }
            return torrent;
        }
    }
}
