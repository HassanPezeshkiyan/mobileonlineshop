using System.Collections.Generic;

namespace OnlineMobileShop.Models
{
    public class DB
    {
        public List<Phone> phones = new List<Phone>();
        public List<Category> categories = new List<Category>();

        public void AddData()
        {
            List<string> brand_list = new List<string> { "HUAWEI", "APPLE", "SAMSUNG", "SONY" };
            List<decimal> price_list = new List<decimal> { 10000000,2000000,5000000,7000000,9000000,1200000 };
            for (int i = 0; i < 10; i++)
            {
                var random = new Random();
                var random_price = new Random();
                int index = random.Next(brand_list.Count);
                int index_price = random_price.Next(price_list.Count);

                Phone phone = new Phone()
                {
                    Title = "موبایل_" + i.ToString(),
                    Brand = brand_list[index],
                    CategoryId = index,
                    Price = price_list[index_price],
                    Id = i + 1,
                    ImagePath = $"/mobiles/{i}.jpg"
                };
                phones.Add(phone);
            }
        }

        public void AddCategories()
        {
            Category category = new Category()
            {
                Id = 0,
                Title = "HUAWEI"
            };
            Category category2 = new Category()
            {
                Id = 1,
                Title = "APPLE"
            };
            Category category3 = new Category()
            {
                Id = 2,
                Title = "SAMSUNG"
            };
            Category category4 = new Category()
            {
                Id = 3,
                Title = "SONY"
            };
            categories.Add(category);
            categories.Add(category2);
            categories.Add(category3);
            categories.Add(category4);
        }


    }
}

