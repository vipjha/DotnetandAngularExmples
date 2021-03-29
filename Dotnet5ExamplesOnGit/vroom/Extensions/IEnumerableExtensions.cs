using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vroom.Models;

namespace vroom.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItems<T>(this IEnumerable<T> Items)
        {
            List<SelectListItem> List = new List<SelectListItem>();
            {
                SelectListItem selectListItem = new SelectListItem
                {
                    Text = "---------Select----------",
                    Value = "0"
                };
                List.Add(selectListItem);
                foreach  (var Item in Items)
                {
                    selectListItem = new SelectListItem
                    {
                        Text = Item.GetPropertyValue("Name"),
                        Value = Item.GetPropertyValue("Id")

                        /*Text =Item.GetType().GetProperty("Name").GetValue(Item, null).ToString(),
                        Value = Item.GetType().GetProperty("Id").GetValue(Item, null).ToString()*/
                    };
                    List.Add(selectListItem);
                }
                return List;
            }
        }
    }
}
