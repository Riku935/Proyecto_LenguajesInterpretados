using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    private string input;
    public void ReadString(string s)
    {
        input = s;
        Debug.Log(input);
        GameManager.obj.addText(input);
    }
}
