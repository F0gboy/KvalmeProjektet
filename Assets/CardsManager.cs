using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardsManager : MonoBehaviour
{
    public bool lang;
    [SerializeField] List<int> cardQueue = new List<int>();

    [HeaderAttribute("Card1")]
    [SerializeField] private TMP_Text Category1;
    [SerializeField] private TMP_Text Question1;
    [SerializeField] private TMP_Text BonusQuestion1;
    [SerializeField] private TMP_Text Answer1;
    [SerializeField] private TMP_Text BonusAnswer1;

    
    [HeaderAttribute("Card2")]
    [SerializeField] private TMP_Text Category2;
    [SerializeField] private TMP_Text Question2;
    [SerializeField] private TMP_Text BonusQuestion2;
    [SerializeField] private TMP_Text Answer2;
    [SerializeField] private TMP_Text BonusAnswer2;


    //[HeaderAttribute("TargetCard")]
    private TMP_Text Category;
    private TMP_Text Question;
    private TMP_Text BonusQuestion;
    private TMP_Text Answer;
    private TMP_Text BonusAnswer;


    public int id;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 35; i++)
        {
            cardQueue.Add(i);
        }
        cardQueue = Shuffle(cardQueue);

        GameObject temp = GameObject.FindGameObjectWithTag("Language");
        if (temp != null)
        {
            if (temp.GetComponent<LanguageScript>().langNum == 0) { lang = true; }
        }
        id = cardQueue[0];
        count = 0;

        Category = Category1;
        Question = Question1;
        BonusQuestion = BonusQuestion1;
        Answer = Answer1;
        BonusAnswer = BonusAnswer1;



        NewCard();
        NewCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewCard()
    {
        switch (id)
        {
            case 1:
                if (lang)
                {
                    
                    Category.text = "Patofysiologi";
                    Question.text = "N�r man taler om kvalme og opkastning i forbindelse med medicinsk kr�ftbehandling, taler man om 4 typer n�vn disse?";
                    BonusQuestion.text = "Hvorn�r i forl�bet opst�r de 4 typer?";
                    Answer.text = "� Akut kvalme og opkastning\r\n� Senkvalme og opkastning \r\n� Forventnings kvalme og opkastning\r\n� Refrakt�r kvalme og gennembrudskvalme";
                    BonusAnswer.text = "� Akut kvalme og opkastning opst�r 0-24 timer efter indgift\r\n � Senkvalme og opkastning  opst�r 24-120 timer efter ind-  \r\n   gift\r\n � Forventnings kvalme og opkastning opst�r inden opstart  \r\n   af ny serie\r\n � Refrakt�r kvalme og gennembrudskvalme opst�r uventet  \r\n  under og efter behandling p� trods af antiemetisk profylak- \r\n  se";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 2:
                if (lang)
                {

                    Category.text = "Patofysiologi";
                    Question.text = "Der findes andre �rsager til kvalme og opkast end medicinsk kr�ftbehandling. N�vn 4-5 �rsager";
                    BonusQuestion.text = "Kan du uddybe �rsagerne: sygdomsplacering, elektrolytbalance og medicin?";
                    Answer.text = "" +
                        "� Sygdommens placering � Smerter \r\n" +
                        "� Elektrolytbalance � Tr�thed \r\n" +
                        "� Medicin � Svampeinfektion i mund og hals\r\n" +
                        "� Metastaser � Obstipation \r\n" +
                        " � Sult � Str�leterapi\r\n" +
                        " � Dyspepsi � Anden sygdom";
                    BonusAnswer.text = "Sygdomsplacering: Ofte set ved sygdom i ventrikel, hepar, colon, cerebrum, pancreas\r\n Elektrolytbalance: Ved hypercalc�mi og hypermagnesi�mi \r\nMedicin: F.eks. morfika, antibiotika, digitalis";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 3:
                if (lang)
                {

                    Category.text = "Patofysiologi";
                    Question.text = "Der er flere faktorer der har indflydelse p� patientens risiko for at f� kvalme og opkastninger efter medicinskkr�ftbehandling. N�vn 5 faktorer";
                    BonusQuestion.text = "Kan du uddybe hvilken indflydelse alder, k�n og indtagelse af alkohol har p� forekomsten af kvalme og opkast?";
                    Answer.text = " � Den medicinske kr�ftbehandlings emetogene potentiale\r\n � Dosis og kombination af den medicinske kr�ftbehandling \r\n� Varighed af den medicinske kr�ftbehandling \r\n� K�n \r\n� Alder \r\n� H�jt alkoholforbrug  \r\n� Patientens psyke, opfattelse af sygdom og behandling \r\n� Tidligere erfaringer med kvalme";
                    BonusAnswer.text = "� Yngre har st�rre risiko < 55 �r\r\n � Kvinder har st�rre risiko\r\n � Kronisk �get alkoholforbrug giver mindre kvalme\r\n � K�resyge samt kvalme under graviditet, kan �ge risiko for  \r\n   kvalme under behandling";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 4:
                if (lang)
                {

                    Category.text = "Patofysiologi";
                    Question.text = "Kroppen opfatter medicinsk kr�ftbehandling som et giftstofvia receptorer f�lsomme for dette. Hvis disse receptorer bliver aktiveret kan det udl�se kvalme/opkastning. Hvordan fungerer antiemetika inde i kroppen? ";
                    BonusQuestion.text = " Hvor mange omr�der kan potentielt blive p�virket i CNS?";
                    Answer.text = "Antiemetika fungerer ved at blokere receptorer i centralnervesystemet og i GI kanalen der bliver aktiveret ved indgift af medicinsk kr�ftbehandling.";
                    BonusAnswer.text = "� Kemoreceptortriggerzonen (KTZ)\r\n � Nucleus tractus solitarius (NTS)\r\n � Br�kcentret (BC)";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 5:
                if (lang)
                {

                    Category.text = "Patofysiologi";
                    Question.text = "Patienter i medicinsk kr�ftbehandling kan ogs� opleve kvalme og opkastning der fremprovokeres af kendte eller ukendte stimuli. N�vn nogle af disse stimuli?";
                    BonusQuestion.text = "Reaktionerne kommer fra specifikke steder i kroppen, som kan blive p�virket af s�danne stimuli, hvilke?";
                    Answer.text = " � Lugte\r\n � Syn\r\n � Lyde \r\n� Tidligere erfaring med hospitaler eller medicinsk \r\n   kr�ftbehandling";
                    BonusAnswer.text = " � Cortex cerebri � hjernebarken\r\n � Det limbiske system � her h�ndteres hukommelse og  \r\n   f�lelseslivet \r\n� Vestibul�rapparatet - det indre �re";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 6:
                if (lang)
                {

                    Category.text = "Patofysiologi";
                    Question.text = "Br�kcentret modtager impulser fra KTZ og NTS samt fra gastrointestinalkanalen, hvor sender br�kcenteret sine signaler hen?";
                    BonusQuestion.text = "Hvordan behandles dette?";
                    Answer.text = " � Esophagus\r\n � Ventrikel\r\n � Diaphragma\r\n � Abdominalmuskler ";
                    BonusAnswer.text = "Antiemetika, alt efter behandlingens emetogene risiko, patientens kvalmeanamnese samt andre risikofaktorer.";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 7:
                if (lang)
                {

                    Category.text = "Patofysiologi";
                    Question.text = "Medicinsk kr�ftbehandling inddeles i 4 grupper alt efter deres emotogene potentiale n�vn de 4 grupper? ";
                    BonusQuestion.text = "Kan du n�vne, for hver gruppe, hvor stor en risiko der er for at f� kvalme (i %)";
                    Answer.text = " � Minimal emetogen \r\n� Lav emetogen\r\n � Moderat emetogen (MEC)\r\n � H�j emetogen (HEC)";
                    BonusAnswer.text = "� Minimal emetogen: 0-10%\r\n � Lav emetogen: 10-30%\r\n � Moderat emetogen (MEC): 30-90%\r\n � H�j emetogen (HEC): 90%";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 8:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "Hvilken medicin kan anvendes mod forventningskvalme? ";
                    BonusQuestion.text = "Hvorn�r skal patienten indtage den?";
                    Answer.text = "Lorazepam � 1 mg ";
                    BonusAnswer.text = "Lorazepam indtages til natten dagen f�r- og morgenen f�r behandling med medicinsk kr�ftbehandling.";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 9:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "Hvorn�r skal patienten senest indtage antiemetika inden behandling med medicinsk kr�ftbehandling? ";
                    BonusQuestion.text = "Hvorfor er det vigtigt?";
                    Answer.text = "Senest � - 1 time inden indgift af medicinsk kr�ftbehandling";
                    BonusAnswer.text = "Det er vigtigt at patienten har taget antiemetika �-1 time f�r behandling med medicinsk kr�ftbehandling s� kvalmereceptorerne er blokeret.";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 10:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "Hvilke 5 typer af antiemetika findes der?";
                    BonusQuestion.text = "Kan du n�vne pr�parater der tilh�rer de forskellige grupper?";
                    Answer.text = " � Dopaminreceptor-antagonister\r\n � Serotoninreceptor-antagonister \r\n� Neurokininreceptor-antagonister  \r\n� Multireceptor-antagonister \r\n� Kortikosteroider ";
                    BonusAnswer.text = "� Dopaminreceptor-antagonister: Domperidon, \r\n   Metopimazin Metoclopramid\r\n � Serotoninreceptor-antagonister: Ondansetron, \r\n   Palonosetron, Granisetron\r\n � Neurokininreceptor-antagonister: Aprepitant, Netupitant\r\n � Multireceptor-antagonister: Olanzapin\r\n � Kortikosteroider: Prednisolon, Methylprednisolon, \r\nDexamethason";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 11:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Ondansetron?";
                    BonusQuestion.text = "N�vn hvordan Ondansetron kan dispenseres?";
                    Answer.text = " � Obstipation\r\n � Hovedpine";
                    BonusAnswer.text = "� Oralt: Kan knuses eller opsl�mmes i vand. \r\n   Indtages uden hensyn til m�ltider\r\n � IV: 8-16 mg. Initialdosis m� ikke overskride 16 mg ved   \r\n   korttidsinfusion over 15 minutter\r\n � Suppositorie: 16 mg \r\n� Smelt: 4 mg � 8 mg ";

                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 12:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Palonosetron?";
                    BonusQuestion.text = "N�vn hvordan Palonosetron kan dispenseres?";
                    Answer.text = " � Hovedpine\r\n � Svimmelhed\r\n � Obstipation\r\n � Diarr�";
                    BonusAnswer.text = "� Oralt: Indtages hel. Indtages uden hensyntagen til \r\n   m�ltider\r\n � IV: Intraven�s Palonosteron: 0,25 mg svarer til 0,5 mg  \r\n   peroral Palonosetron";

                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 13:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Aprepritant?";
                    BonusQuestion.text = "N�vn hvordan Aprepritant kan dispenseres?";
                    Answer.text = " � Hikke\r\n � Forh�jet levertransaminaser \r\n� Dyspepsi\r\n � Obstipation\r\n � Hovedpine\r\n � Nedsat appetit\r\n � Tr�thed";
                    BonusAnswer.text = "� Oralt\r\n� IV";


                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 14:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Netupitant-Palonosetron \r\n(NEPA)?";
                    BonusQuestion.text = "N�vn hvordan NEPA kan dispenseres?";
                    Answer.text = " � Hovedpine\r\n � Obstipation\r\n � Tr�thed";
                    BonusAnswer.text = "� Oralt: Kapslen indtages hel. Indtages uden hensyntagen til \r\n   m�ltider";

                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 15:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Olanzapin?";
                    BonusQuestion.text = "N�vn hvordan kan det dispenseres?";
                    Answer.text = "" +
                        " � D�sighed  � Glykosuri\r\n" +
                        " � V�gt�gning � �get appetit\r\n" +
                        " � Eosinofili � Svimmelhed\r\n" +
                        " � Hyperprolaktin�mi � Ortostatisk hypotension\r\n" +
                        " � Hyperglyk�mi � Antikolinerge symptomer";
                    BonusAnswer.text = "� Oralt: Kan knuses eller opsl�mmes i vand. Indtages uden  \r\n   hensyn til m�ltider\r\n � Smelt ";

                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 16:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = " Hvilke bivirkninger opleves ofte ved Prednisolon � n�vn 5?";
                    BonusQuestion.text = "N�vn hvordan Prednisolon kan dispenseres?";
                    Answer.text = " � Uro og s�vnl�hed\r\n � R�dme og blussende ansigt \r\n� �get appetit og v�gt�gning \r\n� Dyspepsi";
                    BonusAnswer.text = "� Oralt: Kan knuses eller opsl�mmes i vand \r\n� IV: Methylprednisolon: 40 mg, svarer til 50 mg peroral Prednisolon";

                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 17:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Lorazepam?";
                    BonusQuestion.text = "N�vn hvordan kan det dispenseres?";
                    Answer.text = "" +
                        " � Tr�thed � Ataksi\r\n" +
                        " � D�sighed � Depression\r\n" +
                        " � Sedation � Konfusion\r\n" +
                        " � Kraftesl�shed � Svimmelhed\r\n" +
                        " � Muskelsvaghed";
                    BonusAnswer.text = "� Oralt: Delek�rv, det vil sige at dosis kan deles \r\n� Lorazepam � 1 mg max 1 mg i d�gnet";


                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 18:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Metopimazin?";
                    BonusQuestion.text = "Hvordan kan det dispenseres?";
                    Answer.text = "" +
                        " � Mundt�rhed  � Svimmelhed\r\n" +
                        " � Let sedation  � Symptomer p� hyperprolaktin�mi \r\n" +
                        " � Obstipation specielt ved   � Urinretention\r\n" +
                        "   kombination med seroton  � Ekstrapyrimidale bivirkninger\r\n" +
                        "   inantagonister\r\n" +
                        " � Ortostatisk hypotension";
                    BonusAnswer.text = "� Moderat- og h�jemetogen behandling = 30 mg x 4, i 4 dage \r\n� Lavemetogen behandling = 15 mg x 4, i 4 dage";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 19:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Domperidon?";
                    BonusQuestion.text = " � Agitation\r\n � Angst\r\n � Ekstrapyramidale gener\r\n � Nerv�sitet\r\n � Somnolens\r\n � Svimmelhed";
                    Answer.text = "N�vn hvordan kan det dispenseres?";
                    BonusAnswer.text = "Oralt: Kan knuses eller opsl�mmes i vand. Indtages f�r \r\nm�ltider.";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 20:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 21:
                if (lang)
                {

                    Category.text = "Kvalmeanamese";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 22:
                if (lang)
                {

                    Category.text = "Kvalmeanamese";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }   
                break;
            case 23:
                if (lang)
                {

                    Category.text = "Kvalmeanamese";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 24:
                if (lang)
                {

                    Category.text = "Kvalmeanamese";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 25:
                if (lang)
                {

                    Category.text = "Kvalmeanamese";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 26:
                if (lang)
                {

                    Category.text = "Kvalmeanamese";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 27:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 28:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 29:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 30:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 31:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 32:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 33:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;
            case 34:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "";
                    BonusQuestion.text = "";
                    Answer.text = "";
                    BonusAnswer.text = "";
                }
                break;

            default:
                break;
        }

        count++;
        if (count > 34)
        {
            count = 0;
        }
        id = cardQueue[count];

        if (Category == Category1)
        {
            Category = Category2;
            Question = Question2;
            BonusQuestion = BonusQuestion2;
            Answer = Answer2;
            BonusAnswer = BonusAnswer2;
        }
        else
        {
            Category = Category1;
            Question = Question1;
            BonusQuestion = BonusQuestion1;
            Answer = Answer1;
            BonusAnswer = BonusAnswer1;
        }
    }



    private List<int> Shuffle(List<int> ts)
    {
        var count = ts.Count;
        var last = count - 1;
        for (var i = 0; i < last; ++i)
        {
            var r = UnityEngine.Random.Range(i, count);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }
        return ts;
    }
}
