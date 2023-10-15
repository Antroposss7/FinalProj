using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProject.Models.ViewModels
{
   public class PagedResult<T>
{
    public IEnumerable<T> Items { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalItemCount { get; set; }
    public int PageCount => (int)Math.Ceiling((double)TotalItemCount / PageSize);
}

}
