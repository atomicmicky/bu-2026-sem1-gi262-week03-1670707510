using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OOPExit : Identity
{
    public GameObject youWin;
    public override void Hit()
    {
        youWin.SetActive(true);
    }
}