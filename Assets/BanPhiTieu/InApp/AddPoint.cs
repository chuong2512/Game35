using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        GameDataManager.Instance.playerData.AddPoint(1);
    }
}