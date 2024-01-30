using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void    BasvuruYap(IKrediManager krediManager, List<ILoggerServices> services)
        {
            krediManager.Hesapla();
            foreach (var service in services)
            {
                service.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediManager)
        {
            foreach (var kredi in krediManager)
            {
                kredi.Hesapla();
            }
            

          
        }
    }
}
