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
               ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ameila";
                Char2speech.text = "Howdy!";
        }
       else if (primeInt == 3){
                Char1name.text = "YOU";
                Char1speech.text = "Thank god, a human at last. What is your name?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ameila";
                Char2speech.text = "Can’t you read, it is Ameila Earhart.";
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
                Char2name.text = "Ameila";
                Char2speech.text = "Sorry, no can do. I love it here and don’t want to back to the hustle and bustle of life. You should join me.";
        }

       else if (primeInt == 10){
                Char1name.text = "YOU";
                Char1speech.text = "I need to get back to my family!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
                NextScene1Button.SetActive(true);
        }

        else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ameila";
                Char2speech.text = "Sorry, no can do. I love it here and don’t want to back to the hustle and bustle of life. You should join me.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
                NextScene1Button.SetActive(true);
        }

// 1b Dialogue 
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ameila";
                Char2speech.text = "Are you talking to me?";
        }
       else if (primeInt == 14){
                Char1name.text = "YOU";
                Char1speech.text = "Sort of, how old are you?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ameila";
                Char2speech.text = "About 126 years old.";
        }
       else if (primeInt == 16){
                Char1name.text = "YOU";
                Char1speech.text = "That is impossible.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ameila";
                Char2speech.text = "Diet and exercise is all it takes.";
        }
       else if (primeInt == 18){
                Char1name.text = "YOU";
                Char1speech.text = "I need to keep looking for a way off this island.";
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
                Char1speech.text = "Does that plane work?  Can you fly me back to civilization?";
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
                Char1speech.text = "I must have hit my head harder than I thought. Talking animals. Now I run into Amelia freaking Earhart.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 12;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
                // Goes to the Lemur
               SceneManager.LoadScene("Scene6");
        }
        public void SceneChange2(){
                // Goes to Death Scene MAYBE?
                SceneManager.LoadScene("End_Lose");
        }
}