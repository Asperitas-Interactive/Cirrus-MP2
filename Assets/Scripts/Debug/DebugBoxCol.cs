using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugBoxCol : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
