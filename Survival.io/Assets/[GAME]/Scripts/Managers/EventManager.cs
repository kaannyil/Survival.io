using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    /*public static UnityEvent enemyMovementAnimation = new UnityEvent();
    public static UnityEvent enemyAttackAnimation = new UnityEvent();
     */
    public static UnityEvent OnCharacterOutRunning = new UnityEvent();
    public static UnityEvent OnCharacterInRunning = new UnityEvent();
    public static UnityEvent OnCharacterOutIdle = new UnityEvent();
    public static UnityEvent OnCharacterInIdle = new UnityEvent();
    public static UnityEvent OnEnemyDying = new UnityEvent();
}
