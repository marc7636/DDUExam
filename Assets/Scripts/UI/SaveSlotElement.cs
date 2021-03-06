﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SaveSlotElement : MonoBehaviour
{
    public byte SaveSlot;
    public Text NumberText;
    public Text SaveText;

    GameObject player;

    void Start()
    {
        NumberText.text = SaveSlot.ToString();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Save()
    {
        PlayerData playerData = new PlayerData(2, SaveSlot.ToString());
        SavingFunctionality.SavePlayer(playerData, SaveSlot);
        UpdateData(playerData);
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