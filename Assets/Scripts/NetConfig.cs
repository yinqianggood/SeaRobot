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

    //机械臂运动指令 因机械臂操作对精度要求高 所以屏蔽惯性 去掉off因素.
    public const string arm_up = "arm_up";//按上.
    public const string arm_down = "arm_down";
    public const string arm_foward = "arm_foward";
    public const string arm_back = "arm_back";
    public const string arm_left = "arm_left";
    public const string arm_right = "arm_right";
    public const string arm_turn_right = "arm_turn_right";//按下右转.
    public const string arm_turn_left = "arm_turn_left";//按下左转.
    public const string arm_open = "arm_open";//打开机械爪.
    public const string arm_close= "arm_close";//关闭机械爪.



    //云台相机运动指令.
    public const string cam_up = "cam_up";//向上.
    public const string cam_down = "cam_down";
    public const string cam_left = "cam_left";
    public const string cam_right = "cam_right";


    //托盘前后运动.
    public const string flot_foward = "flot_foward";
    public const string flot_back = "flot_back";

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
