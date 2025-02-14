﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event01 : Event
{
    // 01_BookEvent.Player.Ani.AudioSourse 

    Vector3 defaultVector;

    public override void Awake()
    {
        base.Awake();

        defaultVector = Config[(int)eConfig.PLAY].transform.position;
    }

    public override void DangerStart()
    {
        base.DangerStart();

        Config[(int)eConfig.PLAY].transform.position = new Vector3(transform.position.x, defaultVector.y);
    }

    public override void DangerUpdate()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x, gameObject.transform.position.y);
    }
    
    public override void PlayStart()
    {
        base.PlayStart();
    }
}
