using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Structural.Proxy.BadExample.ThirdPartyVideoLib
{
    public interface Video
    {
        void Render();
        string GetVideoId();
    }

}