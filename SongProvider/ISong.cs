using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongProvider
{
    public interface ISong
    {
        String FileName { get; set; }
        String Title { get; set; }
        String Artist { get; set; }
        String Album { get; set; }
        String Path { get; set; }
    }
}
