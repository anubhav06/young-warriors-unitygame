using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class LocalizedText : MonoBehaviour {

    public enum language { English, German, French, Spanish, Russian }
    public language setLanguage;

    public enum word { QuickPlay, HowToPlay, Credits, ExtraLinks, Back, HowToPlayDETAILS, Anubhav, DevelopedBy, Thanksto, ThanksToNAMES, Supporters, SupportersNAMES, Patreon, PatreonDETAILS, FeebackForm, FeedbackFormDETAILS, Player1, Player2, GameOver, SinglePlayer, TwoPlayer, SinglePlayerDetails, TwoPlayerDetails, HowToDetails}
    public word setWord;

    //Insert in array number of langages and number of words in array
    string[,] names = new string[5, 24] {                              //No of  languages, No of words

         { "Quick Play","How To Play","Credits","Extra Links","Back"," The rules are simple. Spawn different troops by using your respective controls. Reduce the opponents health by sending your troops across the opponents sides. The first player to bring the health to 0 wins the game.\n\n Controls:\n Player 1: Mouse \n Player 2: Number Keys ","Anubhav","Developed By:"," Thanks to:","Andrey \n Asbjørn \n Jayanam \n Michael","Supporters","John","Patreon","Support me on Patreon and get applicable rewards","Feedback Form:","Fill out a quick feedback form of 4 questions","Player 1","Player 2","Game Over"," Single Player"," 2 Player"," Play with the computer BOT. \n But, beware as it is not easy and only a few can win against him."," Play with your partner on the same keyboard. \n Show them who is the best." , "                   Player1                                                                                Player2 \n\n\n ~Spawn troops by clicking the buttons                        ~Spawn troops by number \n   as shown below:                                                              keys as shown below: \n\n\n\n\n\n ~The health bar shifts as the troops passes the enemy's base line. Shift the bar \n towards enemies side to win the game. \n\n\n ~Press Esc or P to pause the game."}, //English  
         { "Schnelles Spiel", "Spielanleitung", "Credits", "Zusätzliche Links","Zurück"," Die Regeln sind einfach. Bringe verschiedene Truppen hervor, indem du die jeweiligen Kontrollen verwendest. Reduziere die Gesundheit deines Gegners, indem du deine Truppen auf die gegnerische Seite schickst. Der erste Spieler, der die Gesundheit auf 0 bringt, gewinnt das Spiel.\n\n Kontrollen: \n Spieler 1: Maus \n Spieler 2: Zifferntasten ","Anubhav","Entwickelt von:","Dank an:","Andrey \n Asbjørn \n Jayanam \n Michael","Unterstützer","John","Patreon","Unterstütze mich bei Patreon und erhalte passende Belohnungen","Feedback-Formular:","Füllen Sie ein schnelles Feedback-Formular mit 4 Fragen aus "," Spieler 1"," Spieler 2","Spiel ist aus"," Einzelspieler "," 2 Spieler"," Spielen Sie mit dem Computer BOT. \n Aber Vorsicht, es ist nicht einfach und nur wenige können gegen ihn gewinnen."," Spielen Sie mit Ihrem Partner auf derselben Tastatur. \n Zeig ihnen, wer der Beste ist." , "                   Spieler1                                                                                Spieler2 \n\n\n ~Bringe Truppen hervor, indem du auf die Schaltflächen klickst                        ~ Truppen nach Anzahl spawnen \n   Wie nachfolgend dargestellt:                                                              Tasten wie unten gezeigt: \n\n\n\n\n\n ~ Die Gesundheitsanzeige verschiebt sich, wenn die Truppen die Basislinie des Feindes überschreiten. Den Balken verschieben  \n gegen feindliche Seite, um das Spiel zu gewinnen. \n\n\n ~Press Esc or P to pause the game."}, //German 
         { "Jeu rapide","Comment jouer","Crédits","Liens supplémentaires","Retour"," Les règles sont simples. Générer des troupes différentes en utilisant vos contrôles respectifs. Réduisez la santé de vos adversaires en envoyant vos troupes de part et d'autre Le premier joueur à ramener la santé à 0 gagne la partie. \n \n  Les contrôles: \n Joueur 1: souris \n Joueur 2: Touches numériques ","Anubhav","Développé par:","Grâce à:","Andrey \n Asbjørn \n Jayanam \n Michael","Partisans","John","Patreon","Soutenez-moi sur Patreon et obtenez les récompenses applicables","Formulaire de commentaires:","Remplissez un formulaire de commentaires rapide de 4 questions "," Joueur 1"," Joueur 2","Jeu terminé"," Un joueur"," 2 joueurs"," Jouez avec l'ordinateur BOT. \n Mais attention, ce n’est pas facile et seuls quelques-uns peuvent gagner contre lui."," Jouez avec votre partenaire sur le même clavier. \n Montrez-leur qui est le meilleur." , "Nothing For Now" }, //French  
         { "Juego rápido", "Cómo jugar", "Creditos", "Enlaces Extra","Espalda"," Las reglas son simples. Engendra diferentes tropas usando tus respectivos controles. Reduce la salud de los oponentes enviando tus tropas a través de los lados de los oponentes. El primer jugador en llevar la salud a 0 gana el juego.\n\n Controles: \n Jugador 1: Ratón \n Jugador 2: Teclas numéricas ","Anubhav","Desarrollado por:","Gracias a:","Andrey \n Asbjørn \n Jayanam \n Michael","Partidarios","John","Patreon","Apóyame en Patreon y obtén recompensas aplicables","Formulario de comentarios:"," Rellene un formulario de comentarios rápido de 4 preguntas"," Jugador 1"," Jugador 2","Juego terminado"," Un solo jugador"," 2 jugadores"," Juega con la computadora BOT. \n Pero ten cuidado, ya que no es fácil y solo unos pocos pueden ganar contra él."," Juega con tu compañero en el mismo teclado. \n Muéstrales quién es el mejor." , "Nothing For Now" }, //Spanish
         { "Быстрая игра ","Как играть"," кредиты"," Дополнительные ссылки", " назад"," Правила просты. Создайте разные войска, используя соответствующие элементы управления. Уменьшите здоровье противников, отправив свои войска через стороны противников. Первый игрок, который принес здоровье 0, выигрывает игру.\n\n Управление: \n игрок 1: мышь  \n игрок 2: цифровые клавиши"," Анубхав"," Разработан:"," Благодаря:"," Андрей \n Асбьерн \n Джаянам \n Майкл"," Сторонники"," Джон"," Patreon","Поддержите меня на Patreon и получите соответствующие награды "," Форма для обратной связи:"," Заполните форму быстрой обратной связи из 4 вопросов"," Игрок 1"," Игрок 2"," Игра окончена"," Один игрок"," 2 игрока"," Играй с компьютером BOT. \n Но будьте осторожны, так как это нелегко, и лишь немногие могут победить его."," Играйте со своим партнером на одной клавиатуре. \n Покажите им, кто является лучшим." , "Nothing For Now"} //Russian
    };

    // Update is called once per frame
    void Update()
    {
        //Online code to change language:
        this.GetComponent<TextMeshProUGUI>().text = names[(int)setLanguage, (int)setWord];


        //IF its english/any other language set language to that language:

        if (GameObject.Find("LanguageChangeManager").GetComponent<SelectLanguage>().english==true)
        {
            setLanguage = language.English;
        }
        else if(GameObject.Find("LanguageChangeManager").GetComponent<SelectLanguage>().german == true)
        {
            setLanguage = language.German;
        }
        else if (GameObject.Find("LanguageChangeManager").GetComponent<SelectLanguage>().french == true)
        {
            setLanguage = language.French;
        }
        else if (GameObject.Find("LanguageChangeManager").GetComponent<SelectLanguage>().spanish == true)
        {
            setLanguage = language.Spanish;
        }
        else if (GameObject.Find("LanguageChangeManager").GetComponent<SelectLanguage>().russian == true)
        {
            setLanguage = language.Russian;
        }


    }
}
