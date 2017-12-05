using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyClass : MonoBehaviour
{
    public GameObject blobLightProjector;
    public GameObject blobShadowProjector;
    public GameObject gridProjector;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            blobLightProjector.SetActive(true);
            blobShadowProjector.SetActive(false);
            gridProjector.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            blobLightProjector.SetActive(false);
            blobShadowProjector.SetActive(true);
            gridProjector.SetActive(false);

        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            blobLightProjector.SetActive(false);
            blobShadowProjector.SetActive(false);
            gridProjector.SetActive(true);

        }

        if(Input.GetKey(KeyCode.W))
        {
            //위.
            this.transform.localPosition += Vector3.forward.normalized * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //왼쪽.
            this.transform.localPosition += -Vector3.right.normalized * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            //아래.
            this.transform.localPosition += -Vector3.forward.normalized * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            //오른쪽.
            this.transform.localPosition += Vector3.right.normalized * Time.deltaTime;

        }

    }
}
