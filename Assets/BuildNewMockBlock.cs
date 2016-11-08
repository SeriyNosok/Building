using UnityEngine;
using System.Collections;

public class BuildNewMockBlock : Action
{
    public override void Use()
    {
        Instantiate(gameObject.transform.parent, gameObject.transform.position + gameObject.transform.localPosition, gameObject.transform.localRotation);
    }
}
