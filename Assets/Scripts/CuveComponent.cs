using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuveComponent : MonoBehaviour
{
    public GameManager gameManager;

    public new Transform transform;
    public Animator ani;

    [Header("Commons")]
    public MeshRenderer[] renderers;
    public GameObject hat;
    public Transform firePoint;

    [Header("Player Stats")]
    public int health;
    public float healthRegen;
    [Space(10f)]
    public int attackPoint;
    public float attackSpd;
    public float attackDelay;
    [Space(10f)]
    public float moveSpd;
    public float rotSpd;
    [Space(10f)]
    public float jumpAmount;
    public bool isJump;

    [Header("Information")]
    public new string name;
    [TextArea(3,5)]
    public string desc;

    [Header("Resize Datas")]
    [Range(0.5f,1.5f)]
    public float resizeAmoint;
    public Vector3 minSize;
    public Vector3 maxSize;
}
