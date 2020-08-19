using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharactor : MonoBehaviour
{
    public GameObject TargetCharactor;
    
    void LateUpdate(){
        this.transform.position = new Vector3(TargetCharactor.transform.position.x,9,TargetCharactor.transform.position.z);
    }
}
