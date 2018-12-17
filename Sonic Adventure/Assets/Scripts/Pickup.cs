﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pickup : MonoBehaviour {

    public Text RingsAmount;
    public int count;
    public AudioSource RingPick;

	// Use this for initialization
	void Start () {
        count = 0;
        SetRings();
        RingPick.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            RingPick.Play(0);
            Destroy(other.gameObject);
            count = count + 1;
            SetRings();
            //Debug.Log(count);
        }
    }

    public void SetRings()
    {
        RingsAmount.text = "" + count;
    }
}
