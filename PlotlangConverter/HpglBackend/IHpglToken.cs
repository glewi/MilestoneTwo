using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotlangConverter.HpglBackend
{
    interface IHpglToken
    {
        string GetCommand();
    }

    public class HpglRectangle : IHpglToken
    {
        public HpglRectangle(params object[] vs)
        {

        }
        
        public string GetCommand()
        {
            string cmd = "";
            return cmd;
        }
    }

    public class HpglCircle : IHpglToken
    {
        public string GetCommand()
        {
            string cmd = "";
            return cmd;
        }
    }
}
