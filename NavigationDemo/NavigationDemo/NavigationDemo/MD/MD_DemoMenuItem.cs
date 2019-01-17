using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationDemo.MD
{

    public class MD_DemoMenuItem
    {
        public MD_DemoMenuItem()
        {
            TargetType = typeof(MD_DemoDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}