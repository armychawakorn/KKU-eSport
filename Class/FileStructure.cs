using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKU_ESport.Class
{
    public class FileStructure<T>
    {
        public string Type { get; set; }
        public List<T> Object { get; set; }
    }
}
