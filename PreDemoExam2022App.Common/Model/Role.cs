using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreDemoExam2022App.Common.Model
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public Role(string name)
        {
            Name = name;
        }
    }
}
