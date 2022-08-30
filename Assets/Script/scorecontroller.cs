using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scorecontroller : MonoBehaviour
{
    public Text scoreKiri;
    public Text scoreKanan;
    public score manager;
 
    private void Update()
    {
        scoreKiri.text = manager.leftScore.ToString();
        scoreKanan.text = manager.rightScore.ToString();
    }
}
