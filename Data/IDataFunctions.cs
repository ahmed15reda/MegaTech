using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTree.Entities;

namespace TechTree.Data
{
    public interface IDataFunctions
    {
        Task UpdateUserCategoryEntityAsync(List<UserCategory> userCategoryItemsToDelete, List<UserCategory> userCategoryItemsToAdd);
    }
}
