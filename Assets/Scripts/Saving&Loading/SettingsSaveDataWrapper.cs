[System.Serializable]
public class SettingsSaveDataWrapper
{
    public bool VSync;
    public bool UseController;
    public byte LatestSaveSlot;

    public SettingsSaveDataWrapper(bool vSync, bool useController, byte latestSaveSlot)
    {
        this.VSync = vSync;
        this.UseController = useController;
        this.LatestSaveSlot = latestSaveSlot;
    }
}