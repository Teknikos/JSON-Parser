using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Example of a simple JSON person:
  {
      "firstname":"Patrik",
      "lastname": "Morell",
      "age":30,
      "skills":["c#","SQL","javascript"]
   } 
 */
namespace JSONParser1
{
    class JsonPersonSimple
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public string[] skills { get; set; }
        
    }
}
