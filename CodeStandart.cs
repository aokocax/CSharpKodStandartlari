namespace Oguz.CodeBase.CSharpCodeStandarts //Namespace isimlendirme pascal case kullanılır
{
    public enum Color //enumlarda çoğul isim seçilmez
    {
        Black,
        Red,
        Green,
        Blue,
        White
    }
    ///
    public class CodeStandart : ICode //sınıf isimler PascalCase, interface isimleri I ile başlar PascalCase
    {
        //Sınıf değişkenleri ve özellikleri sınıfın en üstüne yazılır.
        public bool IsValid;
        public bool HasContent;
        public int MedianAge; //public değişkenlerde pascal case kullanılır.
        private int _newAge; // private değişkenler alt tire ile başlar camel case kullanılır
        private const string UserName = "aokocax"; // değişken isimlendirmede pascal case kullanılır, kısatlma kullanılmaz (usrName gibi)
        private const int FixedValue = 5; // const isimlendirmede büyük harf ve kelime aralarında alt tire kullanılmaz
        //*değişken isimlendirmede hungarian case yani lblCount, txtName kullanılmaz.

        private int ShowMethodSample(int firstValue, int secondValue)  // parametre isimleri camelCase
        {
            int multiplierCount = 10; //lokal değişkenler camelCase;

            //*değişken isimlendirmede tip kullanılmaz iCount,intCount ya da strName yanlış kullanımdır.

            var localValue = 3; //Sağ taraf değerinin tipi açıkça görülebiliyorsa var kullanılabilir.
            
            int result=((firstValue+secondValue)/multiplierCount)+(FixedValue+localValue); //var kullanımı değerin direkt tanımlandığı değişkenlerde kullanılır

            if (result < 0) // parantezler için ayrı satır açılır, dikey olarak hizalanır.
            { 
                //tek satırlık if ifadeleri tek satırda yazılabilri if (result<-1) return 0; gibi
                string hello = "Hello world";
                Debug.WriteLine(hello);
            }

            for (var i = 0; i < 3; i++)
            {
                Debug.WriteLine(i); //for, while döngülerinde i,x gibi isimlendirmeler kullanılabilir.
            }

            return result;
        }
        
    }

    public class CustomException : Exception //İstisna isimlendirmede Exception son eki kullanılır
    {

    }
}`
