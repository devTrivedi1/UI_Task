using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform emptyContainer;
    void Awake()
    {
        entryContainer = transform.Find("");
    }
}
