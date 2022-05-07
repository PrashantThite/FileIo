using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWindows
{
    [Serializable]
  public  class Book
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Bname { get; set; }
        public string Author { get; set; }


    }
}
