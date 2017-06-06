using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Torrent : ITorrent
    {
        public string filename;
        public long filesize;
        public string url;

        public Torrent(string filename, string url, long fileSize)
        {
            this.filename = filename;
            this.url = url;
            this.filesize = fileSize;
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Restart()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
