using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM
{
    public class Page
    {
        const int pageSize = 512;
        public int Absolute_page_number { get; set; }
        public bool Status { get; set; }
        public DateTime Time { get; set; }
        public byte[] Bitmap { get; set; }
        public int[] Data { get; set; }

        public Page(int number)
        {
            Absolute_page_number = number;
            Status = false;
            Time = DateTime.Now;
            Bitmap = new byte[pageSize / sizeof(int)]; // 128 бит. каждый бит соответсвует ячейки массива 
            Data = new int[pageSize / sizeof(int)]; // 128 элементов
        }
    }
}
