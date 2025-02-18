using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameSaveState
{
    public List<LandSaveState> landData;
    public List<CropSaveState> cropData;

    public ItemSlotSaveData[] toolSlots;
    public ItemSlotSaveData[] itemSlots;

    public ItemSlotSaveData equippedItemSlot;
    public ItemSlotSaveData equippedToolSlot;

    public GameTimestamp timestamp;

    public int money;

    public List<NPCRelationshipState> relationships;

    public GameSaveState(
        List<LandSaveState> landData,
        List<CropSaveState> cropData, 
        ItemSlotData[] toolSlots, 
        ItemSlotData[] itemSlots, 
        ItemSlotData equippedItemSlot, 
        ItemSlotData equippedToolSlot, 
        GameTimestamp timestamp, 
        int money, 
        List<NPCRelationshipState> relationships)
    {
        this.landData = landData;
        this.cropData = cropData;
        this.toolSlots = ItemSlotData.SerializeArray(toolSlots);
        this.itemSlots = ItemSlotData.SerializeArray(itemSlots);
        this.equippedItemSlot = ItemSlotData.SerializeData(equippedItemSlot);
        this.equippedToolSlot = ItemSlotData.SerializeData(equippedToolSlot);
        this.timestamp = timestamp;
        this.money = money;
        this.relationships = relationships;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
