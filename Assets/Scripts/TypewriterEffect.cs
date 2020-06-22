using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypewriterEffect : MonoBehaviour
{

    public TextMesh txt;
    string story;
    public bool typewithouteffect;





    void Awake()

    {

        if (this.gameObject.name == "TextContent")

        {
            story = "Welcome to Jan's Zeitreise.\nFollow his journey through time in \n" +
             "Elbe. He is a four year old carp\nliving near Landungsbrücken.\nPress Enter to start the game.\nPress Space to read the story.";
        }

        else if (this.gameObject.name == "TextContent-Show-more")
        {


            story = "Jan is a four years old carp fish living near \n" +
                "Landungsbrücken in Elbe. He has been through a lot of\n" +
                " ups and downs this year. Just a couple months\n" +
                "ago both his parents were caught by a fisherman.\n" +
                "Just a week after that his pregnant wife died of illness.\n" +
                " The condition of his fellow carps is more or less the same. \n" +
                "Jan has been dismal ever since and feels this is the worst \n" +
                "time that ever was or ever will be."+

"That is when he met the wise old Frau Ida, the eel who\n"+
                "lives under the big grey rock. Legend is that"+
                "she has been here for more than a hundred years"+
                "and knows the secrets of this river that nobody else does."+

"Frau Ida tells Jan that nothing is permanent in this world.Change is the only"+
                "constant.These certainly are bad times.She knows it will get\n" +
                " worse in the future but only to transform into something better after\n" +
                " that.Jan isn’t able to understand so Frau Ida takes him to the magical \n" +
                "corner of the mighty river Elbe.Here he can travel through a magical \n" +
                "tunnel to the future and see how the world changes itself.However,\n" +
                "the journey is bound to be excruciating.Jan is still determined and \n" +
                "Frau Ida has promised that she would guide him all the way till the end."+
                "\nPress Enter to start the game.";
        }


        else if (this.gameObject.name == "TextContent-level-1")
        {

           
            story = "You start your journey with Elbe in the 1800's. \n" +
                "The river isn’t as pristine as before but still" +
                "\nretains its color and shine. You are in the canals\n" +
                "of Speicherstadt with boats loading and unloading the\n" +
                "cargo above your head. Move ahead. Explore. \n" +
                "Find the passage to your next goal."+
                "\nPress Enter to proceed.";
        }

        else if (this.gameObject.name == "TextContent-level-2")
        {

          
            story = "Well done Jan. You solved the riddle and now you are \n" +
                "transported to the 1900's. " + "A tunnel is being built \ndeep under " +
                "you to make the cars pass through. \n" + "Can you hear the construction" +
                "workers? \nOur Elbe is worse than before.\n\n" +
                "Look around. Feel the change." +
                "\nFind your way to the next era." +
                "\nPress Enter to proceed.";
        }
        else if (this.gameObject.name == "TextContent-level-3")

        {
            story = "I’m proud of you Jan. You’ve successfully reached the 2000's.\n" +
                "Our city Hamburg is now the second largest harbor in\n" +
                "Europe receiving around 8000 ships each year.\n" +
                "Alas! This has brought only gloom for us river beings.\n" +

                "They’ve dug our beds more than 12 meters deep.\n"+
                "Most of our kind are dead or dying.\n\nMove around." +
                "See if you can swim at all. \n" +
                "Pass the hurdles and meet me at the end." +
                "\nPress Enter to proceed.";

        }

        else if (this.gameObject.name == "TextContent-epilogue")

        {
            story = "Oh Jan, don’t be so upset. This is not the end. Some \n" +
                "good humans are protesting for our cause. Asking their\n" +
                "leaders to make laws against our exploitation. River \nbeings " +
                "will rise in number again. Elbe’s bed will get \ngreener again." +
                "Its waters will have more oxygen than poison. Soon. Very soon.\n\n" +

"For now, let’s go back to the time where we \n" +
                "actually belong. Let the people of the 2000's\n" +
                "ponder on what they’ve done. "; 

            ;
        }


        txt = GetComponent<TextMesh>();
       // story = txt.text;
        txt.text = "";

        // TODO: add optional delay when to start
       

        if (typewithouteffect == true)

        {

            DisplayWithoutTypewriterEffect();
        }

        else

        { StartCoroutine("PlayText"); }

    }

    private void DisplayWithoutTypewriterEffect()
    {
        txt.text = story;
    }

    IEnumerator PlayText()
    {
        foreach (char c in story)
        {
            txt.text += c;
            yield return new WaitForSeconds(0.125f);
        }
    }

}


