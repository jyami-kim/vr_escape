﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select5 : MonoBehaviour {
    
    public Image myImage;
    public Sprite mySecondImage;
    public Image noneUsing;

    public void bigImage()
    {
        if (imageChange5.a == 1){
             myImage.sprite = mySecondImage;
            noneUsing.sprite = mySecondImage;
            openerselect.i = 0;
        }
       

    }
}
