﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : InteractObject
{

    public override void Interact(GameObject player)
    {
       Debug.Log("Box clicked") ;
    }
}