using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6Dialogue : MonoBehaviour {
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
               ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Oompa";
                Char2speech.text = "Oompa Loompa Doompadee doo, I’ve got a perfect puzzle for you.";
        }
       else if (primeInt == 3){
                Char1name.text = "YOU";
                Char1speech.text = "Pardon me, excuse me.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Oompa";
                Char2speech.text = "Oh, hi there. How can I help you?";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
//        else if (primeInt == 5){
//                 Char1name.text = "YOU";
//                 Char1speech.text = "That is old. Do you have any advice for me about this island?";
//                 Char2name.text = "";
//                 Char2speech.text = "";
//                 //gameHandler.AddPlayerStat(1);
//         }
//        else if (primeInt == 6){
//                 Char1name.text = "";
//                 Char1speech.text = "";
//                 Char2name.text = "Turtle";
//                 Char2speech.text = "To have enough of enough is always enough.";

//         }

// ENCOUNTER AFTER CHOICE #1
// 1a Dialogue 
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Oompa";
                Char2speech.text = "No thanks, the last person I helped took all my Cocoa Beans!";
        }

       else if (primeInt == 10){
                Char1name.text = "YOU";
                Char1speech.text = "I don’t need any Cocoa Beans. I just want to get off this island.";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Oompa";
                Char2speech.text = "Good luck with that.";
        }
        else if (primeInt == 12){
                Char1name.text = "YOU";
                Char1speech.text = "So, you can’t help me?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Oompa";
                Char2speech.text = "I wouldn’t say I can’t help you.";
        }
        else if (primeInt == 14){
                Char1name.text = "YOU";
                Char1speech.text = "So, you can help me?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Oompa";
                Char2speech.text = "I wouldn’t say that either.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
                NextScene1Button.SetActive(true);
        }

// 1b Dialogue 
       else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Oompa";
                Char2speech.text = "Did you talk to a talking Sea Gull?";
        }
       else if (primeInt == 18){
                Char1name.text = "YOU";
                Char1speech.text = "Yes.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Oompa";
                Char2speech.text = "Did you talk to a wise old turtle?";
        }
       else if (primeInt == 20){
                Char1name.text = "YOU";
                Char1speech.text = "Yes.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Oompa";
                Char2speech.text = "Then I agree, you are crazy.";
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
                Char1speech.text = "Can you help me get off this island.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 8;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "This is crazy. I can’t believe I am talking to an Oompa Loompa.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 16;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
                // Goes to the Lemur
               SceneManager.LoadScene("Scene7");
        }
        public void SceneChange2(){
                // Goes to Death Scene MAYBE?
                SceneManager.LoadScene("Scene10");
        }
}