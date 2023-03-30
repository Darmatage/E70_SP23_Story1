using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene9Dialogue : MonoBehaviour {
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
        public AudioSource audioSource;
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
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pirate";
                Char2speech.text = "Boo!";
                
                
        }
       else if (primeInt == 3){
                Char1name.text = "YOU";
                Char1speech.text = "Ahhhhh!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pirate";
                Char2speech.text = "Did I scare you?";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "Yes!!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jack";
                Char2speech.text = "That is what we do! My name is Jack Sparrow, what is yours?";
        }
       else if (primeInt == 7){
                Char1name.text = "YOU";
                Char1speech.text = "I didn’t think ghosts are real.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                ArtChar1a.SetActive(false);
                ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jack";
                Char2speech.text = "You probably didn’t think animals could talk either.";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jack";
                Char2speech.text = "Idiot.";
        }
       else if (primeInt == 10){
                Char1name.text = "YOU";
                Char1speech.text = "What is inside that ship?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jack";
                Char2speech.text = "Oh, nothing.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// ENCOUNTER AFTER CHOICE #1
// 1a Dialogue 
       else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jack";
                Char2speech.text = "You don’t want to go in there since it is really dark and has no windows. You won’t be able to see a thing.";
        }

       else if (primeInt == 17){
                Char1name.text = "YOU";
                Char1speech.text = "I can take a torch so I can see something.";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt == 18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jack";
                Char2speech.text = "I would advise against that.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
                NextScene1Button.SetActive(true);
        }

// 1b Dialogue 
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jack";
                Char2speech.text = "That is my favorite room. That is where all the rum is held! Drink up!";
        }
       else if (primeInt == 14){
                Char1name.text = "YOU";
                Char1speech.text = "Oh wow! I thought for sure that the rum would be gone!";
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
                ArtChar1c.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "What is inside the door on the right?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 15;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                ArtChar1c.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "What is inside the door on the left?";
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
               SceneManager.LoadScene("Scene10");
        }
        public void SceneChange2(){
                // Goes to Death Scene MAYBE?
                SceneManager.LoadScene("Scene10");
        }
}