using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_MVP_Socks4.Presenter
{
    public interface IPresenter
    {
        void Run();
    }

    public interface IPresenter<TArg>
    {
        void Run(TArg argument);
    }
}
