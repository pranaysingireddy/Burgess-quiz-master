using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgess_quiz
{

    public class Repo
    {
        List<Header> HeaderList = new List<Header>() {
            new Header("249e1bd0-0b6c-4dce-8d72-e16f20b1b49c", 1),
            new Header("ea9560cc-e38b-481e-9630-3ca03e5b46a2", 2),
            new Header("afaf2070-8fb7-492d-b7c2-b2ca7ed80844", 3),
        };

        List<LineItem> LineItemList = new List<LineItem>() {
            new LineItem(1, "2/21/2017 12:00:00 AM", "Item 1", 100),
            new LineItem(2, "2/22/2017 12:00:00 AM", "Item 2", 200),
            new LineItem(3, "2/23/2017 12:00:00 AM", "Item 3", 300),
        };

        List<LineItem> LineItemList1 = new List<LineItem>() {
            new LineItem(1, "2/23/2017 12:00:00 AM", "Item 3", 300),
            new LineItem(2, "2/24/2017 12:00:00 AM", "Item 4", 400),
            new LineItem(3, "2/25/2017 12:00:00 AM", "Item 5", 500),
            };
        List<LineItem> LineItemList2 = new List<LineItem>() {
            new LineItem(1, "2/22/2017 12:00:00 AM", "Item 2", 200),
            new LineItem(2, "2/24/2017 12:00:00 AM", "Item 4", 400),
            };

        public List<Header> Task1()
        {
            return HeaderList.ToList();
            
        }
        //public string GetClientNameByID(int id)
        //{

           
        //}
    }
}
