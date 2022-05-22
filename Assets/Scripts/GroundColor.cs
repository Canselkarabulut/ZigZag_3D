using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColor : MonoBehaviour
{
    [SerializeField] GameObject ground;
    public static float _colorCount;
    private void FixedUpdate()
    {
        GroundColors();
    }
    public void GroundColors()
    {
        if (Score.score >= 10 )
        {
            switch (_colorCount)
            {
                case 0:
                    ground.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case 1:
                    ground.GetComponent<Renderer>().material.color = Color.yellow;
                    break;
                case 2:
                    ground.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case 3:
                    ground.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case 4:
                    ground.GetComponent<Renderer>().material.color = Color.gray;
                    break;
                case 5:
                    ground.GetComponent<Renderer>().material.color = Color.black;
                    break;
                case 6:
                    ground.GetComponent<Renderer>().material.color = Color.cyan;
                    break;
                case 7:
                    ground.GetComponent<Renderer>().material.color = Color.magenta;
                    break;
                case 8:
                    _colorCount = 0;
                    break;
            }
        }
    }
}
