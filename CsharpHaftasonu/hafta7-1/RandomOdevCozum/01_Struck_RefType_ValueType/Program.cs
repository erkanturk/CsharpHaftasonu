﻿namespace _01_Struck_RefType_ValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
        C# programlama dilinde struct, "structure" kelimesinin kısaltmasıdır. 
        Yani yapı veya yapısal anlamına gelir. struct, birden çok veri elemanını bir araya getirerek bir yapı oluşturmanıza izin verir.

struct'lar, sınıflar gibi karmaşık veri yapılarını tanımlamanın bir yoludur, ancak bazı önemli farklar vardır:

Değer Tipleri: struct'lar değer tipleridir, yani bellekte 
veri değerleri doğrudan saklanır. Bu, struct'ların değer kopyalama yoluyla iletilmesi ve atanması anlamına gelir. 
Öte yandan, sınıflar referans tipleridir ve bellekteki referansları saklarlar.

Kalıtım: Bir struct, başka bir struct veya sınıftan kalıtım alamaz. Ancak, bir struct arayüzlerden uygulanabilir.

struct'ların amacı, birbirine bağlı veri öğelerini gruplamak ve yönetmek için kullanılmasıdır. 
Örneğin, koordinatları saklamak, bir 
kişinin bilgilerini depolamak veya geometrik şekillerin özelliklerini temsil etmek için bir struct kullanabilirsiniz.

Özetle, struct'lar C# dilinde veri yapılarını tanımlamak ve organize etmek için kullanılan 
bir yapıdır ve sınıflarla karşılaştırıldığında farklılık gösterirler, özellikle değer tipi olmaları ve kalıtım almamaları açısından.

        */

            #region REFERENCE AND VALUE TYPES
            /*
            Referans türleri (Reference Types) ve değer türleri (Value Types), C# dilindeki veri tiplerinin iki ana kategorisini oluşturur. 
            Bunların bellek yönetimi açısından ve nasıl işledikleri konusunda önemli farklar vardır.

            ### Referans Tipleri (Reference Types):
            1. Referans türleri, veri değerlerini tutan bellek hücreleri yerine, bellekteki bir adresi tutarlar.
            Bu adres, gerçek veri değerlerinin  bulunduğu     bellek bölgesini işaret eder.
            2. Class, interface, delegate, ve arrayler (dizi) C# dilinde referans türleridir.
            3. Referans türleri, dinamik boyutları olan ve heap bellekte tutulan nesneleri temsil eder.
            4. Referanslar, değişkenler arasında değil, bellek bölgeleri arasında iletilir. 
            Bu, bir referans türünden bir değişkenin başka bir değişkene        
            atanması durumunda, verinin kopyalanmayacağı anlamına gelir, sadece bellekteki adres kopyalanır.
            5. Referans türleri, `null` olarak atanabilirler ve boş olabilirler.
            Bu, bir referans türünden oluşturulan nesnenin bellekte bir yere sahip      olmadığı anlamına gelir.

            ### Değer Tipleri (Value Types):
            1. Değer türleri, veri değerlerini doğrudan bellekte saklarlar.
            2. C#'da `int`, `float`, `double`, `char`, `bool`, `struct` gibi türler değer tipleridir.
            3. Değer türleri, bellekte doğrudan değerleri içeren bir bellek hücresine sahiptirler.
            4. Değer türleri, bir değişkenin değeri diğer bir değişkene atanırken, gerçek değerler kopyalanır.
            Yani, iki değişkenin aynı değeri  paylaşmasını  önlerler.
            5. Değer türleri, `null` olamazlar.Her zaman bir değere sahiptirler ve bu değerleri ilgili türün varsayılan değeri olabilir.

            ### Farklar:
            1. Bellek Yönetimi: Referans türleri, heap bellekte veri değerlerini saklar ve değişkenler adresleri işaret eder. 
            Değer türleri ise bellekte        doğrudan veri değerlerini saklarlar.
            2. Atama ve İletim: Referans türlerinde, değişkenler birbirine atandığında adresler kopyalanır.
            Değer türlerinde ise gerçek veri değerleri       kopyalanır.
            3. Boş Değer: Referans türler `null` olabilirken, değer türleri her zaman bir değere sahiptirler.
            4. Kopyalama Davranışı: Değer türleri değer kopyalama ile çalışırken, referans türleri adres kopyalama ile çalışır.

            Bu farklar, C# programlamada veri tipleri arasında seçim yaparken dikkate alınması gereken önemli noktalardır.
            */
            #endregion

        }
    }
}
