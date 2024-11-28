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
                    Category.text = "Pathophysiology";
                    Question.text = "When discussing nausea and vomiting in connection with medical cancer treatment, four types are mentioned. \r\nName these?\r\n";
                    BonusQuestion.text = "When do the 4 types occur in the course?";
                    Answer.text = "� Acute nausea and vomiting\r\n� Delayed nausea and vomiting\r\n� Anticipatory nausea and vomiting\r\n� Refractory nausea and breakthrough nausea\r\n";
                    BonusAnswer.text = "� Acute nausea and vomiting occurs 0-24 hours after administration\r\n� Delayed nausea and vomiting occurs 24-120 hours after administration\r\n� Anticipatory nausea and vomiting occurs before the start of a new series\r\n� Refractory nausea and breakthrough nausea occurs unexpectedly during and after treatment despite antiemetic prophylaxis\r\n";
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
                        "� Sult � Str�leterapi\r\n" +
                        "� Dyspepsi � Anden sygdom";
                    BonusAnswer.text = "Sygdomsplacering: Ofte set ved sygdom i ventrikel, hepar, colon, cerebrum, pancreas\r\n Elektrolytbalance: Ved hypercalc�mi og hypermagnesi�mi \r\nMedicin: F.eks. morfika, antibiotika, digitalis";
                }
                else
                {
                    Category.text = "Pathophysiology";
                    Question.text = "There are other causes of nausea and vomiting besides medical cancer treatment.\r\nName 4-5 causes?";
                    BonusQuestion.text = "Can you elaborate on the causes: location of the disease, electrolyte balance, and medication?";
                    Answer.text = "" +
                        "� Location of the disease � Pain\r\n" +
                        "� Electrolyte balance � Fatigue\r\n" +
                        "� Medication � Fungal infection in the mouth and throat\r\n" +
                        "� Metastases � Constipation\r\n" +
                        "� Hunger � Radiation therapy\r\n" +
                        "� Dyspepsia � Other diseases";
                    BonusAnswer.text = "Location of the disease: Often seen with diseases in the stomach, liver, colon, brain, and pancreas.\r\nElectrolyte balance: In cases of hypercalcemia and hypermagnesemia.\r\nMedication: For example, morphine, antibiotics, digitalis.";
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
                    Category.text = "Pathophysiology";
                    Question.text = "There are several factors that influence the patient's risk of experiencing nausea and vomiting after medical cancer treatment. Name 5 factors.";
                    BonusQuestion.text = "Can you elaborate on the influence of age, gender, and alcohol consumption on the occurrence of nausea and vomiting?";
                    Answer.text = "� The emetogenic potential of the medical cancer treatment\r\n� Dosage and combination of the medical cancer treatment\r\n� Duration of the medical cancer treatment\r\n� Gender\r\n� Age\r\n� High alcohol consumption\r\n� The patient's psyche, perception of illness and treatment\r\n� Previous experiences with nausea";
                    BonusAnswer.text = "� Younger individuals have a higher risk < 55 years\r\n� Women have a higher risk\r\n� Chronic increased alcohol consumption leads to less nausea\r\n� Motion sickness and nausea during pregnancy can increase the risk of nausea during treatment";
                }
                break;
            case 4:
                if (lang)
                {

                    Category.text = "Patofysiologi";
                    Question.text = "Kroppen opfatter medicinsk kr�ftbehandling som et giftstofvia receptorer f�lsomme for dette. Hvis disse receptorer bliver aktiveret kan det udl�se kvalme/opkastning. Hvordan fungerer antiemetika inde i kroppen? ";
                    BonusQuestion.text = " Hvor mange omr�der kan potentielt blive p�virket i CNS?";
                    Answer.text = "Antiemetika fungerer ved at blokere receptorer i centralnervesystemet og i GI kanalen der bliver aktiveret ved indgift af medicinsk kr�ftbehandling.";
                    BonusAnswer.text = "3 omr�der kan potentielt blive p�virket\r\nDe tre omr�der hedder\r\n� Kemoreceptortriggerzonen (KTZ)\r\n � Nucleus tractus solitarius (NTS)\r\n � Br�kcentret (BC)";
                }
                else
                {
                    Category.text = "Pathophysiology";
                    Question.text = "The body perceives medical cancer treatment as a toxin via receptors sensitive to it. If these receptors are activated, it can trigger nausea/vomiting. How do antiemetics work inside the body?";
                    BonusQuestion.text = "How many areas can potentially be affected in the CNS?";
                    Answer.text = "Antiemetics work by blocking receptors in the central nervous system and in the GI tract that are activated by the administration of medical cancer treatment.\r\n";
                    BonusAnswer.text = "3 areas can potentially be affected\r\nThe three areas are\r\n� Chemoreceptor trigger zone (CTZ)\r\n� Nucleus tractus solitarius (NTS)\r\n� Vomiting center (VC)\r\n";
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
                    Category.text = "Pathophysiology";
                    Question.text = "Patients undergoing medical cancer treatment may also experience nausea and vomiting provoked by known or unknown stimuli.\r\nName some of these stimuli?";
                    BonusQuestion.text = "The reactions come from specific places in the body that can be affected by such stimuli, which?";
                    Answer.text = "� Smells\r\n� Sight\r\n� Sounds\r\n� Previous experiences with hospitals or medical cancer treatment";
                    BonusAnswer.text = "The reactions come from:\r\n� Cortex cerebri � the cerebral cortex\r\n� The limbic system � where memory and emotions are processed\r\n� The vestibular apparatus - the inner ear";
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
                    Category.text = "Pathophysiology";
                    Question.text = "The vomiting center receives impulses from KTZ and NTS as well as from the gastrointestinal tract. Where does the vomiting center send its signals?";
                    BonusQuestion.text = "How is this treated?";
                    Answer.text = "The vomiting center induces nausea and vomiting by sending signals via efferent nerve pathways to:\r\n� Esophagus\r\n� Stomach\r\n� Diaphragm\r\n� Abdominal muscles";
                    BonusAnswer.text = "Antiemetics, depending on the emetogenic risk of the treatment, the patient's nausea history, and other risk factors.";
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
                    Category.text = "Pathophysiology";
                    Question.text = "Medical cancer treatment is divided into 4 groups based on their emetogenic potential. Name the 4 groups?";
                    BonusQuestion.text = "Can you mention, for each group, the risk of experiencing nausea (in %)?";
                    Answer.text = "� Minimal emetogenic\r\n� Low emetogenic\r\n� Moderate emetogenic (MEC)\r\n� High emetogenic (HEC)";
                    BonusAnswer.text = "Risk in percentages\r\n� Minimal emetogenic: 0-10%\r\n� Low emetogenic: 10-30%\r\n� Moderate emetogenic (MEC): 30-90%\r\n� High emetogenic (HEC): 90%";
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
                    Category.text = "Pharmacology";
                    Question.text = "Which medication can be used for anticipatory nausea?";
                    BonusQuestion.text = "When should the patient take it?";
                    Answer.text = "Lorazepam � 1 mg";
                    BonusAnswer.text = "Lorazepam is taken the night before and the morning before treatment with medical cancer therapy.";
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
                    Category.text = "Pharmacology";
                    Question.text = "When should the patient latest take antiemetics before treatment with medical cancer therapy?";
                    BonusQuestion.text = "Why is it important?";
                    Answer.text = "At least � - 1 hour before administration of medical cancer therapy.";
                    BonusAnswer.text = "It is important that the patient has taken antiemetics �-1 hour before treatment with medical cancer therapy so that the nausea receptors are blocked.";
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
                    Category.text = "Pharmacology";
                    Question.text = "What are the 5 types of antiemetics?";
                    BonusQuestion.text = "Can you name preparations that belong to the different groups?\r\n";
                    Answer.text = "� Dopamine receptor antagonists\r\n� Serotonin receptor antagonists\r\n� Neurokinin receptor antagonists\r\n� Multireceptor antagonists\r\n� Corticosteroids";
                    BonusAnswer.text = "� Dopamine receptor antagonists: Domperidone, Metopimazine, Metoclopramide\r\n� Serotonin receptor antagonists: Ondansetron, Palonosetron, Granisetron\r\n� Neurokinin receptor antagonists: Aprepitant, Netupitant\r\n� Multireceptor antagonists: Olanzapine\r\n� Corticosteroids: Prednisolone, Methylprednisolone, Dexamethasone";
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
                    Category.text = "Pharmacology";
                    Question.text = "What are the most common side effects of Ondansetron?";
                    BonusQuestion.text = "How can Ondansetron be dispensed?";
                    Answer.text = "Most common side effects (? 1%)\r\n� Constipation\r\n� Headache";
                    BonusAnswer.text = "� Oral: Can be crushed or suspended in water. Taken without regard to meals\r\n� IV: 8-16 mg. The initial dose must not exceed 16 mg for a short-term infusion over 15 minutes\r\n� Suppository: 16 mg\r\n� Melt: 4 mg � 8 mg";
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
                    Category.text = "Pharmacology";
                    Question.text = "What are the most common side effects of Palonosetron?";
                    BonusQuestion.text = "Name how Palonosetron can be dispensed?";
                    Answer.text = "Most common side effects (? 1%)\r\n� Headache\r\n� Dizziness\r\n� Constipation\r\n� Diarrhea";
                    BonusAnswer.text = "� Oral: Taken whole. Taken without regard to meals\r\n� IV: Intravenous Palonosetron: 0.25 mg is equivalent to 0.5 mg oral Palonosetron";
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
                    Category.text = "Pharmacology";
                    Question.text = "What are the most common side effects of Aprepitant?";
                    BonusQuestion.text = "How can Aprepitant be dispensed?";
                    Answer.text = "Most common side effects (? 1%)\r\n� Hiccups\r\n� Elevated liver transaminases\r\n� Dyspepsia\r\n� Constipation\r\n� Headache\r\n� Decreased appetite\r\n� Fatigue";
                    BonusAnswer.text = "� Orally: The capsule can be opened and suspended in water. Taken without regard to meals.\r\n� IV: Intravenous Aprepitant is called Fosaprepitant 150 mg on day 1 (treatment day), has the same effect as oral Aprepitant for 3 days. Fosaprepitant is not registered in Denmark but can be obtained through a dispensing permit from the Danish Medicines Agency.";
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
                    Category.text = "Pharmacology";
                    Question.text = "What are the most common side effects of Netupitant-Palonosetron (NEPA)?";
                    BonusQuestion.text = "How can NEPA be dispensed?";
                    Answer.text = "Most common side effects (? 1%)\r\n� Headache\r\n� Constipation\r\n� Fatigue";
                    BonusAnswer.text = "� Orally: The capsule is taken whole. Taken without regard to meals.";
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
                    Category.text = "Pharmacology";
                    Question.text = "What are the most common side effects of Olanzapine?";
                    BonusQuestion.text = "How can it be dispensed?";
                    Answer.text = "" +
                        "Most common side effects (? 1%)\r\n" +
                        "� Drowsiness � Glycosuria\r\n" +
                        "� Weight gain � Increased appetite\r\n" +
                        "� Eosinophilia � Dizziness\r\n" +
                        "� Hyperprolactinemia � Orthostatic hypotension\r\n" +
                        "� Hyperglycemia � Anticholinergic symptoms\r\n";
                    BonusAnswer.text = "� Orally: Can be crushed or suspended in water. Taken without regard to meals\r\n� Dissolvable";
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
                    Category.text = "Pharmacology";
                    Question.text = "What side effects are often experienced with Prednisolone � name 5?";
                    BonusQuestion.text = "Name how Prednisolone can be dispensed?";
                    Answer.text = "� Restlessness and insomnia\r\n� Redness and flushed face\r\n� Increased appetite and weight gain\r\n� Dyspepsia";
                    BonusAnswer.text = "� Orally: Can be crushed or suspended in water\r\n� IV: Methylprednisolone: 40 mg, equivalent to 50 mg oral Prednisolone";
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
                    Category.text = "Pharmacology";
                    Question.text = "What are the most common side effects of Lorazepam?";
                    BonusQuestion.text = "How can it be dispensed?";
                    Answer.text = "Most common side effects (? 1%)" +
                        "� Fatigue � Ataxia\r\n" +
                        "� Drowsiness � Depression\r\n" +
                        "� Sedation � Confusion\r\n" +
                        "� Weakness � Dizziness\r\n" +
                        "� Muscle weakness";
                    BonusAnswer.text = "� Orally: Breakable score, meaning the dose can be divided\r\n� Lorazepam � 1 mg max 1 mg per day";
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
                        " � Let sedation  � Symptomer p� hyperprolaktin�mi (inkl. seksuel dysfunktion)\r\n" +
                        " � Obstipation specielt ved   � Urinretention\r\n" +
                        "   kombination med seroton  � Ekstrapyrimidale bivirkninger\r\n" +
                        "   inantagonister\r\n" +
                        " � Ortostatisk hypotension";
                    BonusAnswer.text = "Oralt: Indtages hel, f�r m�ltider.\r\n" +
                        "� Moderat- og h�jemetogen behandling = 30 mg x 4, i 4 dage \r\n� Lavemetogen behandling = 15 mg x 4, i 4 dage";
                }
                else
                {
                    Category.text = "Pharmacology";
                    Question.text = "What are the most common side effects of Metopimazine?";
                    BonusQuestion.text = "How can it be dispensed?";
                    Answer.text = "Most common side effects (? 1%)" +
                        "� Dry mouth � Dizziness\r\n" +
                        "� Mild sedation � Symptoms of hyperprolactinemia (including sexual dysfunction)" +
                        "� Constipation, especially when       � Urinary retention\r\n" +
                        "  combined with serotonin antagonists � Extrapyramidal side effects occur very rarely.\r\n" +
                        "� Orthostatic hypotension\r\n";
                    BonusAnswer.text = "Orally: Taken whole, before meals.\r\n" +
                        "� Moderate and high emetic treatment = 30 mg x 4, for 4 days\r\n� Low emetic treatment = 15 mg x 4, for 4 days";
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
                    Category.text = "Pharmacology";
                    Question.text = "What are the most common side effects of Domperidone?";
                    BonusQuestion.text = "How can it be dispensed?";
                    Answer.text = "Most common side effects (? 1%)\r\n� Agitation\r\n� Anxiety\r\n� Extrapyramidal symptoms\r\n� Nervousness\r\n� Somnolence\r\n� Dizziness";
                    BonusAnswer.text = "Orally: Can be crushed or suspended in water. Taken before meals.";
                }
                break;
            case 20:
                if (lang)
                {

                    Category.text = "Farmakologi";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Metoclopramid?";
                    BonusQuestion.text = "N�vn hvordan kan det dispenseres?";
                    Answer.text = "Hyppigste bivirkninger (? 1%)\r\n" +
                        "� D�sighed � Akatisi\r\n" +
                        "� Kraftesl�shed � Depression\r\n" +
                        "� Diarr� � Ekstrapyramidale gener\r\n" +
                        "� Mundt�rhed � Parkinsonisme\r\n" +
                        "� Hypotension (is�r efter i.v. indgift)";
                    BonusAnswer.text = "Oralt: Delek�rv, det vil sige dosis kan deles";
                }
                else
                {
                    Category.text = "Pharmacology";
                    Question.text = "What are the most common side effects of Metoclopramide?";
                    BonusQuestion.text = "How can it be dispensed?";
                    Answer.text = "Most common side effects (? 1%)\r\n" +
                        "� Drowsiness � Akathisia\r\n" +
                        "� Weakness � Depression\r\n" +
                        "� Diarrhea � Extrapyramidal symptoms\r\n" +
                        "� Dry mouth � Parkinsonism\r\n" +
                        "� Hypotension (especially after i.v. administration)";
                    BonusAnswer.text = "Orally: Scored tablet, meaning the dose can be divided";
                }
                break;
            case 21:
                if (lang)
                {

                    Category.text = "Kvalmeanamese";
                    Question.text = "Hvorfor optager man en kvalmeanamnese?";
                    BonusQuestion.text = "Hvilke konsekvenser kan det have for patienten, hvis den\r\nantiemetiske behandling ikke har v�ret optimal?";
                    Answer.text = "� For at forebygge kvalme og opkastning\r\n� For at sikre der gives bedst mulig antiemetisk behandling\r\n� For at identificere eventuelle patientrelaterede risikofaktorer";
                    BonusAnswer.text = "� Ved l�ngerevarende kvalme og opkastning kan daglige\r\naktiviteter indskr�nkes og livskvalitet blive forringet\r\n� Der er risiko for at den medicinske kr�ftbehandling ikke\r\nkan gives";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "Why is a **nausea history** taken?";
                    BonusQuestion.text = "What consequences can it have for the patient if the antiemetic treatment has not been optimal?";
                    Answer.text = "� To prevent nausea and vomiting.\r\n� To ensure the best possible antiemetic treatment is given.\r\n� To identify any patient-related risk factors.";
                    BonusAnswer.text = "� With prolonged nausea and vomiting, daily activities may be restricted and quality of life may deteriorate.\r\n� There is a risk that the medical cancer treatment cannot be administered.";
                }
                break;
            case 22:
                if (lang)
                {

                    Category.text = "Kvalmeanamese";
                    Question.text = "Hvorn�r skal der foretages en kvalmeanamnese?";
                    BonusQuestion.text = "Hvad er den vigtigste informationskilde n�r du laver en\r\nkvalmeanamnese?";
                    Answer.text = "� F�r hver behandling\r\n� Ved gennembrudskvalme eller -opkastning";
                    BonusAnswer.text = "Det vigtigste er samtalen med din patient og husk at\r\np�r�rende ogs� kan v�re en god kilde til viden n�r du\r\noptager en anamnese";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "When should a nausea history be taken?";
                    BonusQuestion.text = "What is the most important source of information when you conduct a nausea history?";
                    Answer.text = "� Before each treatment\r\n� In case of breakthrough nausea or vomiting";
                    BonusAnswer.text = "The most important thing is the conversation with your patient, and remember that relatives can also be a good source of information when you take a history.";
                }   
                break;
            case 23:
                if (lang)
                {

                    Category.text = "Kvalmeanamese";
                    Question.text = "Hvilke risikofaktorer hos patienten har betydning for\r\nkvalmeanamnesen?";
                    BonusQuestion.text = "Kan du uddybe hvordan de ovenst�ende faktorer har indflydelse?\r\n+ = �get risiko\r\n- = nedsat risiko";
                    Answer.text = "" +
                        "� Tidligere behandling med � Tr�thed\r\n" +
                        "  medicinsk kr�ftbehandling � Alkohol\r\n" +
                        "� K�n � Tidligere erfaring med kvalme\r\n" +
                        "� Alder\r\n" +
                        "� Psykologiske faktorer";
                    BonusAnswer.text = "" +
                        "� Kvinder + � Tidligere erfaring med kvalme\r\n" +
                        "� Yngre +     i form af transport syge, graviditet\r\n" +
                        "� Psykologiske faktorer:  � Tidligere medicinsk kr�ftbehandling +\r\n" +
                        "  angst, nerv�sitet, opfattelse � Alkoholmisbrug -\r\n" +
                        "  af sygdom og behandling +" +
                        "� Tr�thed +";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "Which risk factors in the patient are significant for the nausea anamnesis?";
                    BonusQuestion.text = "Can you elaborate on how the above factors influence?\r\n+ = increased risk \r\n- = decreased risk\r\n";
                    Answer.text ="" +
                        "� Previous treatment with � Fatigue\r\n" +
                        "  medical cancer treatment � Alcohol\r\n" +
                        "� Gender � Previous experience with nausea\r\n" +
                        "� Age\r\n" +
                        "� Psychological factors";
                    BonusAnswer.text = "" +
                        "� Women + � Previous experience with nausea in\r\n" +
                        "";
                }
                break;
            case 24:
                if (lang)
                {

                    Category.text = "Kvalmeanamese";
                    Question.text = "Hvilke informationer er vigtige at indhente i kvalmeanamnesen\r\nved gennembrudskvalme og -opkastning?";
                    BonusQuestion.text = "Hvis det er mere end 5 dage siden patienten sidst fik\r\nmedicinsk kr�ftbehandling hvilke andre �rsager?";
                    Answer.text = "� Unders�g om det er mere\r\nend 5 dage siden patienten\r\nsidst har f�et medicinsk\r\nkr�ftbehandling\r\n� Kvalme intensitet (fx skala\r\nfra 0-10)\r\n� Tidspunkt for symptomdebut:\r\nakut (0-24 t) eller\r\nsen fase (25-120 t)\r\n� H�jeste antal af evt\r\nopkastninger i en 24-\r\ntimers periode\r\n� Kan/kunne patienten spise\r\nog drikke, mens der er/var\r\nsymptomer?\r\n� Hvilke antiemetika blev\r\nindtaget og hvorn�r?";
                    BonusAnswer.text = "� Sygdomsudbredning\r\n� Sygdommens placering\r\n� Elektrolytbalance\r\n� Medicin\r\n� Sult\r\n� Dyspepsi\r\n� Smerter\r\n� Tr�thed\r\n� Svampeinfektion i mund\r\nog hals\r\n� Obstipation\r\n� Reaktion p� str�leterapi";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "What information is important to gather in the nausea history in cases of breakthrough nausea and vomiting?";
                    BonusQuestion.text = "If it has been more than 5 days since the patient last received medical cancer treatment, what other causes?";
                    Answer.text = "� Check if it has been more than 5 days since the patient last received medical cancer treatment\r\n� Nausea intensity (e.g., scale from 0-10)\r\n� Onset of symptoms: acute (0-24 hours) or late phase (25-120 hours)\r\n� Highest number of possible vomits in a 24-hour period\r\n� Could/can the patient eat and drink while experiencing symptoms?\r\n� Which antiemetics were taken and when?";
                    BonusAnswer.text = "� Disease progression\r\n� Location of the disease\r\n� Electrolyte balance\r\n� Medication\r\n� Hunger\r\n� Dyspepsia\r\n� Pain\r\n� Fatigue\r\n� Fungal infection in the mouth and throat\r\n� Constipation\r\n� Reaction to radiation therapy\r\n";
                }
                break;
            case 25:
                if (lang)
                {

                    Category.text = "Kvalmeanamese";
                    Question.text = "Hvad kan patienten selv g�re for at lindre kvalme og opkastning?";
                    BonusQuestion.text = "";
                    Answer.text = "� Drikke rigeligt\r\n� Let m�ltid f�r behandling\r\n� Sm� lette m�ltider generelt\r\n� B�re l�sth�ngende bekvemt t�j\r\n� Adspredelse, fx film, b�ger, TV, musik m.m.\r\n� God mundhygiejne/pleje\r\n� Fysisk aktivitet\r\n� Rolige omgivelser\r\n� P�r�rende og sygeplejerskens tilstedev�relse kan d�mpe\r\nangst og uro";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "What can the patient do to alleviate nausea and vomiting?";
                    BonusQuestion.text = "";
                    Answer.text = "� Drink plenty of fluids\r\n� Light meal before treatment\r\n� Small, light meals in general\r\n� Wear loose, comfortable clothing\r\n� Distraction, e.g., movies, books, TV, music, etc.\r\n� Good oral hygiene/care\r\n� Physical activity\r\n� Calm surroundings\r\n� Presence of relatives and the nurse can reduce anxiety and restlessness";
                    BonusAnswer.text = "";
                }
                break;
            case 26:
                if (lang)
                {

                    Category.text = "Kvalmeanamese";
                    Question.text = "Hvilke fysiske symptomer ses ved kvalme og opkastning?";
                    BonusQuestion.text = "Hvilke sygeplejehandlinger er relevante for en patient med\r\nkvalme og opkastning?";
                    Answer.text = "� Forh�jet puls\r\n� Hjertebanken\r\n� Bleghed\r\n� Kold og klamtsvedende\r\n� �get spytsekretion\r\n� Madlede";
                    BonusAnswer.text = "� Kold klud p� panden\r\n� Afsk�rmning og skabe ro omkring patienten\r\n� Bliv ved patienten, hvis muligt\r\n� S�rg for at patienten har noget at kaste op i og at fjerne\r\nevt. opkast straks\r\n� Tilbyde vand\r\n� Frisk luft\r\n� Giv evt. pn antiemetika";
                }
                else
                {
                    Category.text = "Engelsk";
                    Question.text = "What physical symptoms are seen with nausea and vomiting?";
                    BonusQuestion.text = "What nursing actions are relevant for a patient with nausea and vomiting?";
                    Answer.text = "� Increased pulse\r\n� Palpitations\r\n� Pallor\r\n� Cold and clammy sweat\r\n� Increased saliva secretion\r\n� Aversion to food";
                    BonusAnswer.text = "� Cold cloth on the forehead\r\n� Shielding and creating calm around the patient\r\n� Stay with the patient, if possible\r\n� Ensure the patient has something to vomit into and remove any vomit immediately\r\n� Offer water\r\n� Fresh air\r\n� Possibly give as needed antiemetics";
                }
                break;
            case 27:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "Ulla ringer ind til afdelingen 14 dage efter afsluttet behandling.\r\nHun har stadig kvalme.\r\nHvad vil du gerne vide?";
                    BonusQuestion.text = "T�nk ogs� gerne andre �rsager, da det er 14 dage siden\r\nafsluttet behandling:\r\nHvilke �rsager kunne det v�re?";
                    Answer.text = "Indsaml viden til kvalmeanamnesen og t�nk hele vejen\r\nrundt.";
                    BonusAnswer.text = "� Ileus\r\n� Svampeinfektion i mund og hals\r\n� Elektrolytforstyrrelser\r\n� Infektioner\r\n� Obstipation\r\n� Str�lebehandling\r\n� Mavesyre\r\n� Metastaser";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "Ulla calls the department 14 days after completing treatment.\r\nShe still has nausea.\r\nWhat would you like to know?";
                    BonusQuestion.text = "Also consider other causes, as it has been 14 days since the treatment ended:\r\nWhat could the causes be?";
                    Answer.text = "Gather information for the nausea history and think comprehensively.";
                    BonusAnswer.text = "� Ileus\r\n� Fungal infection in the mouth and throat\r\n� Electrolyte disturbances\r\n� Infections\r\n� Constipation\r\n� Radiation therapy\r\n� Stomach acid\r\n� Metastases";
                }
                break;
            case 28:
                if (lang)
                {
                    Category.text = "Cases";
                    Question.text = "Vivi m�der i afdelingen til 2. behandling. Hun kaster op i\r\nventearealet.\r\nHvilke tanker g�r du dig?\r\nHvilke handlinger er relevante?";
                    BonusQuestion.text = "Hvad kan du g�re i forhold til den antiemetiske behandling\r\ninden n�ste behandlingsserie?";
                    Answer.text = "Der kan v�re tale om forventningskvalme.\r\nHandlinger kan best� af, at f� Vivi sk�rmet. S�rge for frisk\r\nluft og noget at drikke.";
                    BonusAnswer.text = "� Anvende tbl. lorazepam dagen f�r om aftenen og p�\r\nbehandlingsdagen 1 time f�r\r\n� Optag en kvalmeanamnese med henblik p� at vurdere om\r\nder er brug for optimering af den antiemetiske behandling\r\n� Overvej skifte fra tablet til I.V. antiemetika\r\n� Evaluer effekt af P.N. behandling";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "Vivi arrives at the department for her second treatment. She vomits in the waiting area.\r\nWhat thoughts do you have?\r\nWhat actions are relevant?";
                    BonusQuestion.text = "What can you do regarding the antiemetic treatment before the next treatment series?";
                    Answer.text = "It may be a case of anticipatory nausea. Actions may include shielding Vivi, ensuring fresh air, and providing something to drink.";
                    BonusAnswer.text = "� Administer lorazepam tablets the evening before and 1 hour before treatment on the treatment day\r\n� Take a nausea history to assess whether there is a need to optimize the antiemetic treatment\r\n� Consider switching from oral to IV antiemetics\r\n� Evaluate the effectiveness of PRN treatment.\r\n";
                }
                break;
            case 29:
                if (lang)
                {
                    Category.text = "Cases";
                    Question.text = "S�ren ringer ind til afdelingen en uge efter behandling med\r\nh�jemetogen kemoterapi. Han har mavesmerter.\r\nHvad vil du vide?";
                    BonusQuestion.text = "Hvad ved du om bivirkninger til den antiemetiske\r\nbehandling?\r\nGiv eksempler som kan forklare S�rens situation.";
                    Answer.text = "� Har S�ren kvalme?\r\n� Hvis ja, hvilken antiemetisk behandling er der anvendt?\r\n� Er S�ren obstiperet?\r\n� Har S�ren f�et nok v�ske?\r\n� Har S�ren feber?\r\n� Hvor mobil er S�ren?";
                    BonusAnswer.text = "Ondansetron, Akynzeo og Aloxi, kan i 1-10 % af tilf�ldene\r\nv�re �rsag til obstipation.";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "S�ren calls the department a week after treatment with high-dose chemotherapy. He has stomach pain.\r\nWhat do you want to know?";
                    BonusQuestion.text = "What do you know about the side effects of the antiemetic treatment?\r\nGive examples that can explain S�ren's situation.";
                    Answer.text = "� Does S�ren have nausea?\r\n� If yes, what antiemetic treatment has been used?\r\n� Is S�ren constipated?\r\n� Has S�ren had enough fluids?\r\n� Does S�ren have a fever?\r\n� How mobile is S�ren?";
                    BonusAnswer.text = "Ondansetron, Akynzeo, and Aloxi can cause constipation in 1-10% of cases.";
                }
                break;
            case 30:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "Karl ringer ind til afdelingen 5 dage efter behandlingen og\r\nhar kvalme\r\nHvad vil du vide?";
                    BonusQuestion.text = "Hvad kan hj�lpen til Karl best� af?";
                    Answer.text = "� Hvilken medicinsk kr�ftbehandling har Karl f�et?\r\n� Hvilken antiemetika er der anvendt?\r\n� Hvorn�r har patienten taget sin antiemetika taget?\r\n� Har Karl f�et v�ske og mad nok?\r\n� Er der andre sygdomme i spil?\r\n� Har Karl obstipation?\r\n� Har Karl feber?";
                    BonusAnswer.text = "� Vejledning i p.n-medicin\r\n� Anbefalinger i forhold til kost, drikke og motion\r\n� Brug din viden og erfaring � du kan godt :) De andre kort\r\nkan eventuelt hj�lpe dig videre";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "Karl calls the department 5 days after the treatment and has nausea.\r\nWhat do you want to know?";
                    BonusQuestion.text = "What assistance can be provided to Karl?";
                    Answer.text = "� What type of medical cancer treatment has Karl received?\r\n� What antiemetic has been used?\r\n� When has the patient taken his antiemetic?\r\n� Has Karl had enough fluids and food?\r\n� Are there other diseases involved?\r\n� Does Karl have constipation?\r\n� Does Karl have a fever?\r\n";
                    BonusAnswer.text = "� Guidance on as-needed medication\r\n� Recommendations regarding diet, drink, and exercise\r\n� Use your knowledge and experience � you can do it :) The other cards may potentially help you further.";
                }
                break;
            case 31:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "Dorthe henvender sig i afdelingen. Hun oplever ufrivillige\r\nbev�gelser, k�ben k�rer rundt, tungen er stor og hun f�ler\r\nat ansigtet er m�rkeligt. Dette g�r hende bange.\r\nHvad vil du vide og hvilke tanker g�r du dig?";
                    BonusQuestion.text = "Hvilke antiemetika kan give ekstrapyramidale bivirkninger?";
                    Answer.text = "� Hvilken PN antiemetika har Dorthe taget?\r\n� Kan det v�re ekstrapyramidale bivirkninger (EPS)\r\nfor�rsaget af medicinen?";
                    BonusAnswer.text = "� Metoclopramid\r\n� Domperidon (g�r kun sj�ldent over blodhjernebarrieren)\r\n� Overvej skift af PN antiemetika";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "Dorthe approaches the department. She experiences involuntary movements, her jaw is moving around, her tongue is large, and she feels that her face is strange. This makes her scared.  \r\nWhat would you like to know and what thoughts do you have?";
                    BonusQuestion.text = "Which antiemetics can cause extrapyramidal side effects?";
                    Answer.text = "� What PN antiemetic has Dorthe taken?  \r\n� Could it be extrapyramidal side effects (EPS) caused by the medication?";
                    BonusAnswer.text = "� Metoclopramide  \r\n� Domperidone (rarely crosses the blood-brain barrier)  \r\n� Consider switching the PN antiemetic.";
                }
                break;
            case 32:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "Bente har i forbindelse med sin medicinske kr�ftbehandling\r\nf�et h�j emetogen antiemetika. Hun ringer til afdelingen og\r\nfort�ller hun har voldsom kvalme og ligger i sengen det\r\nmeste af dagen, for nedrullede gardiner.\r\nHvilke yderligere informationer �nsker du at f� fra Bente?";
                    BonusQuestion.text = "Hvilke overvejelser g�r du dig inden n�ste behandlingsserie?";
                    Answer.text = "� Hvorn�r har Bente sidst f�et medicinsk kr�ftbehandling\r\nog hvorn�r skal hun have n�ste behandling?\r\n� Afd�k om det er akut eller senkvalme\r\n� Hvilken antiemetika har Bente brugt og hvordan har hun\r\ntaget den?\r\n� Hvor meget v�ske og f�de har Bente indtaget, er det nok?\r\n� Har Bente obstipation?\r\n� Har Bente feber?\r\n� Har Bente hovedpine/migr�ne?";
                    BonusAnswer.text = "� Hvis patienten har hovedpine, kan det v�re en bivirknin\r\ntil den antiemetiske behandling. B�de Palonosetron samt\r\nAkynzeo kan give hovedpine.\r\n� Er patienten kendt med migr�ne\r\n� Lav en kvalmeanamnese\r\n� Tal med patienten om forventnings kvalme.";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "Bente has received highly emetogenic antiemetics in connection with her medical cancer treatment. She calls the department and reports that she has severe nausea and spends most of the day in bed with the curtains drawn. What additional information would you like to get from Bente?";
                    BonusQuestion.text = "What considerations do you make before the next treatment series?";
                    Answer.text = "� When did Bente last receive medical cancer treatment and when is her next treatment scheduled?\r\n� Determine whether it is acute or delayed nausea.\r\n� Which antiemetic has Bente used and how has she taken it?\r\n� How much fluid and food has Bente consumed, is it enough?\r\n� Does Bente have constipation?\r\n� Does Bente have a fever?\r\n� Does Bente have a headache/migraine?";
                    BonusAnswer.text = "� If the patient has a headache, it may be a side effect of the antiemetic treatment. Both Palonosetron and Akynzeo can cause headaches.\r\n� Is the patient known to have migraines?\r\n� Conduct a nausea history.\r\n� Discuss expectation-related nausea with the patient.";
                }
                break;
            case 33:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "Mette ringer til afdelingen. Hun fort�ller at hun har f�et\r\nmedicinsk kr�ftbehandling og har kastet op siden\r\nbehandlingsdagen.\r\nHvilke yderligere informationer vil du sp�rge indtil, hos\r\nMette?";
                    BonusQuestion.text = "Mette f�r behandling der har moderat-emetogenpotentiale.\r\nVed sidste behandling havde hun sv�rt ved at f� drukket og\r\nspist, regelm�ssigt og tilstr�kkeligt. Hvilke tiltag vil du g�re\r\nved kommende behandling?";
                    Answer.text = "� Hvor mange dage er det siden det var sidste behandlingsdag?\r\n� Hvorn�r skal Mette have n�ste behandling?\r\n� Hvilken behandling f�r Mette? (f� viden om det emetogene\r\npotentiale)\r\n� Hvor mange gange har Mette kastet op og hvorn�r?\r\n� Har Mette taget p.n. antiemetika (compliance)?\r\n� Hvor meget v�ske og mad har Mette f�et?\r\n� Hvad har Mette selv gjort for at afhj�lpe dette?";
                    BonusAnswer.text = "� Opgradere kvalmebehandling svarende til behandling med\r\nh�j-emetogenpotentiale\r\n� Undervise Mette i brugen af PN og understrege, at tage\r\ndenne inden kvalmen bliver for voldsom\r\n� Undervise i Mette i at f� sm� hyppige m�ltider, rigelig\r\nv�ske, motion osv.\r\n� Lav en kvalmeanamnese for at afd�kke eventuelle risikofaktorer";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "Mette calls the department. She reports that she has received medical cancer treatment and has been vomiting since the treatment day.\r\nWhat additional information would you ask Mette about?";
                    BonusQuestion.text = "Mette is receiving treatment that has moderate emetogenic potential. During her last treatment, she had difficulty drinking and eating regularly and sufficiently. What measures would you take for the upcoming treatment?";
                    Answer.text = "� How many days has it been since the last treatment day?\r\n� When is Mette scheduled for her next treatment?\r\n� What treatment is Mette receiving? (to gain knowledge about its emetogenic potential)\r\n� How many times has Mette vomited and when?\r\n� Has Mette taken any p.r.n. antiemetics (compliance)?\r\n� How much fluid and food has Mette consumed?\r\n� What has Mette done herself to alleviate this?";
                    BonusAnswer.text = "� Upgrade nausea treatment corresponding to high emetogenic potential treatment.\r\n� Educate Mette on the use of p.r.n. and emphasize taking it before nausea becomes too severe.\r\n� Teach Mette to have small frequent meals, plenty of fluids, exercise, etc.\r\n� Create a nausea history to identify any risk factors.";
                }
                break;
            case 34:
                if (lang)
                {

                    Category.text = "Cases";
                    Question.text = "Jan kommer i afdelingen til 2.serie af sin medicinske\r\nkr�ftbehandling. Han har ikke spist noget i ugen efter 1.\r\nbehandling grundet madlede. Da Jan kommer til behandling,\r\nafleverer han prednisolon som han skulle have taget dagene\r\nefter behandling mod senkvalme.\r\nHvilke overvejelser g�r du dig?";
                    BonusQuestion.text = "Hvordan hj�lper vi Jan gennem behandlingen, s� han\r\nundg�r en lignende situation?";
                    Answer.text = "� Hvorfor har Jan ikke anvendt antiemetika? (compliance)\r\n� Hvordan er Jans forhold til at tage piller generelt, hvad er\r\nhans forst�else af hvordan pillerne virker og vigtigheden i at\r\ntage dem?\r\n� Er der andre forhold, som evt. kan have indvirkning,\r\nhukommelsesbesv�r, sv�rt ved at l�se, d�rlig forst�else af\r\npatientinformation.";
                    BonusAnswer.text = "� Evt. alarm p� telefonen � hvad passer til Jan?\r\n� Er der behov for at inddrage p�r�rende og/eller hjemmepleje,\r\nfor at st�tte op om at antiemetika tages korrekt?\r\n� Yderligere patientundervisning (tale om at madlede ogs�\r\ner kvalme og at det er vigtig at tage den ordinerede\r\nantiemetiske behandling for at kunne spise)";
                }
                else
                {
                    Category.text = "Cases";
                    Question.text = "Jan comes to the department for the second series of his medical cancer treatment. He has not eaten anything in the week following the first treatment due to loss of appetite. When Jan arrives for treatment, he hands over the prednisolone he was supposed to take in the days after treatment to prevent delayed nausea. \r\nWhat considerations do you have?";
                    BonusQuestion.text = "How do we help Jan through the treatment so he avoids a similar situation?";
                    Answer.text = "� Why has Jan not used antiemetics? (compliance)\r\n� What is Jan's general attitude towards taking pills, what is his understanding of how the pills work and the importance of taking them?\r\n� Are there other factors that may have an impact, such as memory issues, difficulty reading, poor understanding of patient information?";
                    BonusAnswer.text = "� Possibly an alarm on the phone � what suits Jan?\r\n� Is there a need to involve relatives and/or home care to support the correct intake of antiemetics?\r\n� Additional patient education (discussing that loss of appetite is also nausea and that it is important to take the prescribed antiemetic treatment in order to be able to eat)";
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
