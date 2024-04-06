using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class ResetValues : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioSource AudioSource2;
    public Dictionary<string,Vector3> newVals = new Dictionary<string, Vector3>();
    public Dictionary<string, Vector3> rot = new Dictionary<string, Vector3>();
    public Dictionary<string, Vector3> scal = new Dictionary<string, Vector3>();
    // Start is called before the first frame update
    void Start()
    {
        newVals.Clear();
        foreach (Transform tr in transform)
        {
            newVals.Add(tr.name,tr.localPosition);
            rot.Add(tr.name,tr.eulerAngles);
            scal.Add(tr.name,tr.localScale);
        };
    }

    // Update is called once per frame
    public  void ButtonClicked()
    {
        int ii = 0;
        foreach (Transform tt in transform)
        {
            tt.localPosition = newVals[tt.name];
            tt.eulerAngles = rot[tt.name];
            tt.localScale = scal[tt.name];
            Debug.Log(newVals[tt.name] + " " + rot[tt.name] + " " + scal[tt.name]);
            ii++;
        }
        AudioSource.Play();
    }
    public void planeClicked()
    {
        AudioSource2.Play();
    }
    void Update()
    {
        
    }
}
