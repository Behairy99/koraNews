using System;

namespace FirstCoreApp.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public string Topic { get; set; }

        public int CategoryID { get; set; } // forignkey for Category  هيختار انهي كاتجري من الكاتجريز اللي عندك
        // يعني كدا بتقوله اختار الكاتجري اللي اسمه كاتجري الاسم اللي قبل اي دي
        public Category Category { get; set; }  // علاقة 1 to many
    }
}
