using UnityEngine;

[CreateAssetMenu]
public class ChangeValue : ScriptableObject
{
    public FloatData Data;

    public void Addvalue (FloatData data)
    {
        data.Value += Data.Value;
    }
    public void Subtractvalue (FloatData data)
    {
        data.Value -= Data.Value;
    }

 }

