using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrowButton : ArrowButton
{
    protected override void OnClick()
    {
        this.birdSelect.NextBird();
    }
}
