using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BaseCommand:ICommand
{
    public virtual void Execute(IMessage message)
    {
    }

    public T GetManager<T>(string manageName) where T : class
    {
        return facade.GetManager<T>(manageName);
    }

    public AppFacade facade{
        get
        {
            return AppFacade.Instance;
        }
    }
}

