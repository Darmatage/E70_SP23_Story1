using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4Dialogue : MonoBehaviour {
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
               ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Turtle";
                Char2speech.text = "Hello, what is your name?";
        }
       else if (primeInt == 3){
                Char1name.text = "YOU";
                Char1speech.text = "I can't remember. What about you?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Turtle";
                Char2speech.text = "Most people call me the 'Wise Old Turtle' since I am over one thousand years old!";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "That is old. Do you have any advice for me about this island?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Turtle";
                Char2speech.text = "To have enough of enough is always enough.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// ENCOUNTER AFTER CHOICE #1
// 1a Dialogue 
       else if (primeInt == 9){
                ArtChar1c.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Turtle";
                Char2speech.text = "Doing things in moderation will lead to happiness.";
        }

       else if (primeInt == 10){
                Char1name.text = "YOU";
                Char1speech.text = "I will keep that in mind if I ever get off this island.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Turtle";
                Char2speech.text = "That is a big if. Good luck!";
        }
       else if (primeInt == 12){
                Char1name.text = "YOU";
                Char1speech.text = "That seems ominous.";
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
                Char2name.text = "Turtle";
                Char2speech.text = "Early to bed and early to rise makes a man healthy, wealthy and wise.";
        }
       else if (primeInt == 14){
                ArtChar1c.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Do you only talk in riddles?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Turtle";
                Char2speech.text = "Riddles, I do talk.";
        }
       else if (primeInt == 16){
                Char1name.text = "YOU";
                Char1speech.text = "What are you, a Yoda wanna be.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Turtle";
                Char2speech.text = "Yoda, I am.";
        }
       else if (primeInt == 18){
                Char1name.text = "YOU";
                Char1speech.text = "Thanks for nothing. This has not been helpful.";
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
                ArtChar1a.SetActive(false);
                ArtChar1c.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "What does that mean?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 8;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                ArtChar1a.SetActive(false);
                ArtChar1c.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "That is not really helpful. If you are so wise, please tell me how to get off this island!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 12;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
                // Goes to Amelia
               SceneManager.LoadScene("Scene5");
        }
        public void SceneChange2(){
                // Goes to Death Scene MAYBE?
                SceneManager.LoadScene("Scene10");
        }
}