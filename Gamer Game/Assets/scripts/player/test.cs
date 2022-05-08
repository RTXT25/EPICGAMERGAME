using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour{

    public float rot=0f;
    public float speed= 1f;
    
    void Start(){
        float rot = Camera.main.transform.localEulerAngles.y;
        transform.rotation = Quaternion.Euler(0f, rot, 0f);
        Vector3 moveDir = Quaternion.Euler(0f, rot, 0f) * Vector3.forward;
        //transform.localPosition =Quaternion.Euler(1f, 1f, 1f);
        Destroy(gameObject, 0.5f);
    }
}
