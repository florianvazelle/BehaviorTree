using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Repeat<T>
    where T : INode
{
    private T instance;
    private int repeatCount;

    public Repeat(T instance, int repeatCount)
    {
        this.instance = instance;
        this.repeatCount = repeatCount;
    }

    State act()
    {
        int i = 0;
        State res;
        do {
            i++;
            res = instance.act();
        } while(i < repeatCount); 
        return res;
    }
}
