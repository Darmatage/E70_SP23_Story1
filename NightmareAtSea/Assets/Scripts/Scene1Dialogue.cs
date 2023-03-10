using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 0;         // This integer drives game progress!
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
        public GameObject theDarkness;

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
                theDarkness.SetActive(true);
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                StartCoroutine(FadeOut(theDarkness));

               ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "Hello, what is your name?";
        }
       else if (primeInt == 3){
                theDarkness.SetActive(false);

                Char1name.text = "YOU";
                Char1speech.text = "Whoa, you can talk?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "Of course, I can talk. Haven’t you ever seen a talking Seagull before?";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "No, never.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "Perhaps you should get out more and see the world.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "Well, I’m glad you made it. At least I have someone to talk to.";
                primeInt = 14;
        }
//        else if (primeInt == 101){
//                 Char1name.text = "";
//                 Char1speech.text = "";
//                 Char2name.text = "Seagull";
//                 Char2speech.text = "Come back here! Do not think you can hide from me!";
//                 nextButton.SetActive(false);
//                 allowSpace = false;
//                 NextScene1Button.SetActive(true);
//         }

       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "Have you looked in a  mirror lately? You don’t look much better.";
                primeInt = 14;
        }
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "At least you fared better than this half-frozen person.";
        }
       else if (primeInt == 16){
                Char1name.text = "YOU";
                Char1speech.text = "That is very sad to see.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "Don’t pity him too much I don’t think he was very smart.";
        }
       else if (primeInt == 18){
                Char1name.text = "YOU";
                Char1speech.text = "That is not very nice. Besides, why do you say that?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "I found him holding on to this door. That door could easily have held two people.  There was no need for anyone to die.";
        }
       else if (primeInt == 20){
                Char1name.text = "YOU";
                Char1speech.text = "True. By the way, where am I and is there a way out of here?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "Well, you can explore the island or swim to another island. Unless you can fly?";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
                NextScene1Button.SetActive(true);

        }

        else if (primeInt == 16){
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "Seagull";
                Char2speech.text = "At least you fared better than this half-frozen person.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
	//KEEP THE MOST HOLY FINAL BRACKETT:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I was trying to but my Ship sank.";
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
                Char1speech.text = "What do you know? You’re just a  flying a  rat!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 10;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2");
        }

        IEnumerator FadeIn(GameObject fadeImage){
                float alphaLevel = 0;
                fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel += 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                } 
        } 

        IEnumerator FadeOut(GameObject fadeImage){
                float alphaLevel = 1;
                fadeImage.GetComponent<Image>().color = new Color(0.01f, 0.01f, 0.01f, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel -= 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(0.01f, 0.01f, 0.01f, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                } 
        }
}