using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LoadSlotElement : MonoBehaviour
{
    public byte SaveSlot;
    public Text NumberText;
    public Text SaveText;

    private void Start()
    {
        NumberText.text = SaveSlot.ToString();
    }

    public void Load()
    {
        PlayerData playerData = SavingFunctionality.LoadPlayer(SaveSlot);
        //Load player data
    }

    public void DisplayEmptySlot()
    {
        SaveText.text = "Empty";
    }

    public void UpdateData(PlayerData playerData)
    {
        SaveText.text = playerData.HelperString;
    }
}