using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadUI : MonoBehaviour
{
    public LoadSlotElement Save1;
    public LoadSlotElement Save2;
    public LoadSlotElement Save3;

    public PlayerData currentPlayer;

    void Start()
    {
        Save1.SaveSlot = 1;
        Save2.SaveSlot = 2;
        Save3.SaveSlot = 3;
        UpdateList();
    }

    void UpdateList()
    {
        PlayerData[] saves = SavingFunctionality.GetSaves();
        if (saves[0] != null)
        {
            Save1.UpdateData(saves[0]);
        }
        else
        {
            Save1.DisplayEmptySlot();
        }

        if (saves[1] != null)
        {
            Save2.UpdateData(saves[1]);
        }
        else
        {
            Save2.DisplayEmptySlot();
        }

        if (saves[2] != null)
        {
            Save3.UpdateData(saves[2]);
        }
        else
        {
            Save3.DisplayEmptySlot();
        }
    }
}
