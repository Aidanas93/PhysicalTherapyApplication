using Microsoft.AspNetCore.Mvc.Rendering;
using PhysicalTherapyProject.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace PhysicalTherapyProject.Application.Infrastructure.Extensions
{
    public static class SelectListExtension
    {
        public static IList<SelectListItem> ConvertToSelectListItems(this IEnumerable<Tag> tags)
        {
            return new List<SelectListItem>(
            tags.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.TagValue
            }
            ));
        }
    }
}
