using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     public class DataManager
    {
        private string data;
        private static DataManager instance=null;
        public static DataManager Instance
        {
            get
            {
                if (instance == null)
                    instance=new DataManager();
                return instance;
                    }
        }
        public string GetData()
        {
            return data;
            
        }
        private  DataManager() {
            data = "hello";

        }
    }
}
