using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning.Core.Presentation
{
    public abstract class PresenterBase
    {
        public virtual void Load()
        {
        }

        public virtual void PreRender()
        {
        }

        public virtual void FirstTimeInit()
        {

        }
    }
}
