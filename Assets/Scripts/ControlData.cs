
//记录各个界面控件操作数据.
public class ControlData 
{
    private static volatile ControlData _instance;
    private static object _lock = new object();

    public static ControlData Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new ControlData();
                }
            }
            return _instance;
        }
    }
    public int curPT = 2;//当前操作云台 1--上方云台 2--下方云台.

}
