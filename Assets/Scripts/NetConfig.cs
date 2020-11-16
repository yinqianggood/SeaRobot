using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetConfig
{

   
    //ROV运动指令
    public const string rov_up_on = "rov_up_on";//开启向上.
    public const string rov_up_off = "rov_up_off";//关闭向上
    public const string rov_down_on = "rov_down_on";
    public const string rov_down_off = "rov_down_off";
    public const string rov_foward_on = "rov_foward_on";
    public const string rov_foward_off = "rov_foward_off";
    public const string rov_back_on = "rov_back_on";
    public const string rov_back_off = "rov_back_off";
    public const string rov_left_on = "rov_left_on";
    public const string rov_left_off = "rov_left_off";
    public const string rov_right_on = "rov_right_on";
    public const string rov_right_off = "rov_right_off";
    public const string rov_turn_right_on = "rov_turn_right_on";//开启右转.
    public const string rov_turn_right_off = "rov_turn_right_off";//关闭右转.
    public const string rov_turn_left_on = "rov_turn_left_on";//开启左转.
    public const string rov_turn_left_off = "rov_turn_left_off";//关闭左转.

    //机械臂运动指令 
    public const string arm_up_on = "arm_up_on";//按上.
    public const string arm_up_off = "arm_up_off";//停止按上.
    public const string arm_down_on = "arm_down_on";
    public const string arm_down_off = "arm_down_off";
    public const string arm_foward_on = "arm_foward_on";
    public const string arm_foward_off = "arm_foward_off";
    public const string arm_back_on = "arm_back_on";
    public const string arm_back_off = "arm_back_off";
    public const string arm_left_on = "arm_left_on";
    public const string arm_left_off = "arm_left_off";
    public const string arm_right_on = "arm_right_on";
    public const string arm_right_off = "arm_right_off";
    public const string arm_turn_right_on = "arm_turn_right_on";//按下右转.
    public const string arm_turn_right_off = "arm_turn_right_off";//停止按下右转.
    public const string arm_turn_left_on = "arm_turn_left_on";//按下左转.
    public const string arm_turn_left_off = "arm_turn_left_off";//停止按下左转.
    public const string arm_open_on = "arm_open_on";//打开机械爪.
    public const string arm_open_off = "arm_open_off";//停止打开机械爪.
    public const string arm_close_on = "arm_close_on";//关闭机械爪.
    public const string arm_close_off = "arm_close_off";//停止关闭机械爪.



    //云台相机运动指令.
    public const string cam_up_on = "cam_up_on";//向上.
    public const string cam_up_off = "cam_up_off";//停止向上.
    public const string cam_down_on = "cam_down_on";
    public const string cam_down_off = "cam_down_off";
    public const string cam_left_on = "cam_left_on";
    public const string cam_left_off = "cam_left_off";
    public const string cam_right_on = "cam_right_on";
    public const string cam_right_off = "cam_right_off";


    //托盘前后运动.
    public const string flot_foward_on = "flot_foward_on";
    public const string flot_foward_off= "flot_foward_off";
    public const string flot_back_on = "flot_back_on";
    public const string flot_back_off = "flot_back_off";

    //灯光控制.
    public const string lamp_port_stbd_on = "lamp_port_stbd_on";
    public const string lamp_port_stbd_off = "lamp_port_stbd_off";
    public const string lamp_bullet_pt_on = "lamp_bullet_pt_on";
    public const string lamp_bullet_pt_off = "lamp_bullet_pt_off";
    public const string lamp_bottom_pt_on = "lamp_bottom_pt_on";
    public const string lamp_bottom_pt_off = "lamp_bottom_pt_off";
    public const string lamp_all_on= "lamp_all_on";
    public const string lamp_all_off = "lamp_all_off";







}
