
//记录各个界面控件操作数据.
public class ControlData 
{
    private static ControlData _instance;
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
    public int ROVPOD_isOn = 0;
    public int ROVMOTOR_isOn = 0;
    public int ALLROVLAMP_isOn = 0;
    public int Release_Sequence_isOn = 0;
    public int LoadPump_isOn = 0;
    public int ThrustEnabled_isOn = 0;
    public int STBDMainipulator_isOm= 0;
    public int SystemPressureValue_isOn = 0;
    

    public int curPT = 2;//当前操作云台 1--上方云台 2--下方云台.
    public float curDepth=1000;//当前深度.
    public float curSpeed = 0.1f;//0.1m/s.

    //判断是否具备启动条件
    public bool GetReady
    {
        get {
            int sum = ROVPOD_isOn + ROVMOTOR_isOn + ALLROVLAMP_isOn + Release_Sequence_isOn + LoadPump_isOn + ThrustEnabled_isOn + STBDMainipulator_isOm + SystemPressureValue_isOn;
            return sum == 8;
        }
    }

    //前后运动速度.
    public float GetSpeedSurge
    {
        get{ return 0.55f; }
        set{ }
    }
    //左右速度.
    public float GetSpeedSway
    {
        get { return 1.18f; }
        set { }
    }
    //上下速度.
    public float GetSpeedHeave
    {
        get { return 0f; }
        set { }
    }

   
    //前后Trim百分比.
    public float GetTrim_Fwd_Aft
    {
        get { return 45.5f; }
        set { }
    }

    //左右Trim百分比.
    public float GetTrim_Port_Stbd
    {
        get { return 45.5f; }
        set { }
    }

    //上下Trim百分比.
    public float GetTrim_UP_Down
    {
        get { return 28.1f; }
    }

    //右上螺旋桨百分比.
    public float GetPropRightUp
    {
        get { return 58.6f; }
    }


    //右下螺旋桨百分比.
    public float GetPropRightDown
    {
        get { return 58.6f; }
    }

    //左上螺旋桨百分比.
    public float GetPropLeftUp
    {
        get { return 58.6f; }
    }


    //左下螺旋桨百分比.
    public float GetPropLeftDown
    {
        get { return 58.6f; }
    }
}
