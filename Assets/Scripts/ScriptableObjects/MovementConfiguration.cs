using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomMovementConfiguration", menuName = "Configurations/MovementConfiguration")]
public class MovementConfiguration : ScriptableObject
{
    [SerializeField, Range(0, 50), Tooltip("Player velocity modifier")]
    private float _velocityModifier = 10;
    public float velocityModifier => _velocityModifier;

    [SerializeField, Range(500, 5000)]
    private float _jumpForce = 1000;
    public float jumpForce => _jumpForce;

}
