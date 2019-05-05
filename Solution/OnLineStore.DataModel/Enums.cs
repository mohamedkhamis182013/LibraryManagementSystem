using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.DataModel
{
    public class Enums
    {


        public enum Status
        {
            pending_verification = 1,
            rejected = 2,
            verified = 3,

        }

        public enum Category
        {

            Business = 1,
            Biographies = 2,
            Arts = 3,
            Cooking = 4,
            History = 5,
            Medical = 6,
            Science = 7,
            Religion = 8,
            Sport = 9,
            Horror = 10
        }
    }
}
