using UnityEngine;
using System.Collections;

public class BuildNewBlocks : Action {
    public override void Use()
    {
            Instantiate(gameObject, gameObject.transform.position + new Vector3(1.0f,0,0), Quaternion.identity);
    }
}