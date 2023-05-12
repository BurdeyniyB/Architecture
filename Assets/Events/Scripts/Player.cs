using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class Player : MonoBehaviour
{
    //public delegate void MyDelegate();
    //public event MyDelegate myEvent;

    public static Action onTouched;
    public static Action<string> onTouched1;// можна додати декілька аргументів
    public string messege;
    public static Func<string, string> onTouched2; //в кінці завжди тип який повертається
    public string funcMessege;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"i {onTouched2?.Invoke(funcMessege)}");
        onTouched?.Invoke();
        onTouched1?.Invoke(messege);
        EventBus.onTest?.Invoke();
    }
}
