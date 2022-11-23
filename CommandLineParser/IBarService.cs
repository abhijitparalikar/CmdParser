using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DI_Template
{
    public interface IBarService
    {
        void ParseAndDoWork(string[] args);
        //void DoSomeRealWork();
    }
}
