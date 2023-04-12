using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_and_JSON
{
    internal class Book
    {
        public VolumeInfo VolumeInfo { get; set; }
        public Book() { }

        public Book(VolumeInfo volumeInfo)
        {
            VolumeInfo = volumeInfo;
        }
    }
}
