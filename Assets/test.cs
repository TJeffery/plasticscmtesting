using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Dog puppy = new Dog("Zelda", "Husky");
    public Cat kitten = new Cat("Link", "Literllay Satan");

    public void Start()
    {
        print(puppy.whatIsIt());
        print(kitten.whatIsIt());
    }

}

