using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParser1
{
    class JsonPersonComplex : JsonPersonSimple
    {
        public Address address { get; set; }
        public List<PhoneNumber> phoneNumbers { get; set; }
    }
}
/*  Example of a person in JSON format:
     
    {
      "firstname":"Patrik",
      "lastname": "Morell",
      "age":30,
      "skills":["c#","SQL","javascript"],
      "address": {
        "streetAddress": "Mistelgatan 2h",
        "city": "Uppsala",
        "postCode": "75237"
        },
       "phoneNumbers": [
        {"type": "local", 
        "number": "0723581639"},
        {"type": "international",
        "number": "+46 723 581 639"}
        ]
     } 
*/
