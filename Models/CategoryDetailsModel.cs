using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTree.Entities;

namespace TechTree.Models
{
    public class CategoryDetailsModel
    {
        public IEnumerable<GroupedCategoryItemsByCategoryModel> GroupedCategoryItemsByCategoryModels { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
