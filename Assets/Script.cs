using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform pointA, pointB, pointC, test;
    //[SerializeField] private Transform pointA, pointB, pointC, pointD, test;
    [SerializeField] private float timer, totalTimer;
    //[SerializeField] private AnimationCurve animationCurve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //timer2 += Time.deltaTime;
        var line1 = Vector2.Lerp(pointA.position, pointB.position, timer / totalTimer);
        var line2 = Vector2.Lerp(pointB.position, pointC.position, timer / totalTimer);
        var line3 = Vector2.Lerp(line1, line2, timer / totalTimer);
        test.transform.position = line1 = line3;

        //timer += Time.deltaTime;
        //var line1 = Vector2.Lerp(pointA.position, pointB.position, pointC, animationCurve.Evaluate(timer / totalTimer));
        //test.transform.position = line1;
    }
}
