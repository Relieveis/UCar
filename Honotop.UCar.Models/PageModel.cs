using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.WMS.Models
{

    public class PageModel
    {
        private int pagesize;
        private int pagenumber;
        public int TotalCount { get; set; }
        public int pageSize
        {
            get
            {
                return pagesize;
            }
            set
            {
                if (value < 10)
                    pagesize = 10;
                else
                    pagesize = value;
            }
        }
        public int pageNumber {
            get
            {
                return pagenumber;
            }
            set
            {
                if (value <= 0)
                    pagenumber = 1;
                else
                    pagenumber = value;
            }
        } 

    }
}
