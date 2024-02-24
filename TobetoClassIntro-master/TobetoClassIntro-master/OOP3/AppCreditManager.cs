using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class AppCreditManager
    {
        //Method injection
        public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendşrme 
            //Kredi hesapla 
            //İnterface adresleri tuttuğu için buradan hepsi çekilebilir
            creditManager.Calculate();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
