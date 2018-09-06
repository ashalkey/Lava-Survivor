using System;
using UnityEngine;

[Serializable]
public class MovingPlatform : MonoBehaviour
{
    [Serializable]
    public enum MovementTransferOnJump
    {
        None,
        InitTransfer,
        PermaTransfer,
        PermaLocked
    }

    public new bool enabled;

    public MovementTransferOnJump movementTransfer;

    [NonSerialized]
    public Transform hitPlatform;

    [NonSerialized]
    public Transform activePlatform;

    [NonSerialized]
    public Vector3 activeLocalPoint;

    [NonSerialized]
    public Vector3 activeGlobalPoint;

    [NonSerialized]
    public Quaternion activeLocalRotation;

    [NonSerialized]
    public Quaternion activeGlobalRotation;

    [NonSerialized]
    public Matrix4x4 lastMatrix;

    [NonSerialized]
    public Vector3 platformVelocity;

    [NonSerialized]
    public bool newPlatform;

    public MovingPlatform()
    {
        this.enabled = true;
        this.movementTransfer = MovementTransferOnJump.PermaTransfer;
    }
}