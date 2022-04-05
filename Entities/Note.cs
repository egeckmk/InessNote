using InessNote.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InessNote.Domain.Entities
{
  public class Note : BaseEntity
  {
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public List<string> Tags { get; set; }
  }
}
