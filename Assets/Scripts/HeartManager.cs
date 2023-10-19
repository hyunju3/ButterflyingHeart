using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;


public class HeartManager : MonoBehaviour
{
    //1
    private VisualEffect visualEffect;
    //2
    private VFXEventAttribute eventAttribute;// 게임 오브젝트
    //3
    private bool heartsAreFlying;
    //4
    private int flyingBoolID;

    void Awake()
    {
        //1
        visualEffect = GetComponent<VisualEffect>();
        eventAttribute = visualEffect.CreateVFXEventAttribute();
        //2
        flyingBoolID = Shader.PropertyToID("Flying");
        //3
        heartsAreFlying = false;
        //4
        visualEffect.SetBool(flyingBoolID, false);
        //5
        visualEffect.Stop();
    }

    void Start()
    {
        
    }

    void Update()
    {
        //1
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnHearts();
        }
        //2
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleHeartFlight();
        }
    }

    private void SpawnHearts()
    {
        // VFX 스폰 함수로 사용(vfx 가져오기)
        visualEffect.Play();
    }

    private void ToggleHeartFlight()
    {
        // heartsAreFlying => bool로 사용 
        // 날고있지 않으면 날고 있는걸로 바꿔주어라
        // false = true;
        //1
        heartsAreFlying = !heartsAreFlying;
        //2
        visualEffect.SetBool(flyingBoolID, heartsAreFlying);
    }
}
