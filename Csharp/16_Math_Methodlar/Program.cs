namespace _16_Math_Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Method Tanım
            /* Methods - Fonksiyonlar
             * Methodlar yazılımcılar tarafından geliştirilen ve diğer yazılımcıların kullanımına sunulan hazır kod yapılarıdır.
             * Methoda bir isim verilir ve o isim altında bir iş yapan kod bloğu yazılır ve yazılımcı o işi yapmak için methodu çağırır.
             * bu sayede yazılımcı tanımlı bir iş yapısını tekrar tekrar yazmaktan kurtulur.
             * Methodlar ve fonksiyonlar '()' ile tanımlanır
             * Method içerisinde yeni bir method yazamayız.
             * Methodlar çağırılmadığı sürece çalışmazlar.
             * Methodlar unique(benzersiz) olmalıdır aynı isme sahip methodların imza tipi farklı olmalıdır.
             * Fonksiyonlar ise yazılımcıların kendi oluşturduğu methodlardır.
             * Methodlar 2 ye ayrılır.
             * Değer döndüren methodlar(Parametreli/Parametresiz)
             * İş yapan methodlar (Parametreli/Parametresiz)
             * Methodlar çağırılırken MethodIsim(); ile tanımlanır varsa parametre değeri içeriye yazılır
             * Method oluştururken ise MethodIsim()
             *                         {
             *                            Yapacağı işlemi belirtiriz.
             *                         }
             *Methodlar genelde PascalCase ile yazılır
             
             */
            #endregion

            //Math Methodları
            Console.WriteLine($"Pi sayısı {Math.PI}");
            Console.WriteLine($"Karekök alma: {Math.Sqrt(25)}");
            Console.WriteLine($"Kuvvetini alma: {Math.Pow(2, 3)}");
            Console.WriteLine($"Mutlak değer: {Math.Abs(-30)}");
            Console.WriteLine($"Maksimum değer:{Math.Max(10,50)}");
            Console.WriteLine($"Minimum değer:{Math.Min(10, 50)}");
            Console.WriteLine($"Tam yuvalama: {Math.Round(3.49)}");
            Console.WriteLine($"Yukarı yuvarlama: {Math.Ceiling(3.01)}");
            Console.WriteLine($"Aşağı yuvarlama: {Math.Floor(3.99)}");
            Console.WriteLine($"Sin: {Math.Sin(3.22)}");



        }
    }
}
