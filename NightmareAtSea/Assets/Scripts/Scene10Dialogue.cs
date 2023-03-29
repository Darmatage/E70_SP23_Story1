using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene10Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       public GameObject ArtChar1b;
       public GameObject ArtChar1c;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		 ArtChar1b.SetActive(false);
		 ArtChar1c.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

     // Find the gameHandler:
     // gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       next();
                }
        }
   }

//Story Units! This is the main story function. Players hit [NEXT] to progress to the next primeInt:
public void next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                ArtChar1c.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Attendant";
                Char2speech.text = "Are you ok? I heard someone screaming.";
        }
       else if (primeInt == 3){
                Char1name.text = "YOU";
                Char1speech.text = "What? I must have been having a nightmare. Thank goodness. I thought I was trapped on an island.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Attendant";
                Char2speech.text = "Was it inhabited?";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "Yes, I talked to a Seagull, a fish, and a Lemur. I even met Amelia Earhart.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                ArtChar1c.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Attendant";
                Char2speech.text = "That was some dream!";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// ENCOUNTER AFTER CHOICE #1
// 1a Dialogue 
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Attendant";
                Char2speech.text = "They say some dreams are a window into the past.";
        }

       else if (primeInt == 9){
                Char1name.text = "YOU";
                Char1speech.text = "Is that sand on the floor?";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt == 10){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Attendant";
                Char2speech.text = "How did that get there?";
        }

        else if (primeInt == 11){
                Char1name.text = "YOU";
                Char1speech.text = "What is that in my pants pocket?";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Attendant";
                Char2speech.text = "Check it out.";
        }

        else if (primeInt == 13){
                Char1name.text = "YOU";
                Char1speech.text = "OMG, it is the gold coin from the treasure chest!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                if (GameHandler.oneCoin == true){ NextScene1Button.SetActive(true); }
                else { NextScene2Button.SetActive(true); }
                // NextScene2Button.SetActive(true);
                // NextScene1Button.SetActive(true);
        }

// 1b Dialogue 
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Attendant";
                Char2speech.text = "Trust me, it wasn’t real.";
        }

       else if (primeInt == 16){
                Char1name.text = "YOU";
                Char1speech.text = "How am I supposed to trust anyone?";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt == 17){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Attendant";
                Char2speech.text = "It was just a nightmare you fool.";
        }

       else if (primeInt == 18){
                Char1name.text = "YOU";
                Char1speech.text = "I sure hope so. That was scary. I hope this doesn’t happen again.";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Attendant";
                Char2speech.text = "Good luck with that.";
                nextButton.SetActive(false);
                allowSpace = false;
                if (GameHandler.oneCoin == true){ NextScene1Button.SetActive(true); }
                else { NextScene2Button.SetActive(true); }


                // NextScene2Button.SetActive(true);
                // NextScene1Button.SetActive(true);
        }

	//KEEP THE MOST HOLY FINAL BRACKETT:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "It all seemed so real.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 7;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "It all seemed so real.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 14;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
                // Goes to the Caves
               SceneManager.LoadScene("End_Win");
        }
        public void SceneChange2(){
                // Goes to Death Scene MAYBE?
                SceneManager.LoadScene("End_Lose");
        }
}