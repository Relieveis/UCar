using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honotop.UCar.Models.PermissionRecords
{
   public class PermissionRecord
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        
        public string SystemName { get; set; }
        
        public string Category { get; set; }
    }
}
