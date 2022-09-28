using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideShowObject : MonoBehaviour
{
    public GameObject ourSphere;
    public GameObject ourCylinder;

    public void hideSphere()
    {
        ourSphere.SetActive(false);
    }
    public void showShpere()
    {
        ourSphere.SetActive(true);
    }
    public void hideCylinder()
    {
        ourCylinder.SetActive(false);
    }
    public void showCylinder()
    {
        ourCylinder.SetActive(true);
    }

}
