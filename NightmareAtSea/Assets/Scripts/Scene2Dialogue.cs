using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour {
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
                Char2name.text = "Cory";
                Char2speech.text = "Hi, I am Cory and I am looking for my friend Nimwit. He is a little smaller than me and has orange and white stripes.";
        }
       else if (primeInt == 3){
                Char1name.text = "YOU";
                Char1speech.text = "No, sorry, I have not seen him.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cory";
                Char2speech.text = "Hi, I am Cory and I am looking for my friend Nimwit.";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cory";
                Char2speech.text = " He is a little smaller than me and has orange and white stripes.";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()        
        }
//        else if (primeInt == 6){
//                 Char1name.text = "";
//                 Char1speech.text = "";
//                 Char2name.text = "Seagull";
//                 Char2speech.text = "Perhaps you should get out more and see the world.";
//                 // Turn off "Next" button, turn on "Choice" buttons
//                 nextButton.SetActive(false);
//                 allowSpace = false;
//                 Choice1a.SetActive(true); // function Choice1aFunct()
//                 Choice1b.SetActive(true); // function Choice1bFunct()
//         }

// ENCOUNTER AFTER CHOICE #1
// 1a Dialogue 
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cory";
                Char2speech.text = "Sorry, I am very forgetful.  What are you doing out here on the reef?";
        }
       else if (primeInt == 8){
                Char1name.text = "YOU";
                Char1speech.text = "I am trying to swim to one of those islands.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cory";
                Char2speech.text = "Be careful, there are a lot of sharks nearby.";
        }
       else if (primeInt == 10){
                Char1name.text = "YOU";
                Char1speech.text = "What, did you say sharks?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cory";
                Char2speech.text = "Yes, Sharks. Don’t worry though, they told me they want friends, not food.";
        }
       else if (primeInt == 12){
                Char1name.text = "YOU";
                Char1speech.text = "This does not sound like a very good idea.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 13){
                ArtChar1c.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cory";
                Char2speech.text = "I hope you are a fast swimmer.";
        }
       else if (primeInt == 14){
                Char1name.text = "YOU";
                Char1speech.text = "You are making me very nervous.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
                NextScene1Button.SetActive(true);
        }
// 1b Dialogue 
       else if (primeInt == 16){
                ArtChar1c.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cory";
                Char2speech.text = "He was probably swimming in the East Australian Current. Thanks, I will try to catch them.";
        }
       else if (primeInt == 17){
                Char1name.text = "YOU";
                Char1speech.text = "Good luck.";
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
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I just said no to that question.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 6;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Yes, I saw him with a bunch of other fish swimming very quickly.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 15;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
                // Goes to the Lemur
               SceneManager.LoadScene("Scene3");
        }
        public void SceneChange2(){
                // Goes to Death Scene MAYBE?
                SceneManager.LoadScene("Scene10");
        }
}