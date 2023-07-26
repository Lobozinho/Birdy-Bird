using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrowButton : ArrowButton
{
    protected override void OnClick()
    {
        this.birdSelect.PreviousBird();
    }
}
