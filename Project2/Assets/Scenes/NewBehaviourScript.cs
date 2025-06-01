using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
