using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VM
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                VirtualMemory a = new VirtualMemory(10000);
                a.PrintPage();
                //для начала проверим запись данных и работу битовой карты
                Console.WriteLine($"Значение по индексу =  {a.ReadFromFile(1200)}");
                Console.WriteLine($"Значение по индексу =  {a.ReadFromFile(1201)}");
                a.WriteToFile(123, 0);
                a.WriteToFile(3, 3);
                a.WriteToFile(4, 7);
                a.WriteToFile(55, 127);
                a.WriteToFile(32, 256);
                a.WriteToFile(56, 258);
                a.WriteToFile(1, 1200);
                a.WriteToFile(888, 1537);
                a.WriteToFile(1234, 7000);

                Console.WriteLine($"Значение по индексу =  {a.ReadFromFile(1200)}");
                Console.WriteLine($"Значение по индексу =  {a.ReadFromFile(1201)}");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nОшибка при инициализации объекта VirtualMemory: {ex.Message}");
                
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine($"\nОшибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nОшибка: {ex.Message}");
            }
            Console.ReadLine();

        }


    }
}
