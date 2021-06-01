using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class Mesaj:IComparable<Mesaj>
    {
        public string Metin { get; set; }
        public DateTime? OlusturmaZamani { get; set; } = DateTime.Now;
        public bool YildizliMi { get; set; }

        public int CompareTo(Mesaj other)
        {
            if (OlusturmaZamani<other.OlusturmaZamani)return 1;
            if (OlusturmaZamani == other.OlusturmaZamani) return 0;
            if (OlusturmaZamani > other.OlusturmaZamani) return -1;

            return OlusturmaZamani.ToString().CompareTo(other.OlusturmaZamani.ToString());
        }

        public override string ToString()
        {
            if (OlusturmaZamani<DateTime.Today)
            {
            if (YildizliMi==true)
            {
                return $"[{OlusturmaZamani}]  {Metin} ★ ";
            }
            return $"[{OlusturmaZamani}]  {Metin}";

            }
            else
            {
                if (YildizliMi == true)
                {
                    return $"[{OlusturmaZamani.Value.ToShortTimeString()}]  {Metin} ★ ";
                }
                return $"[{OlusturmaZamani.Value.ToShortTimeString()}]  {Metin}";
            }
        }

    }
 
}
