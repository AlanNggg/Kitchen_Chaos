using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string IS_WALKING = "IsWalking";
    [SerializeField] private Player player;
    private Animator animatior;

    private void Awake()
    {
        animatior = GetComponent<Animator>();
       
    }

    private void Update()
    {
        animatior.SetBool(IS_WALKING, player.IsWalking());
    }
}
