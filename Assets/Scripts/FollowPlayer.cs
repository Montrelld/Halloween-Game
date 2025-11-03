using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Gargoyle;
    private Vector3 offset = new Vector3(0, 1.47f, -2.42f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Gargoyle.transform.position + offset;
    }
}
