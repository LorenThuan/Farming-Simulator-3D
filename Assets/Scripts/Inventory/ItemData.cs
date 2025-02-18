using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Items/Item")]
public class ItemData : ScriptableObject
{
    public string description;

    public Sprite thumbnail;

    public GameObject gameModel;

    public int cost;

    public int purchasePrice;

    public override string ToString()
    {
        return base.ToString();
    }
}
