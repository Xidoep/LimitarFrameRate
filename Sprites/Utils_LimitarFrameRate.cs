using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XS_Utils;


[CreateAssetMenu(menuName = "Xido Studio/Utils/Limitar FrameRate", fileName = "Limitar FrameRate")]
public class Utils_LimitarFrameRate : ScriptableObject
{
    const string KEY_GUARDAT_FARMERATE = "FrameRate";
    [SerializeField] Guardat guardat;
    //3-12
    [SerializeField] int frameRate;
    


    private void OnEnable()
    {
        Debugar.Log("OnEnable - Utils_LimitarFrameRate");
        //frameRate = (int)guardat.Get(KEY_GUARDAT_FARMERATE, 6);
        Application.targetFrameRate = frameRate * 10;
    }

    [ContextMenu("LimitarFrameRate")]
    void LimitarFrameRate() => LimitarFrameRate(frameRate);
    public void LimitarFrameRate(float frameRate) => LimitarFrameRate((int)frameRate);
    public void LimitarFrameRate(int frameRate) 
    {
        Application.targetFrameRate = frameRate * 10;
        //guardat.SetLocal(KEY_GUARDAT_FARMERATE, (int)frameRate);
    } 





    void OnValidate()
    {
        frameRate = Mathf.Clamp(frameRate, 30, 120);
    }
}