using System;
using UnityEngine;

[Serializable]
public class Question 
{
    public string[] Answers = new string[4];
    public Sprite PhotoPlace;
    public int TrueAnswer;
}
