using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Rendering.PostProcessing;

public class TreasureHunter : MonoBehaviour
{
    OVRCameraRig oVRCameraRig;

    OVRManager oVRManager;

    OVRHeadsetEmulator oVRHeadsetEmulator;

    Camera viewPointCamera;

    /*PostProcessLayer postProcessLayer;
    LocomotionHandler locomotionHandler;
    public Inventory inv;
    public Collectable Collectable1;
    Start is called before the first frame update*/

    int currentTotalScore;
    int currentTotalTreasures;
    void Start()
    {
       //inv = new Inventory();
       //Collectable1 = new Collectable();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            this.gameObject.GetComponent<Inventory>().setInv(0, (GameObject.Find("Hunted1").GetComponent<Collectable>()));
        Debug.Log("1");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2)){
            this.gameObject.GetComponent<Inventory>().setInv(1, (GameObject.Find("Hunted2").GetComponent<Collectable>()));
        Debug.Log("2");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3)){
            this.gameObject.GetComponent<Inventory>().setInv(2, (GameObject.Find("Hunted3").GetComponent<Collectable>()));
        Debug.Log("3");
        }

         if (Input.GetKeyDown(KeyCode.Alpha4)){
            CalculateScore();
            int tScore=currentTotalScore;
            int tTreas=currentTotalTreasures;
            GameObject.Find("ScoreMessage").GetComponent<TextMesh>().text=("Anthony Doban\n"+"score = "+tScore+"\ncount = "+tTreas+" treasures");
        Debug.Log("4");
    }
         if (CalculateScore()==111){
            GameObject.Find("WinMessage").GetComponent<TextMesh>().text=("you win");  //make it so u can keep playing
            }
        
    }

    // Update is called once per frame
    int CalculateScore(){
        Collectable[] collTreasure = this.gameObject.GetComponent<Inventory>().hunterInventory;
        int totalScore=0;
        int treasureAmt=0;
        foreach (Collectable treasure in collTreasure){
            if (treasure!=null){
                treasureAmt+=1;
                totalScore+=treasure.points;
            }
        }
        currentTotalScore=totalScore;
        currentTotalTreasures=treasureAmt;
        return totalScore;
        
    
        
    }
    
}

