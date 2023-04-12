using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_and_JSON
{
    public class VolumeInfo
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public int PageCount { get; set; }

        public VolumeInfo(string title, string[] authors, int pageCount)
        {
            Title = title; 
            Authors = authors;
            PageCount = pageCount;
        }

        public override string ToString()
        {
            return $"{Title} -- {String.Join(", ", Authors)} {PageCount}pgs.";
        }
    }
}
