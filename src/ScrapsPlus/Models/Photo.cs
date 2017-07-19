using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlus.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public byte[] Image { get; set; }
        public int ProfileID { get; set; }
        public int AlbumID { get; set; }
    }
}
