using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SimpleTween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMove(new Vector3(10.0f, 10.0f, 10.0f), 25.0f);

        Sequence seq = DOTween.Sequence();
        
        seq.Append(transform.DORotate(new Vector3(0.0f, 3600.0f, 0.0f), 2.5f, RotateMode.FastBeyond360)).SetEase(Ease.InOutCubic)
        .Append(transform.DOScale(new Vector3(5.0f, 5.0f, 5.0f), 0.8f)).SetEase(Ease.InCubic)
        .Append(transform.DOScale(new Vector3(1.0f, 1.0f, 1.0f), 2.0f)).SetEase(Ease.InCubic);
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
