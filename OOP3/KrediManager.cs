using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // biri bu interface kullanıcaksa bu metotların hepsini kullanması kendıne gore doldurması gerekir 
    // okunurlugu arttırmak için interfacesin onune I harfi koyarız
    // interfaceleri birbirinin alternatifi olan ama kod icerikleri farklı olan durumlar için kullanırız
    interface  IKrediManager
    {
        void Hesapla();
        void BiseyYap();

 

    }
}
