using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       public GameObject ArtChar1b;
       public GameObject ArtChar1c;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
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
        NextScene3Button.SetActive(false);
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
                Char2name.text = "Lemur";
                Char2speech.text = "Step right up! What can I get you?";
        }
       else if (primeInt == 3){
                Char1name.text = "YOU";
                Char1speech.text = "What is this place?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lemur";
                Char2speech.text = "It is kind of like a 7-Eleven but without the slurpees. Do you see anything you like?";
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
                Char2name.text = "Lemur";
                Char2speech.text = "I stick to tree bark and leaves mostly. Of course, you can’t go wrong with water.";
        }
       else if (primeInt == 7){
                Char1name.text = "YOU";
                Char1speech.text = "What can you tell me about the other options?";
                Char2name.text = "";
                Char2speech.text = "";
       }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lemur";
                Char2speech.text = "The other two options are world famous and people fight over them.";
        }
       else if (primeInt == 9){
                Char1name.text = "YOU";
                Char1speech.text = "What do they taste like?";
                Char2name.text = "";
                Char2speech.text = "";
       }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lemur";
                Char2speech.text = "I think they taste like chicken. You should give them a try.";
        }
       else if (primeInt == 11){
                Char1name.text = "YOU";
                Char1speech.text = "That sounds suspicious.";
                Char2name.text = "";
                Char2speech.text = "";
       }
       else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lemur";
                Char2speech.text = "Has a lemur ever led you astray?";
        }
       else if (primeInt == 13){
                Char1name.text = "YOU";
                Char1speech.text = "There is a first time for everything.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 17;
       }

// 1b Dialogue 
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lemur";
                Char2speech.text = "Of course, I would never lead you astray.";
        }
       else if (primeInt == 16){
                Char1name.text = "YOU";
                Char1speech.text = "I don’t know if I should trust a talking Lemur.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lemur";
                Char2speech.text = "Suit yourself, the store will be open all day long.";
        }
// a & b Dialogue 
       else if (primeInt == 18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lemur";
                Char2speech.text = "Well, here is what I have in stock.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene3Button.SetActive(true);
                NextScene2Button.SetActive(true);
                NextScene1Button.SetActive(true);
        }
	//KEEP THE MOST HOLY FINAL BRACKETT:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I am hungry. What do you recommend?";
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
                Char1speech.text = "Is this safe to eat? This island has been nothing but a nightmare for me.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 14;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene4");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene10");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene10");
        }
}