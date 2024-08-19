using UnityEngine;



[CreateAssetMenu(fileName = "newPlayerData", menuName = "Data/PlayerData/BaseData")]
public class PlayerData : ScriptableObject
{
    [Header("Move State")]
    public float movementVelocity = 10f;
}
