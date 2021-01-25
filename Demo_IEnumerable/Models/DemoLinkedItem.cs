using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_IEnumerable.Models
{
    public class DemoLinkedItem<TItem>
    {
        public TItem Content { get; set; }
        public DemoLinkedItem<TItem> NextElement { get; set; }

        public DemoLinkedItem(TItem content)
        {
            NextElement = null;
            Content = content;
        }
    }
}
