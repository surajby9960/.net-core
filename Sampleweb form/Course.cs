using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleweb_form
{
    [Serializable]
   public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }

    }
}
