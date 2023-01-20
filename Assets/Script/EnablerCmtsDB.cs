using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class EnablerCmtsDB
{
    public string welcome;
    public string brain_gym_thinking_caps;
    public string trip_to_the_field;
    public string addition;
    public string quick_math;
    public string introduction_addition;
    public string brain_gym_double_doodle;
    public string story_sum_practice_1;
    public string story_sum_practice_2;
    public string memory_game_activity;
    public string goodbye_song;

    public EnablerCmtsDB()
    {
        welcome = Main_Blended.OBJ_main_blended.enablerComments[0];
        brain_gym_thinking_caps = Main_Blended.OBJ_main_blended.enablerComments[1];
        trip_to_the_field = Main_Blended.OBJ_main_blended.enablerComments[2];
        addition = Main_Blended.OBJ_main_blended.enablerComments[3];
        quick_math = Main_Blended.OBJ_main_blended.enablerComments[4];
        introduction_addition = Main_Blended.OBJ_main_blended.enablerComments[5];
        brain_gym_double_doodle = Main_Blended.OBJ_main_blended.enablerComments[6];
        story_sum_practice_1 = Main_Blended.OBJ_main_blended.enablerComments[7];
        story_sum_practice_2 = Main_Blended.OBJ_main_blended.enablerComments[8];
        memory_game_activity = Main_Blended.OBJ_main_blended.enablerComments[9];
        goodbye_song = Main_Blended.OBJ_main_blended.enablerComments[10];
    }
}