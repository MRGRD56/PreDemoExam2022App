using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreDemoExam2022App.Common.Common
{
    [Obsolete]
    public abstract class Service<T>
    {
        public abstract T Instance { get; }
    }
}
