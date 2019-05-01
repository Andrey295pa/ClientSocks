using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_MVP_Socks4.Control;
using WindowsFormsApp_MVP_Socks4.View;

namespace WindowsFormsApp_MVP_Socks4.Presenter
{
    public abstract class BasePresenter<TView> : IPresenter where TView : IView
    {
        protected TView View { private set; get; }
        protected IApplicationController controller { private set; get; }

        protected BasePresenter(IApplicationController _controller, TView _View)
        {
            this.controller = _controller;
            this.View = _View;
        }

        public abstract void Run();
    }

    public abstract class BasePresenter<TView, TArg> : IPresenter<TArg> where TView : IView
    {
        protected TView View { private set; get; }
        protected IApplicationController controller { private set; get; }

        protected BasePresenter(IApplicationController _controller, TView _View)
        {
            this.controller = _controller;
            this.View = _View;
        }

        public abstract void Run(TArg argument);
    }
}
