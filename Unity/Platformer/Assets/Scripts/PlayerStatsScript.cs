using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStatsScript {

    public static int gems = 0;
    public static int life = 3;
    public static int score = 0;

    public static void setToDefault()
    {
        gems = 0;
        life = 3;
        score = 0;
    }
}
