using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Collectable[] hunterInventory;
    /*public Inventory(){
        hunterInventory=new Collectable[3];
    
    }
    public Collectable[] getInv(){
        return hunterInventory;
    }
    */
    public void setInv(int place, Collectable value){
        hunterInventory[place]=value;

    }
    public Collectable getInv(int place){
        return hunterInventory[place];
    }
    // Update is called once per frame
    
}
