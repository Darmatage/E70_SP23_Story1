using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene7Dialogue : MonoBehaviour {
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
                ArtChar1b.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "Impressive. You made it this far.";
        }
       else if (primeInt == 3){
                Char1name.text = "YOU";
                Char1speech.text = "How did you get here?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "I flew. You really are not very smart.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }


// ENCOUNTER AFTER CHOICE #1
// 1a Dialogue 
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "It does not matter. They all lead to the same place.";
        }

       else if (primeInt == 7){
                Char1name.text = "YOU";
                Char1speech.text = "What is up with all the riddles on this island?";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "That is not a riddle, that is a fact.";
        }
       else if (primeInt == 9){
                Char1name.text = "YOU";
                Char1speech.text = "Whatever, I will try them one at a time.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 10){
                ArtChar1c.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "Good luck with that.";
        }
        else if (primeInt == 11){
                Char1name.text = "YOU";
                Char1speech.text = "Not again, with the good luck.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
                NextScene1Button.SetActive(true);
        }

// 1b Dialogue 
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "Not necessarily.";
        }
       else if (primeInt == 14){
                Char1name.text = "YOU";
                Char1speech.text = "Are you saying I might die?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "We will all die at some point.";
        }
       else if (primeInt == 16){
                Char1name.text = "YOU";
                Char1speech.text = "Sure, but I don’t want to die today, which opening should I avoid.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 17){
                ArtChar1c.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "Listen. I am here just for the entertainment.";
        }
       else if (primeInt == 18){
                Char1name.text = "YOU";
                Char1speech.text = "Thanks for nothing";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
                NextScene1Button.SetActive(true);
        }

	//KEEP THE MOST HOLY FINAL BRACKETT:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){

                Char1name.text = "YOU";
                Char1speech.text = "Which cave should I explore?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 5;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Will I die if I go into one of these caves?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 12;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
                // Goes to the Caves
               SceneManager.LoadScene("Scene8a");
        }
        public void SceneChange2(){
                // Goes to Death Scene MAYBE?
                SceneManager.LoadScene("Scene8b");
        }
}