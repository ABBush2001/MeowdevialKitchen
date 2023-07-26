using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;

    private float baseIntensity1;
    private float baseIntensity2;
    private float intensityRange1;
    private float intensityRange2;
    private float intensityTimeMin;
    private float intensityTimeMax;


    // Start is called before the first frame update
    void Start()
    {
        baseIntensity1 = light1.GetComponent<Light>().intensity;
        baseIntensity2 = light2.GetComponent<Light>().intensity;
        intensityRange1 = 0.05f;
        intensityRange2 = 0.05f;
        intensityTimeMin = 0.001f;
        intensityTimeMax = 0.005f;

        StartCoroutine(FlickIntensity());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator FlickIntensity()
    {
        float t0 = Time.time;
        float t = t0;
        WaitUntil wait = new WaitUntil(() => Time.time > t0 + t);
        yield return new WaitForSeconds(Random.Range(0.01f, 0.5f));

        while (true)
        {
            t0 = Time.time;
            float r1 = Random.Range(baseIntensity1 - intensityRange1, baseIntensity1 + intensityRange1);
            float r2 = Random.Range(baseIntensity2 - intensityRange2, baseIntensity2 + intensityRange2);
            light1.GetComponent<Light>().intensity = r1;
            light2.GetComponent<Light>().intensity = r2;
            t = Random.Range(intensityTimeMin, intensityTimeMax);
            yield return wait;
         }
    }
}
