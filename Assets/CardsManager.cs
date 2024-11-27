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
                    Question.text = "Når man taler om kvalme og opkastning i forbindelse med medicinsk kræftbehandling, taler man om 4 typer nævn disse?";
                    BonusQuestion.text = "Hvornår i forløbet opstår de 4 typer?";
                    Answer.text = "• Akut kvalme og opkastning\r\n• Senkvalme og opkastning \r\n• Forventnings kvalme og opkastning\r\n• Refraktær kvalme og gennembrudskvalme";
                    BonusAnswer.text = "• Akut kvalme og opkastning opstår 0-24 timer efter indgift\r\n • Senkvalme og opkastning  opstår 24-120 timer efter ind-  \r\n   gift\r\n • Forventnings kvalme og opkastning opstår inden opstart  \r\n   af ny serie\r\n • Refraktær kvalme og gennembrudskvalme opstår uventet  \r\n  under og efter behandling på trods af antiemetisk profylak- \r\n  se";
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
                    Question.text = "Der findes andre årsager til kvalme og opkast end medicinsk kræftbehandling. Nævn 4-5 årsager";
                    BonusQuestion.text = "Kan du uddybe årsagerne: sygdomsplacering, elektrolytbalance og medicin?";
                    Answer.text = "" +
                        "• Sygdommens placering • Smerter \r\n" +
                        "• Elektrolytbalance • Træthed \r\n" +
                        "• Medicin • Svampeinfektion i mund og hals\r\n" +
                        "• Metastaser • Obstipation \r\n" +
                        " • Sult • Stråleterapi\r\n" +
                        " • Dyspepsi • Anden sygdom";
                    BonusAnswer.text = "Sygdomsplacering: Ofte set ved sygdom i ventrikel, hepar, colon, cerebrum, pancreas\r\n Elektrolytbalance: Ved hypercalcæmi og hypermagnesiæmi \r\nMedicin: F.eks. morfika, antibiotika, digitalis";
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
                    Question.text = "Der er flere faktorer der har indflydelse på patientens risiko for at få kvalme og opkastninger efter medicinskkræftbehandling. Nævn 5 faktorer";
                    BonusQuestion.text = "Kan du uddybe hvilken indflydelse alder, køn og indtagelse af alkohol har på forekomsten af kvalme og opkast?";
                    Answer.text = " • Den medicinske kræftbehandlings emetogene potentiale\r\n • Dosis og kombination af den medicinske kræftbehandling \r\n• Varighed af den medicinske kræftbehandling \r\n• Køn \r\n• Alder \r\n• Højt alkoholforbrug  \r\n• Patientens psyke, opfattelse af sygdom og behandling \r\n• Tidligere erfaringer med kvalme";
                    BonusAnswer.text = "• Yngre har større risiko < 55 år\r\n • Kvinder har større risiko\r\n • Kronisk øget alkoholforbrug giver mindre kvalme\r\n • Køresyge samt kvalme under graviditet, kan øge risiko for  \r\n   kvalme under behandling";
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
                    Question.text = "Kroppen opfatter medicinsk kræftbehandling som et giftstofvia receptorer følsomme for dette. Hvis disse receptorer bliver aktiveret kan det udløse kvalme/opkastning. Hvordan fungerer antiemetika inde i kroppen? ";
                    BonusQuestion.text = " Hvor mange områder kan potentielt blive påvirket i CNS?";
                    Answer.text = "Antiemetika fungerer ved at blokere receptorer i centralnervesystemet og i GI kanalen der bliver aktiveret ved indgift af medicinsk kræftbehandling.";
                    BonusAnswer.text = "• Kemoreceptortriggerzonen (KTZ)\r\n • Nucleus tractus solitarius (NTS)\r\n • Brækcentret (BC)";
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
                    Question.text = "Patienter i medicinsk kræftbehandling kan også opleve kvalme og opkastning der fremprovokeres af kendte eller ukendte stimuli. Nævn nogle af disse stimuli?";
                    BonusQuestion.text = "Reaktionerne kommer fra specifikke steder i kroppen, som kan blive påvirket af sådanne stimuli, hvilke?";
                    Answer.text = " • Lugte\r\n • Syn\r\n • Lyde \r\n• Tidligere erfaring med hospitaler eller medicinsk \r\n   kræftbehandling";
                    BonusAnswer.text = " • Cortex cerebri – hjernebarken\r\n • Det limbiske system – her håndteres hukommelse og  \r\n   følelseslivet \r\n• Vestibulærapparatet - det indre øre";
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
                    Question.text = "Brækcentret modtager impulser fra KTZ og NTS samt fra gastrointestinalkanalen, hvor sender brækcenteret sine signaler hen?";
                    BonusQuestion.text = "Hvordan behandles dette?";
                    Answer.text = " • Esophagus\r\n • Ventrikel\r\n • Diaphragma\r\n • Abdominalmuskler ";
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
                    Question.text = "Medicinsk kræftbehandling inddeles i 4 grupper alt efter deres emotogene potentiale nævn de 4 grupper? ";
                    BonusQuestion.text = "Kan du nævne, for hver gruppe, hvor stor en risiko der er for at få kvalme (i %)";
                    Answer.text = " • Minimal emetogen \r\n• Lav emetogen\r\n • Moderat emetogen (MEC)\r\n • Høj emetogen (HEC)";
                    BonusAnswer.text = "• Minimal emetogen: 0-10%\r\n • Lav emetogen: 10-30%\r\n • Moderat emetogen (MEC): 30-90%\r\n • Høj emetogen (HEC): 90%";
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
                    BonusQuestion.text = "Hvornår skal patienten indtage den?";
                    Answer.text = "Lorazepam – 1 mg ";
                    BonusAnswer.text = "Lorazepam indtages til natten dagen før- og morgenen før behandling med medicinsk kræftbehandling.";
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
                    Question.text = "Hvornår skal patienten senest indtage antiemetika inden behandling med medicinsk kræftbehandling? ";
                    BonusQuestion.text = "Hvorfor er det vigtigt?";
                    Answer.text = "Senest ½ - 1 time inden indgift af medicinsk kræftbehandling";
                    BonusAnswer.text = "Det er vigtigt at patienten har taget antiemetika ½-1 time før behandling med medicinsk kræftbehandling så kvalmereceptorerne er blokeret.";
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
                    BonusQuestion.text = "Kan du nævne præparater der tilhører de forskellige grupper?";
                    Answer.text = " • Dopaminreceptor-antagonister\r\n • Serotoninreceptor-antagonister \r\n• Neurokininreceptor-antagonister  \r\n• Multireceptor-antagonister \r\n• Kortikosteroider ";
                    BonusAnswer.text = "• Dopaminreceptor-antagonister: Domperidon, \r\n   Metopimazin Metoclopramid\r\n • Serotoninreceptor-antagonister: Ondansetron, \r\n   Palonosetron, Granisetron\r\n • Neurokininreceptor-antagonister: Aprepitant, Netupitant\r\n • Multireceptor-antagonister: Olanzapin\r\n • Kortikosteroider: Prednisolon, Methylprednisolon, \r\nDexamethason";
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
                    BonusQuestion.text = "Nævn hvordan Ondansetron kan dispenseres?";
                    Answer.text = " • Obstipation\r\n • Hovedpine";
                    BonusAnswer.text = "• Oralt: Kan knuses eller opslæmmes i vand. \r\n   Indtages uden hensyn til måltider\r\n • IV: 8-16 mg. Initialdosis må ikke overskride 16 mg ved   \r\n   korttidsinfusion over 15 minutter\r\n • Suppositorie: 16 mg \r\n• Smelt: 4 mg – 8 mg ";

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
                    BonusQuestion.text = "Nævn hvordan Palonosetron kan dispenseres?";
                    Answer.text = " • Hovedpine\r\n • Svimmelhed\r\n • Obstipation\r\n • Diarré";
                    BonusAnswer.text = "• Oralt: Indtages hel. Indtages uden hensyntagen til \r\n   måltider\r\n • IV: Intravenøs Palonosteron: 0,25 mg svarer til 0,5 mg  \r\n   peroral Palonosetron";

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
                    BonusQuestion.text = "Nævn hvordan Aprepritant kan dispenseres?";
                    Answer.text = " • Hikke\r\n • Forhøjet levertransaminaser \r\n• Dyspepsi\r\n • Obstipation\r\n • Hovedpine\r\n • Nedsat appetit\r\n • Træthed";
                    BonusAnswer.text = "• Oralt\r\n• IV";


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
                    BonusQuestion.text = "Nævn hvordan NEPA kan dispenseres?";
                    Answer.text = " • Hovedpine\r\n • Obstipation\r\n • Træthed";
                    BonusAnswer.text = "• Oralt: Kapslen indtages hel. Indtages uden hensyntagen til \r\n   måltider";

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
                    BonusQuestion.text = "Nævn hvordan kan det dispenseres?";
                    Answer.text = "" +
                        " • Døsighed  • Glykosuri\r\n" +
                        " • Vægtøgning • Øget appetit\r\n" +
                        " • Eosinofili • Svimmelhed\r\n" +
                        " • Hyperprolaktinæmi • Ortostatisk hypotension\r\n" +
                        " • Hyperglykæmi • Antikolinerge symptomer";
                    BonusAnswer.text = "• Oralt: Kan knuses eller opslæmmes i vand. Indtages uden  \r\n   hensyn til måltider\r\n • Smelt ";

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
                    Question.text = " Hvilke bivirkninger opleves ofte ved Prednisolon – nævn 5?";
                    BonusQuestion.text = "Nævn hvordan Prednisolon kan dispenseres?";
                    Answer.text = " • Uro og søvnløhed\r\n • Rødme og blussende ansigt \r\n• Øget appetit og vægtøgning \r\n• Dyspepsi";
                    BonusAnswer.text = "• Oralt: Kan knuses eller opslæmmes i vand \r\n• IV: Methylprednisolon: 40 mg, svarer til 50 mg peroral Prednisolon";

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
                    BonusQuestion.text = "Nævn hvordan kan det dispenseres?";
                    Answer.text = "" +
                        " • Træthed • Ataksi\r\n" +
                        " • Døsighed • Depression\r\n" +
                        " • Sedation • Konfusion\r\n" +
                        " • Kraftesløshed • Svimmelhed\r\n" +
                        " • Muskelsvaghed";
                    BonusAnswer.text = "• Oralt: Delekærv, det vil sige at dosis kan deles \r\n• Lorazepam – 1 mg max 1 mg i døgnet";


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
                        " • Mundtørhed  • Svimmelhed\r\n" +
                        " • Let sedation  • Symptomer på hyperprolaktinæmi \r\n" +
                        " • Obstipation specielt ved   • Urinretention\r\n" +
                        "   kombination med seroton  • Ekstrapyrimidale bivirkninger\r\n" +
                        "   inantagonister\r\n" +
                        " • Ortostatisk hypotension";
                    BonusAnswer.text = "• Moderat- og højemetogen behandling = 30 mg x 4, i 4 dage \r\n• Lavemetogen behandling = 15 mg x 4, i 4 dage";
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
                    BonusQuestion.text = " • Agitation\r\n • Angst\r\n • Ekstrapyramidale gener\r\n • Nervøsitet\r\n • Somnolens\r\n • Svimmelhed";
                    Answer.text = "Nævn hvordan kan det dispenseres?";
                    BonusAnswer.text = "Oralt: Kan knuses eller opslæmmes i vand. Indtages før \r\nmåltider.";
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
