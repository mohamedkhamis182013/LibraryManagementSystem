using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.DataModel
{
    public  class BookModel
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CategoryID { get; set; }

        public string UserID { get; set; }
        public string CategoryName { get; set; }
        public string CreateDate { get; set; }
        public string LastUpdateDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
