using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene8aDialogue : MonoBehaviour {
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
                Char1name.text = "YOU";
                Char1speech.text = "What the heck is all of this.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Volleyball";
                Char2speech.text = "Thank goodness. Are you here to save me?";
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "No, I am lost myself.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Volleyball";
                Char2speech.text = "That is too bad. I need to get off this island.";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Volleyball";
                Char2speech.text = "I'm from Amazon Prime and I am way beyond the 2 day delivery window.";
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
                Char2name.text = "Volleyball";
                Char2speech.text = "Nothing now, the last person emptied it. I think it was a GPS finder, satellite phone, and batteries.";
        }

       else if (primeInt == 9){
                Char1name.text = "YOU";
                Char1speech.text = "WHAT!?!. That would be so helpful. Did the person leave anything?";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt == 10){
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Volleyball";
                Char2speech.text = "I think there are some ice skates in the corner.";
        }
       else if (primeInt == 11){
                Char1name.text = "YOU";
                Char1speech.text = "This is a waste of my time. I am out of here.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Volleyball";
                Char2speech.text = "See ya at the Oscars.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
                NextScene1Button.SetActive(true);
        }

// 1b Dialogue 
       else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Volleyball";
                Char2speech.text = "Not into sports, huh. You should think about getting more exercise.";
        }
       else if (primeInt == 15){
                Char1name.text = "YOU";
                Char1speech.text = "This is a waste of my time. I am out of here.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Volleyball";
                Char2speech.text = "Good luck with that.";
        }
       else if (primeInt == 17){
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Stop. Please stop saying good luck like that.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Volleyball";
                Char2speech.text = "Ok fine. I curse you and your family for all of eternity. Happy now?";
        }
       else if (primeInt == 19){
                Char1name.text = "YOU";
                Char1speech.text = "Now, I am not so sure.";
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
                Char1speech.text = "Do you have anything that can help me get off this island? What is in that box for example?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 7;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                ArtChar1c.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I am not talking to a volleyball. This is crazy.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 13;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
                // Goes to the Caves
               SceneManager.LoadScene("Scene9");
        }
        public void SceneChange2(){
                // Goes to Death Scene MAYBE?
                SceneManager.LoadScene("Scene8b");
        }
}