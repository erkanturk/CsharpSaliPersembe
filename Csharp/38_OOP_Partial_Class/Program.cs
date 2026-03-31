namespace _38_OOP_Partial_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Parçalı sınıf fiziksel olarak Personel ve Personel 1 adında oluşturulan 2 farklı classın adını Personel olarak verip 
             * Partial keywordünü kullanarak birleştirip tek bir  class gibi davranmasını sağlamak 
             * Her ikisinde de bulunan üyeler derleyici tarafından birleştirilir ve bize tek bir yapı halinde sunulur
             * Genellikle büyük sınıf yapılarında kullanılır.

             */
            Personel personel = new Personel("Erkan");
            personel.Age = 32;
            personel.Address = "Kadıköy";
            personel.Id = 1234567891;
            personel.BilgiVer();

        }
    }
}
