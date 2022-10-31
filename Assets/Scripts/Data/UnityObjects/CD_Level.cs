using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CD_Level", menuName = "Picker3D/CD_Level", order = 1)]
public class CD_Level : ScriptableObject
{
    public List <LevelData> levels = new List <LevelData>();
}
