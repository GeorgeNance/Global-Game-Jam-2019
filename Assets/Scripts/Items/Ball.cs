﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : InteractObject {
    public override void Interact(GameObject player)
    {
        player.GetComponent<PlayerStuff>().hasBall = true;
		Destroy(this.gameObject);
    }
}
