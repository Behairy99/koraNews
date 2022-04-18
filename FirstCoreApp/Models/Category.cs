using System.Collections.Generic;

namespace FirstCoreApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public List<News> News { get; set; }    // one Category has more one News
    }
}
