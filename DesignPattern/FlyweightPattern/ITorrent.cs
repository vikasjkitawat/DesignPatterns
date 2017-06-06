using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public interface ITorrent
    {
        void Start();
        void Pause();
        void Cancel();
        void Remove();
        void Restart();

    }
}
