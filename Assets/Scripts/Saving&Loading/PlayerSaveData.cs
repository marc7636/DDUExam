using System;
using System.Security.Cryptography;

[Serializable]
class PlayerSaveWrapper
{
    public PlayerData PlayerSaveData;
    public byte SaveSlot;

    public PlayerSaveWrapper(PlayerData player, byte saveSlot)
    {
        PlayerSaveData = player;
        this.SaveSlot = saveSlot;
    }
}

[Serializable]
public class PlayerData
{
    public int Health;
    public string HelperString = "";
    public PlayerData(int health, string helperString)
    {
        this.Health = health;
        this.HelperString = helperString;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}