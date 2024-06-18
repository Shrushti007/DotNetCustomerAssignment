using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDetails
{
    public class CustomerArray
    {
        ArrayList arrayList = new ArrayList(4);

        public CustomerArray()
        {
            arrayList.Add(7);
            arrayList.Add("Google");
            arrayList.Add("US");
            arrayList.Add(75395);
            
        }


        public ArrayList GetTheArrayList()
        {

            return arrayList;

        }

    }
}
