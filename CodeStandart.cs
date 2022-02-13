namespace Oguz.CodeBase.CSharpCodeStandarts //Namespace isimlendirme Pascal Case kullanılır.
{
    public enum Color  //Enumlarda çoğul isim seçilmez (Colors gibi)
    {
        Black,
        Red,
        Green,
        Blue,
        White
    }
    /// <summary>
    /// Kod Standartlarını göstermek için oluşturulmuş bir sınf.
    /// </summary>
    public class CodeStandart : ICode //Sınıf isimlerind PascalCase kullanılır. Interface isimleri I ile başlar PascalCase kullanılır.
    {
        //Sınıf değişkenleri ve özellikleri sınıfın en üstüne yazılır.
        public int IsValid; //Public değişkenlerde Pascal Case kullanılır.
        private int _newAge; //Private değişkenler alt tire ile başlar Camel Case kullanılır.
        private string UserName = "aokocax"; //Değişken isimlendirmede Pascal Case kullanılır, kısatlma kullanılmaz (usrName gibi).
        private const int FixedValue = 5; //Const isimlendirmede büyük harf ve kelime aralarında alt tire kullanılmaz.
        //*Değişken isimlendirmede Hungarian Case yani lblCount, txtName kullanılmaz.
        private int ShowMethodSample(int firstValue, int secondValue)  //Metod isimlendirme Pascal Case, parametre isimleri Camel Case.
        {
            int multiplierCount = 10; //Lokal değişkenlerde camelCase kullanılır.

            //*Değişken isimlendirmede tip kullanılmaz iCount,intCount ya da strName yanlış kullanımdır.

            var localValue = 3; //Sağ taraf değerinin tipi açıkça görülebiliyorsa var kullanılabilir.
            
            int result=((firstValue+secondValue)/multiplierCount)+(FixedValue+localValue); //Sağ taraf işleminin sonucunun tipinin belli olması için tip ile değişken tanımlama daha uygundur.

            if (result < 0) // Parantezler için ayrı satır açılır, dikey olarak hizalanır.
            { 
                //Tek satırlık if ifadeleri tek satırda yazılabilri if (result<-1) return 0; gibi
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
