using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public  class IletisimGec
    {
        public bool EmailGonder(string Email, string Baslik, string Mesaj)
        {
            //Email gönderme işlemi başlaı

            return true;
        }

        public bool TurkcelSMS(string TelNo, string Mesaj)
        {
            //Sms Gönderme işlemi başladı
            return true;
        }

        public bool IletiMerkeziSms(string TelNo, string Mesaj)
        {
            //Sms Gönderme İşlemi yapıldı
            return true;
        }
    }
}
