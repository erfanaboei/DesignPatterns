using System;

namespace Proxy_Console
{
    public class Proxy: ISubject
    {
        private RealSubject _realSubject;
        
        public void DoAction()
        {
            _realSubject ??= new RealSubject();
            _realSubject.DoAction();
        }
    }
}