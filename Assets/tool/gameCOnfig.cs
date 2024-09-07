using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Game Configuration")]
public class GameCOnfig : ScriptableObject
{
    public List<levelconfig> levels = new List<levelconfig>();
}