using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.DataModel
{
   public  class BookRequestModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CreateDate { get; set; }
        public string UserID { get; set; }
        public int StatusID { get; set; }
        public string StatusString { get; set; }
        public string RequestedBy { get; set; }
        public string CategoryName { get; set; }
        public int CategoryID { get; set; }
    }
}
