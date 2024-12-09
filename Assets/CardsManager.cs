using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CardsManager : MonoBehaviour
{
    public bool lang;
    [SerializeField] UnityEngine.UI.Image colorBoxBig1;
    [SerializeField] UnityEngine.UI.Image colorBoxLil1;

    [SerializeField] UnityEngine.UI.Image colorBoxBig2;
    [SerializeField] UnityEngine.UI.Image colorBoxLil2;

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
    private UnityEngine.UI.Image colorBoxBig;
    private UnityEngine.UI.Image colorBoxLil;


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
        colorBoxBig = colorBoxBig1;
        colorBoxLil = colorBoxLil1;



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
                colorBoxLil.color = Color.green;
                colorBoxBig.color = Color.green;
                if (lang)
                {
                    
                    Category.text = "Patofysiologi 1";
                    Question.text = "Når man taler om kvalme og opkastning i forbindelse med medicinsk kræftbehandling, taler man om 4 typer nævn disse?";
                    BonusQuestion.text = "Hvornår i forløbet opstår de 4 typer?";
                    Answer.text = "• Akut kvalme og opkastning • Senkvalme og opkastning • Forventnings kvalme og opkastning • Refraktær kvalme og gennembrudskvalme";
                    BonusAnswer.text = "• Akut kvalme og opkastning opstår 0-24 timer efter indgift • Senkvalme og opkastning  opstår 24-120 timer efter indgift • Forventnings kvalme og opkastning opstår inden opstart af ny serie • Refraktær kvalme og gennembrudskvalme opstår uventet under og efter behandling på trods af antiemetisk profylakse";
                }
                else
                {
                    Category.text = "Pathophysiology 1";
                    Question.text = "When discussing nausea and vomiting in connection with medical cancer treatment, four types are mentioned. \r\nName these?";
                    BonusQuestion.text = "When do the 4 types occur in the course?";
                    Answer.text = "• Acute nausea and vomiting • Delayed nausea and vomiting • Anticipatory nausea and vomiting • Refractory nausea and breakthrough nausea";
                    BonusAnswer.text = "• Acute nausea and vomiting occurs 0-24 hours after administration • Delayed nausea and vomiting occurs 24-120 hours after administration • Anticipatory nausea and vomiting occurs before the start of a new series • Refractory nausea and breakthrough nausea occurs unexpectedly during and after treatment despite antiemetic prophylaxis";
                }
                break;
            case 2:
                colorBoxLil.color = Color.green;
                colorBoxBig.color = Color.green;
                if (lang)
                {

                    Category.text = "Patofysiologi 2";
                    Question.text = "Der findes andre årsager til kvalme og opkast end medicinsk kræftbehandling. Nævn 4-5 årsager";
                    BonusQuestion.text = "Kan du uddybe årsagerne: sygdomsplacering, elektrolytbalance og medicin?";
                    Answer.text = "• Sygdommens placering • Elektrolytbalance • Medicin • Metastaser • Sult • Dyspepsi • Smerter • Træthed • Svampeinfektion i mund og hals • Obstipation • Stråleterapi • Anden sygdom";
                    BonusAnswer.text = "Sygdomsplacering: Ofte set ved sygdom i ventrikel, hepar, colon, cerebrum, pancreas\r\nElektrolytbalance: Ved hypercalcæmi og hypermagnesiæmi\r\nMedicin: F.eks. morfika, antibiotika, digitalis";
                }
                else
                {
                    Category.text = "Pathophysiology 2";
                    Question.text = "There are other causes of nausea and vomiting besides medical cancer treatment.\r\nName 4-5 causes?";
                    BonusQuestion.text = "Can you elaborate on the causes: location of the disease, electrolyte balance, and medication?";
                    Answer.text = "• Location of the disease • Electrolyte balance • Medication • Metastases • Hunger • Dyspepsia • Pain • Fatigue • Fungal infection in the mouth and throat • Constipation • Radiation therapy • Other diseases";
                    BonusAnswer.text = "Location of the disease: Often seen with diseases in the stomach, liver, colon, brain, and pancreas.\r\nElectrolyte balance: In cases of hypercalcemia and hypermagnesemia.\r\nMedication: For example, morphine, antibiotics, digitalis.";
                }
                break;
            case 3:
                colorBoxLil.color = Color.green;
                colorBoxBig.color = Color.green;
                if (lang)
                {

                    Category.text = "Patofysiologi 3";
                    Question.text = "Der er flere faktorer der har indflydelse på patientens risiko for at få kvalme og opkastninger efter medicinskkræftbehandling. Nævn 5 faktorer";
                    BonusQuestion.text = "Kan du uddybe hvilken indflydelse alder, køn og indtagelse af alkohol har på forekomsten af kvalme og opkast?";
                    Answer.text = " • Den medicinske kræftbehandlings emetogene potentiale • Dosis og kombination af den medicinske kræftbehandling • Varighed af den medicinske kræftbehandling • Køn • Alder • Højt alkoholforbrug  • Patientens psyke, opfattelse af sygdom og behandling • Tidligere erfaringer med kvalme";
                    BonusAnswer.text = "• Yngre har større risiko < 55 år • Kvinder har større risiko • Kronisk øget alkoholforbrug giver mindre kvalme • Køresyge samt kvalme under graviditet, kan øge risiko for kvalme under behandling";
                }
                else
                {
                    Category.text = "Pathophysiology 3";
                    Question.text = "There are several factors that influence the patient's risk of experiencing nausea and vomiting after medical cancer treatment. Name 5 factors.";
                    BonusQuestion.text = "Can you elaborate on the influence of age, gender, and alcohol consumption on the occurrence of nausea and vomiting?";
                    Answer.text = "• The emetogenic potential of the medical cancer treatment • Dosage and combination of the medical cancer treatment • Duration of the medical cancer treatment • Gender • Age • High alcohol consumption • The patient's psyche, perception of illness and treatment • Previous experiences with nausea";
                    BonusAnswer.text = "• Younger individuals have a higher risk < 55 years • Women have a higher risk • Chronic increased alcohol consumption leads to less nausea • Motion sickness and nausea during pregnancy can increase the risk of nausea during treatment";
                }
                break;
            case 4:
                colorBoxLil.color = Color.green;
                colorBoxBig.color = Color.green;
                if (lang)
                {

                    Category.text = "Patofysiologi 4";
                    Question.text = "Kroppen opfatter medicinsk kræftbehandling som et giftstofvia receptorer følsomme for dette. Hvis disse receptorer bliver aktiveret kan det udløse kvalme/opkastning. Hvordan fungerer antiemetika inde i kroppen? ";
                    BonusQuestion.text = " Hvor mange områder kan potentielt blive påvirket i CNS?";
                    Answer.text = "Antiemetika fungerer ved at blokere receptorer i centralnervesystemet og i GI kanalen der bliver aktiveret ved indgift af medicinsk kræftbehandling.";
                    BonusAnswer.text = "3 områder kan potentielt blive påvirket: De tre områder hedder • Kemoreceptortriggerzonen (KTZ) • Nucleus tractus solitarius (NTS) • Brækcentret (BC)";
                }
                else
                {
                    Category.text = "Pathophysiology 4";
                    Question.text = "The body perceives medical cancer treatment as a toxin via receptors sensitive to it. If these receptors are activated, it can trigger nausea/vomiting. How do antiemetics work inside the body?";
                    BonusQuestion.text = "How many areas can potentially be affected in the CNS?";
                    Answer.text = "Antiemetics work by blocking receptors in the central nervous system and in the GI tract that are activated by the administration of medical cancer treatment.";
                    BonusAnswer.text = "3 areas can potentially be affected: The three areas are • Chemoreceptor trigger zone (CTZ)• Nucleus tractus solitarius (NTS)• Vomiting center (VC)";
                }
                break;
            case 5:
                colorBoxLil.color = Color.green;
                colorBoxBig.color = Color.green;
                if (lang)
                {

                    Category.text = "Patofysiologi 5";
                    Question.text = "Patienter i medicinsk kræftbehandling kan også opleve kvalme og opkastning der fremprovokeres af kendte eller ukendte stimuli.\r\nNævn nogle af disse stimuli?";
                    BonusQuestion.text = "Reaktionerne kommer fra specifikke steder i kroppen, som kan blive påvirket af sådanne stimuli, hvilke?";
                    Answer.text = " • Lugte • Syn • Lyde • Tidligere erfaring med hospitaler eller medicinsk kræftbehandling";
                    BonusAnswer.text = " • Cortex cerebri – hjernebarken • Det limbiske system – her håndteres hukommelse og følelseslivet • Vestibulærapparatet - det indre øre";
                }
                else
                {
                    Category.text = "Pathophysiology 5";
                    Question.text = "Patients undergoing medical cancer treatment may also experience nausea and vomiting provoked by known or unknown stimuli.\r\nName some of these stimuli?";
                    BonusQuestion.text = "The reactions come from specific places in the body that can be affected by such stimuli, which?";
                    Answer.text = "• Smells • Sight • Sounds • Previous experiences with hospitals or medical cancer treatment";
                    BonusAnswer.text = "The reactions come from: • Cortex cerebri – the cerebral cortex • The limbic system – where memory and emotions are processed • The vestibular apparatus - the inner ear";
                }
                break;
            case 6:
                colorBoxLil.color = Color.green;
                colorBoxBig.color = Color.green;
                if (lang)
                {

                    Category.text = "Patofysiologi 6";
                    Question.text = "Brækcentret modtager impulser fra KTZ og NTS samt fra gastrointestinalkanalen, hvor sender brækcenteret sine signaler hen?";
                    BonusQuestion.text = "Hvordan behandles dette?";
                    Answer.text = " • Esophagus\r\n • Ventrikel\r\n • Diaphragma\r\n • Abdominalmuskler ";
                    BonusAnswer.text = "Antiemetika, alt efter behandlingens emetogene risiko, patientens kvalmeanamnese samt andre risikofaktorer.";
                }
                else
                {
                    Category.text = "Pathophysiology 6";
                    Question.text = "The vomiting center receives impulses from KTZ and NTS as well as from the gastrointestinal tract. Where does the vomiting center send its signals?";
                    BonusQuestion.text = "How is this treated?";
                    Answer.text = "The vomiting center induces nausea and vomiting by sending signals via efferent nerve pathways to:\r\n• Esophagus\r\n• Stomach\r\n• Diaphragm\r\n• Abdominal muscles";
                    BonusAnswer.text = "Antiemetics, depending on the emetogenic risk of the treatment, the patient's nausea history, and other risk factors.";
                }
                break;
            case 7:
                colorBoxLil.color = Color.green;
                colorBoxBig.color = Color.green;
                if (lang)
                {

                    Category.text = "Patofysiologi 7";
                    Question.text = "Medicinsk kræftbehandling inddeles i 4 grupper alt efter deres emotogene potentiale nævn de 4 grupper? ";
                    BonusQuestion.text = "Kan du nævne, for hver gruppe, hvor stor en risiko der er for at få kvalme (i %)";
                    Answer.text = "• Minimal emetogen\r\n• Lav emetogen\r\n• Moderat emetogen (MEC)\r\n• Høj emetogen (HEC)";
                    BonusAnswer.text = "• Minimal emetogen: 0-10% • Lav emetogen: 10-30% • Moderat emetogen (MEC): 30-90% • Høj emetogen (HEC): 90%";
                }
                else
                {
                    Category.text = "Pathophysiology 7";
                    Question.text = "Medical cancer treatment is divided into 4 groups based on their emetogenic potential. Name the 4 groups?";
                    BonusQuestion.text = "Can you mention, for each group, the risk of experiencing nausea (in %)?";
                    Answer.text = "• Minimal emetogenic\r\n• Low emetogenic\r\n• Moderate emetogenic (MEC)\r\n• High emetogenic (HEC)";
                    BonusAnswer.text = "Risk in percentages • Minimal emetogenic: 0-10% • Low emetogenic: 10-30% • Moderate emetogenic (MEC): 30-90% • High emetogenic (HEC): 90%";
                }
                break;
            case 8:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 1";
                    Question.text = "Hvilken medicin kan anvendes mod forventningskvalme? ";
                    BonusQuestion.text = "Hvornår skal patienten indtage den?";
                    Answer.text = "Lorazepam – 1 mg ";
                    BonusAnswer.text = "Lorazepam indtages til natten dagen før- og morgenen før behandling med medicinsk kræftbehandling.";
                }
                else
                {
                    Category.text = "Pharmacology 1";
                    Question.text = "Which medication can be used for anticipatory nausea?";
                    BonusQuestion.text = "When should the patient take it?";
                    Answer.text = "Lorazepam – 1 mg";
                    BonusAnswer.text = "Lorazepam is taken the night before and the morning before treatment with medical cancer therapy.";
                }
                break;
            case 9:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 2";
                    Question.text = "Hvornår skal patienten senest indtage antiemetika inden behandling med medicinsk kræftbehandling? ";
                    BonusQuestion.text = "Hvorfor er det vigtigt?";
                    Answer.text = "Senest ½ - 1 time inden indgift af medicinsk kræftbehandling";
                    BonusAnswer.text = "Det er vigtigt at patienten har taget antiemetika ½-1 time før behandling med medicinsk kræftbehandling så kvalmereceptorerne er blokeret.";
                }
                else
                {
                    Category.text = "Pharmacology 2";
                    Question.text = "When should the patient latest take antiemetics before treatment with medical cancer therapy?";
                    BonusQuestion.text = "Why is it important?";
                    Answer.text = "At least ½ - 1 hour before administration of medical cancer therapy.";
                    BonusAnswer.text = "It is important that the patient has taken antiemetics ½-1 hour before treatment with medical cancer therapy so that the nausea receptors are blocked.";
                }
                break;
            case 10:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 3";
                    Question.text = "Hvilke 5 typer af antiemetika findes der?";
                    BonusQuestion.text = "Kan du nævne præparater der tilhører de forskellige grupper?";
                    Answer.text = "• Dopaminreceptor-antagonister • Serotoninreceptor-antagonister • Neurokininreceptor-antagonister • Multireceptor-antagonister • Kortikosteroider ";
                    BonusAnswer.text = "• Dopaminreceptor-antagonister: Domperidon, Metopimazin, Metoclopramid • Serotoninreceptor-antagonister: Ondansetron, Palonosetron, Granisetron • Neurokininreceptor-antagonister: Aprepitant, Netupitant • Multireceptor-antagonister: Olanzapin • Kortikosteroider: Prednisolon, Methylprednisolon, Dexamethason";
                }
                else
                {
                    Category.text = "Pharmacology 3";
                    Question.text = "What are the 5 types of antiemetics?";
                    BonusQuestion.text = "Can you name preparations that belong to the different groups?";
                    Answer.text = "• Dopamine receptor antagonists • Serotonin receptor antagonists • Neurokinin receptor antagonists • Multireceptor antagonists • Corticosteroids";
                    BonusAnswer.text = "• Dopamine receptor antagonists: Domperidone, Metopimazine, Metoclopramide • Serotonin receptor antagonists: Ondansetron, Palonosetron, Granisetron • Neurokinin receptor antagonists: Aprepitant, Netupitant • Multireceptor antagonists: Olanzapine • Corticosteroids: Prednisolone, Methylprednisolone, Dexamethasone";
                }
                break;
            case 11:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 4";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Ondansetron?";
                    BonusQuestion.text = "Nævn hvordan Ondansetron kan dispenseres?";
                    Answer.text = "Hyppigste bivirkninger (≥ 1%)\r\n" +
                        "• Obstipation\r\n• Hovedpine";
                    BonusAnswer.text = "• Oralt: Kan knuses eller opslæmmes i vand. Indtages uden hensyn til måltider • IV: 8-16 mg. Initialdosis må ikke overskride 16 mg ved korttidsinfusion over 15 minutter • Suppositorie: 16 mg • Smelt: 4 mg – 8 mg ";

                }
                else
                {
                    Category.text = "Pharmacology 4";
                    Question.text = "What are the most common side effects of Ondansetron?";
                    BonusQuestion.text = "How can Ondansetron be dispensed?";
                    Answer.text = "Most common side effects (≥ 1%)\r\n• Constipation\r\n• Headache";
                    BonusAnswer.text = "• Oral: Can be crushed or suspended in water. Taken without regard to meals • IV: 8-16 mg. The initial dose must not exceed 16 mg for a short-term infusion over 15 minutes • Suppository: 16 mg • Melt: 4 mg – 8 mg";
                }
                break;
            case 12:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 5";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Palonosetron?";
                    BonusQuestion.text = "Nævn hvordan Palonosetron kan dispenseres?";
                    Answer.text = "Hyppigste bivirkninger (≥ 1%)\r\n" +
                        "• Hovedpine • Svimmelhed • Obstipation • Diarré";
                    BonusAnswer.text = "• Oralt: Indtages hel. Indtages uden hensyntagen til måltider\r\n• IV: Intravenøs Palonosteron: 0,25 mg svarer til 0,5 mg peroral Palonosetron";

                }
                else
                {
                    Category.text = "Pharmacology 5";
                    Question.text = "What are the most common side effects of Palonosetron?";
                    BonusQuestion.text = "Name how Palonosetron can be dispensed?";
                    Answer.text = "Most common side effects (≥ 1%)\r\n" +
                        "• Headache • Dizziness • Constipation • Diarrhea";
                    BonusAnswer.text = "• Oral: Taken whole. Taken without regard to meals\r\n• IV: Intravenous Palonosetron: 0.25 mg is equivalent to 0.5 mg oral Palonosetron";
                }
                break;
            case 13:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 6";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Aprepritant?";
                    BonusQuestion.text = "Nævn hvordan Aprepritant kan dispenseres?";
                    Answer.text = "Hyppigste bivirkninger (≥ 1%)\r\n" +
                        "• Hikke • Forhøjet levertransaminaser • Dyspepsi • Obstipation • Hovedpine • Nedsat appetit • Træthed";
                    BonusAnswer.text = "• Oralt: Kapslen kan åbnes og opslæmmes i vand. Indtages uden hensyntagen til måltider\r\n• IV: Intravenøs Aprepitant kaldes Fosaprepitant 150 mg dag 1(behandlingsdagen), har samme effekt som peroral aprepitant i 3 dage."; //Forsaprepitant er ikke registreret i Danmark, men kan fås vha. en udleveringstilladelse fra Lægemiddelstyrelsen
                }
                else
                {
                    Category.text = "Pharmacology 6";
                    Question.text = "What are the most common side effects of Aprepitant?";
                    BonusQuestion.text = "How can Aprepitant be dispensed?";
                    Answer.text = "Most common side effects (≥ 1%)\r\n" +
                        "• Hiccups • Elevated liver transaminases • Dyspepsia • Constipation • Headache • Decreased appetite • Fatigue";
                    BonusAnswer.text = "• Orally: The capsule can be opened and suspended in water. Taken without regard to meals.\r\n• IV: Intravenous Aprepitant is called Fosaprepitant 150 mg on day 1 (treatment day), has the same effect as oral Aprepitant for 3 days."; //Fosaprepitant is not registered in Denmark but can be obtained through a dispensing permit from the Danish Medicines Agency.
                }
                break;
            case 14:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 7";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Netupitant-Palonosetron \r\n(NEPA)?";
                    BonusQuestion.text = "Nævn hvordan NEPA kan dispenseres?";
                    Answer.text = "Hyppigste bivirkninger (≥ 1%)\r\n" +
                        "• Hovedpine • Obstipation • Træthed";
                    BonusAnswer.text = "• Oralt: Kapslen indtages hel. Indtages uden hensyntagen til måltider";

                }
                else
                {
                    Category.text = "Pharmacology 7";
                    Question.text = "What are the most common side effects of Netupitant-Palonosetron (NEPA)?";
                    BonusQuestion.text = "How can NEPA be dispensed?";
                    Answer.text = "Most common side effects (≥ 1%)\r\n" +
                        "• Headache • Constipation • Fatigue";
                    BonusAnswer.text = "• Orally: The capsule is taken whole. Taken without regard to meals.";
                }
                break;
            case 15:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 8";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Olanzapin?";
                    BonusQuestion.text = "Nævn hvordan kan det dispenseres?";
                    Answer.text = "Hyppigste bivirkninger (≥ 1%)\r\n" +
                        "• Døsighed • Vægtøgning • Eosinofili • Hyperprolaktinæmi • Hyperglykæmi • Glykosuri • Svimmelhed • Ortostatisk hypotension • Antikolinerge symptomer • Øget appetit";
                    BonusAnswer.text = "• Oralt: Kan knuses eller opslæmmes i vand. Indtages uden hensyn til måltider\r\n • Smelt ";

                }
                else
                {
                    Category.text = "Pharmacology 8";
                    Question.text = "What are the most common side effects of Olanzapine?";
                    BonusQuestion.text = "How can it be dispensed?";
                    Answer.text = "Most common side effects (? 1%)\r\n" +
                        "• Drowsiness • Weight gain • Eosinophilia • Hyperprolactinemia • Hyperglycemia • Glycosuria • Increased appetite • Dizziness • Orthostatic hypotension • Anticholinergic symptoms";
                    BonusAnswer.text = "• Orally: Can be crushed or suspended in water. Taken without regard to meals\r\n• Dissolvable";
                }
                break;
            case 16:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 9";
                    Question.text = " Hvilke bivirkninger opleves ofte ved Prednisolon – nævn 5?";
                    BonusQuestion.text = "Nævn hvordan Prednisolon kan dispenseres?";
                    Answer.text = "• Uro og søvnløhed • Rødme og blussende ansigt • Øget appetit og vægtøgning • Dyspepsi";
                    BonusAnswer.text = "• Oralt: Kan knuses eller opslæmmes i vand \r\n• IV: Methylprednisolon: 40 mg, svarer til 50 mg peroral Prednisolon";

                }
                else
                {
                    Category.text = "Pharmacology 9";
                    Question.text = "What side effects are often experienced with Prednisolone – name 5?";
                    BonusQuestion.text = "Name how Prednisolone can be dispensed?";
                    Answer.text = "• Restlessness and insomnia • Redness and flushed face • Increased appetite and weight gain • Dyspepsia";
                    BonusAnswer.text = "• Orally: Can be crushed or suspended in water\r\n• IV: Methylprednisolone: 40 mg, equivalent to 50 mg oral Prednisolone";
                }
                break;
            case 17:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 10";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Lorazepam?";
                    BonusQuestion.text = "Nævn hvordan kan det dispenseres?";
                    Answer.text = "Hyppigste bivirkninger (≥ 1%)\r\n" +
                        "• Træthed • Døsighed • Sedation • Kraftesløshed • Muskelsvaghed • Ataksi • Depression • Konfusion • Svimmelhed";
                    BonusAnswer.text = "• Oralt: Delekærv, det vil sige at dosis kan deles \r\n• Lorazepam – 1 mg max 1 mg i døgnet";


                }
                else
                {
                    Category.text = "Pharmacology 10";
                    Question.text = "What are the most common side effects of Lorazepam?";
                    BonusQuestion.text = "How can it be dispensed?";
                    Answer.text = "Most common side effects (? 1%)\r\n" +
                        "• Fatigue • Drowsiness • Sedation • Weakness • Muscle weakness • Ataxia • Depression • Confusion • Dizziness";
                    BonusAnswer.text = "• Orally: Breakable score, meaning the dose can be divided\r\n• Lorazepam – 1 mg max 1 mg per day";
                }
                break;
            case 18:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 11";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Metopimazin?";
                    BonusQuestion.text = "Hvordan kan det dispenseres?";
                    Answer.text = "Hyppigste bivirkninger (≥ 1%)\r\n" +
                        "• Mundtørhed • Let sedation • Obstipation specielt ved kombination med seroton inantagonister • Ortostatisk hypotension • Svimmelhed • Symptomer på hyperprolaktinæmi (inkl. seksuel dysfunktion) • Urinretention • Ekstrapyrimidale bivirkninger";
                    BonusAnswer.text = "Oralt: Indtages hel, før måltider.\r\n" +
                        "• Moderat- og højemetogen behandling = 30 mg x 4, i 4 dage\r\n• Lavemetogen behandling = 15 mg x 4, i 4 dage";
                }
                else
                {
                    Category.text = "Pharmacology 11";
                    Question.text = "What are the most common side effects of Metopimazine?";
                    BonusQuestion.text = "How can it be dispensed?";
                    Answer.text = "Most common side effects (≥ 1%)\r\n" +
                        "• Dry mouth • Mild sedation • Constipation, especially when combined with serotonin antagonists • Orthostatic hypotension • Dizziness • Symptoms of hyperprolactinemia (including sexual dysfunction) • Urinary retention • Extrapyramidal side effects occur very rarely.";
                    BonusAnswer.text = "Orally: Taken whole, before meals.\r\n" +
                        "• Moderate and high emetic treatment = 30 mg x 4, for 4 days\r\n• Low emetic treatment = 15 mg x 4, for 4 days";
                }
                break;
            case 19:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 12";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Domperidon?";
                    BonusQuestion.text = "Nævn hvordan kan det dispenseres?";
                    Answer.text = "Hyppigste bivirkninger (≥ 1%)\r\n" +
                        "• Agitation • Angst • Ekstrapyramidale gener • Nervøsitet • Somnolens • Svimmelhed";
                    BonusAnswer.text = "Oralt: Kan knuses eller opslæmmes i vand. Indtages før måltider.";
                }
                else
                {
                    Category.text = "Pharmacology 12";
                    Question.text = "What are the most common side effects of Domperidone?";
                    BonusQuestion.text = "How can it be dispensed?";
                    Answer.text = "Most common side effects (? 1%)\r\n" +
                        "• Agitation • Anxiety • Extrapyramidal symptoms • Nervousness • Somnolence • Dizziness";
                    BonusAnswer.text = "Orally: Can be crushed or suspended in water. Taken before meals.";
                }
                break;
            case 20:
                colorBoxLil.color = Color.yellow;
                colorBoxBig.color = Color.yellow;
                if (lang)
                {

                    Category.text = "Farmakologi 13";
                    Question.text = "Hvilke bivirkninger er hyppigst ved Metoclopramid?";
                    BonusQuestion.text = "Nævn hvordan kan det dispenseres?";
                    Answer.text = "Hyppigste bivirkninger (? 1%)\r\n" +
                        "• Døsighed • Kraftesløshed • Diarré • Mundtørhed • Hypotension (især efter i.v. indgift) • Akatisi • Depression • Ekstrapyramidale gener • Parkinsonisme";
                    BonusAnswer.text = "Oralt: Delekærv, det vil sige dosis kan deles";
                }
                else
                {
                    Category.text = "Pharmacology 13";
                    Question.text = "What are the most common side effects of Metoclopramide?";
                    BonusQuestion.text = "How can it be dispensed?";
                    Answer.text = "Most common side effects (? 1%)\r\n" +
                        "• Drowsiness • Weakness • Diarrhea • Dry mouth • Hypotension (especially after i.v. administration) • Akathisia • Depression • Extrapyramidal symptoms • Parkinsonism";
                    BonusAnswer.text = "Orally: Scored tablet, meaning the dose can be divided";
                }
                break;
            case 21:
                colorBoxLil.color = Color.red;
                colorBoxBig.color = Color.red;
                if (lang)
                {

                    Category.text = "Kvalmeanamese 1";
                    Question.text = "Hvorfor optager man en kvalmeanamnese?";
                    BonusQuestion.text = "Hvilke konsekvenser kan det have for patienten, hvis den antiemetiske behandling ikke har været optimal?";
                    Answer.text = "• For at forebygge kvalme og opkastning\r\n• For at sikre der gives bedst mulig antiemetisk behandling\r\n• For at identificere eventuelle patientrelaterede risikofaktorer";
                    BonusAnswer.text = "• Ved længerevarende kvalme og opkastning kan daglige aktiviteter indskrænkes og livskvalitet blive forringet\r\n• Der er risiko for at den medicinske kræftbehandling ikke kan gives";
                }
                else
                {
                    Category.text = "Nausea Anamnesis 1";
                    Question.text = "Why is a nausea anamnesis taken??";
                    BonusQuestion.text = "What consequences can it have for the patient if the antiemetic treatment has not been optimal?";
                    Answer.text = "• To prevent nausea and vomiting.\r\n• To ensure the best possible antiemetic treatment is given.\r\n• To identify any patient-related risk factors.";
                    BonusAnswer.text = "• With prolonged nausea and vomiting, daily activities may be restricted and quality of life may deteriorate.\r\n• There is a risk that the medical cancer treatment cannot be administered.";
                }
                break;
            case 22:
                colorBoxLil.color = Color.red;
                colorBoxBig.color = Color.red;
                if (lang)
                {

                    Category.text = "Kvalmeanamese 2";
                    Question.text = "Hvornår skal der foretages en kvalmeanamnese?";
                    BonusQuestion.text = "Hvad er den vigtigste informationskilde når du laver en kvalmeanamnese?";
                    Answer.text = "• Før hver behandling\r\n• Ved gennembrudskvalme eller -opkastning";
                    BonusAnswer.text = "Det vigtigste er samtalen med din patient og husk at pårørende også kan være en god kilde til viden når du optager en anamnese";
                }
                else
                {
                    Category.text = "Nausea Anamnesis 2";
                    Question.text = "When should a nausea anamnesis be taken??";
                    BonusQuestion.text = "What is the most important source of information when you conduct a nausea history?";
                    Answer.text = "• Before each treatment\r\n• In case of breakthrough nausea or vomiting";
                    BonusAnswer.text = "The most important thing is the conversation with your patient, and remember that relatives can also be a good source of information when you take a history.";
                }   
                break;
            case 23:
                colorBoxLil.color = Color.red;
                colorBoxBig.color = Color.red;
                if (lang)
                {

                    Category.text = "Kvalmeanamese 3";
                    Question.text = "Hvilke risikofaktorer hos patienten har betydning for kvalmeanamnesen?";
                    BonusQuestion.text = "Kan du uddybe hvordan de ovenstående faktorer har indflydelse?\r\n+ = øget risiko\r\n- = nedsat risiko";
                    Answer.text = "• Tidligere behandling med medicinsk kræftbehandling • Køn • Alder • Psykologiske faktorer • Træthed • Alkohol • Tidligere erfaring med kvalme";
                    BonusAnswer.text = "• Kvinder+ • Yngre+ • Psykologiske faktorer: angst, nervøsitet, opfattelse af sygdom og behandling+ • Træthed+ • Tidligere erfaring med kvalme i form af transport syge, graviditet+ • Tidligere medicinsk kræftbehandling+ • Alkoholmisbrug-";
                }
                else
                {
                    Category.text = "Nausea Anamnesis 3";
                    Question.text = "Which risk factors in the patient are significant for the nausea anamnesis?";
                    BonusQuestion.text = "Can you elaborate on how the above factors influence?\r\n+ = increased risk \r\n- = decreased risk";
                    Answer.text = "• Previous treatment with medical cancer treatment • Gender • Age • Psychological factors • Fatigue • Alcohol • Previous experience with nausea";
                    BonusAnswer.text = "• Women+ • Younger+ • Psychological factors: anxiety, nervousness, perception of illness and treatment+ • Fatigue+ • Previous experience with nausea in the form of motion sickness, pregnancy+ • Previous medical cancer treatment+ • Alcohol abuse-";
                }
                break;
            case 24:
                colorBoxLil.color = Color.red;
                colorBoxBig.color = Color.red;
                if (lang)
                {

                    Category.text = "Kvalmeanamese 4";
                    Question.text = "Hvilke informationer er vigtige at indhente i kvalmeanamnesen ved gennembrudskvalme og -opkastning?";
                    BonusQuestion.text = "Hvis det er mere end 5 dage siden patienten sidst fik medicinsk kræftbehandling hvilke andre årsager?";
                    Answer.text = "• Undersøg om det er mere end 5 dage siden patienten sidst har fået medicinsk kræftbehandling • Kvalme intensitet (fx skala fra 0-10) • Tidspunkt for symptomdebut: akut (0-24 t) eller sen fase (25-120 t) • Højeste antal af evt opkastninger i en 24-timers periode • Kan/kunne patienten spise og drikke, mens der er/var symptomer? • Hvilke antiemetika blev indtaget og hvornår?";
                    BonusAnswer.text = "• Sygdomsudbredning • Sygdommens placering • Elektrolytbalance • Medicin • Sult • Dyspepsi  • Smerter • Træthed • Svampeinfektion i mund og hals • Obstipation • Reaktion på stråleterapi";
                }
                else
                {
                    Category.text = "Nausea Anamnesis 4";
                    Question.text = "What information is important to gather in the nausea history in cases of breakthrough nausea and vomiting?";
                    BonusQuestion.text = "If it has been more than 5 days since the patient last received medical cancer treatment, what other causes?";
                    Answer.text = "• Check if it has been more than 5 days since the patient last received medical cancer treatment • Nausea intensity (e.g., scale from 0-10) • Onset of symptoms: acute (0-24 hours) or late phase (25-120 hours) • Highest number of possible vomits in a 24-hour period • Could/can the patient eat and drink while experiencing symptoms? • Which antiemetics were taken and when?";
                    BonusAnswer.text = "• Disease progression • Location of the disease • Electrolyte balance • Medication • Hunger • Dyspepsia • Pain • Fatigue • Fungal infection in the mouth and throat • Constipation • Reaction to radiation therapy";
                }
                break;
            case 25:
                colorBoxLil.color = Color.red;
                colorBoxBig.color = Color.red;
                if (lang)
                {

                    Category.text = "Kvalmeanamese 5";
                    Question.text = "Hvad kan patienten selv gøre for at lindre kvalme og opkastning?";
                    BonusQuestion.text = "";
                    Answer.text = "• Drikke rigeligt • Let måltid før behandling • Små lette måltider generelt • Bære løsthængende bekvemt tøj • Adspredelse, fx film, bøger, TV, musik m.m. • God mundhygiejne/pleje • Fysisk aktivitet • Rolige omgivelser • Pårørende og sygeplejerskens tilstedeværelse kan dæmpe angst og uro";
                    BonusAnswer.text = "";
                }
                else
                {
                    Category.text = "Nausea Anamnesis 5";
                    Question.text = "What can the patient do to alleviate nausea and vomiting?";
                    BonusQuestion.text = "";
                    Answer.text = "• Drink plenty of fluids • Light meal before treatment • Small, light meals in general • Wear loose, comfortable clothing • Distraction, e.g., movies, books, TV, music, etc. • Good oral hygiene/care • Physical activity • Calm surroundings • Presence of relatives and the nurse can reduce anxiety and restlessness";
                    BonusAnswer.text = "";
                }
                break;
            case 26:
                colorBoxLil.color = Color.red;
                colorBoxBig.color = Color.red;
                if (lang)
                {

                    Category.text = "Kvalmeanamese 6";
                    Question.text = "Hvilke fysiske symptomer ses ved kvalme og opkastning?";
                    BonusQuestion.text = "Hvilke sygeplejehandlinger er relevante for en patient med kvalme og opkastning?";
                    Answer.text = "• Forhøjet puls • Hjertebanken • Bleghed • Kold og klamtsvedende • Øget spytsekretion • Madlede";
                    BonusAnswer.text = "• Kold klud på panden • Afskærmning og skabe ro omkring patienten • Bliv ved patienten, hvis muligt • Sørg for at patienten har noget at kaste op i og at fjerne evt. opkast straks • Tilbyde vand • Frisk luft • Giv evt. pn antiemetika";
                }
                else
                {
                    Category.text = "Nausea Anamnesis 6";
                    Question.text = "What physical symptoms are seen with nausea and vomiting?";
                    BonusQuestion.text = "What nursing actions are relevant for a patient with nausea and vomiting?";
                    Answer.text = "• Increased pulse • Palpitations • Pallor • Cold and clammy sweat • Increased saliva secretion • Aversion to food";
                    BonusAnswer.text = "• Cold cloth on the forehead • Shielding and creating calm around the patient • Stay with the patient, if possible • Ensure the patient has something to vomit into and remove any vomit immediately • Offer water • Fresh air • Possibly give as needed antiemetics";
                }
                break;
            case 27:
                colorBoxLil.color = Color.cyan;
                colorBoxBig.color = Color.cyan;
                if (lang)
                {

                    Category.text = "Cases 1";
                    Question.text = "Ulla ringer ind til afdelingen 14 dage efter afsluttet behandling. Hun har stadig kvalme.\r\nHvad vil du gerne vide?";
                    BonusQuestion.text = "Tænk også gerne andre årsager, da det er 14 dage siden afsluttet behandling.\r\nHvilke årsager kunne det være?";
                    Answer.text = "Indsaml viden til kvalmeanamnesen og tænk hele vejen rundt.";
                    BonusAnswer.text = "• Ileus • Svampeinfektion i mund og hals • Elektrolytforstyrrelser • Infektioner • Obstipation • Strålebehandling • Mavesyre • Metastaser";
                }
                else
                {
                    Category.text = "Cases 1";
                    Question.text = "Ulla calls the department 14 days after completing treatment. She still has nausea.\r\nWhat would you like to know?";
                    BonusQuestion.text = "Also consider other causes, as it has been 14 days since the treatment ended.\r\nWhat could the causes be?";
                    Answer.text = "Gather information for the nausea history and think comprehensively.";
                    BonusAnswer.text = "• Ileus • Fungal infection in the mouth and throat • Electrolyte disturbances • Infections • Constipation • Radiation therapy • Stomach acid • Metastases";
                }
                break;
            case 28:
                colorBoxLil.color = Color.cyan;
                colorBoxBig.color = Color.cyan;
                if (lang)
                {
                    Category.text = "Cases 2";
                    Question.text = "Vivi møder i afdelingen til 2. behandling. Hun kaster op i ventearealet.\r\nHvilke tanker gør du dig?\r\nHvilke handlinger er relevante?";
                    BonusQuestion.text = "Hvad kan du gøre i forhold til den antiemetiske behandling inden næste behandlingsserie?";
                    Answer.text = "Der kan være tale om forventningskvalme.\r\nHandlinger kan bestå af, at få Vivi skærmet. Sørge for frisk luft og noget at drikke.";
                    BonusAnswer.text = "• Anvende tbl. lorazepam dagen før om aftenen og på behandlingsdagen 1 time før • Optag en kvalmeanamnese med henblik på at vurdere om der er brug for optimering af den antiemetiske behandling • Overvej skifte fra tablet til I.V. antiemetika • Evaluer effekt af P.N. behandling";
                }
                else
                {
                    Category.text = "Cases 2";
                    Question.text = "Vivi arrives at the department for her second treatment. She vomits in the waiting area.\r\nWhat thoughts do you have?\r\nWhat actions are relevant?";
                    BonusQuestion.text = "What can you do regarding the antiemetic treatment before the next treatment series?";
                    Answer.text = "It may be a case of anticipatory nausea. Actions may include shielding Vivi, ensuring fresh air, and providing something to drink.";
                    BonusAnswer.text = "• Administer lorazepam tablets the evening before and 1 hour before treatment on the treatment day • Take a nausea history to assess whether there is a need to optimize the antiemetic treatment • Consider switching from oral to IV antiemetics • Evaluate the effectiveness of PRN treatment.";
                }
                break;
            case 29:
                colorBoxLil.color = Color.cyan;
                colorBoxBig.color = Color.cyan;
                if (lang)
                {
                    Category.text = "Cases 3";
                    Question.text = "Søren ringer ind til afdelingen en uge efter behandling med højemetogen kemoterapi. Han har mavesmerter.\r\nHvad vil du vide?";
                    BonusQuestion.text = "Hvad ved du om bivirkninger til den antiemetiske behandling?\r\nGiv eksempler som kan forklare Sørens situation.";
                    Answer.text = "• Har Søren kvalme? • Hvis ja, hvilken antiemetisk behandling er der anvendt? • Er Søren obstiperet? • Har Søren fået nok væske? • Har Søren feber? • Hvor mobil er Søren?";
                    BonusAnswer.text = "Ondansetron, Akynzeo og Aloxi, kan i 1-10 % af tilfældene være årsag til obstipation.";
                }
                else
                {
                    Category.text = "Cases 3";
                    Question.text = "Søren calls the department a week after treatment with high-dose chemotherapy. He has stomach pain.\r\nWhat do you want to know?";
                    BonusQuestion.text = "What do you know about the side effects of the antiemetic treatment?\r\nGive examples that can explain Søren's situation.";
                    Answer.text = "• Does Søren have nausea? • If yes, what antiemetic treatment has been used? • Is Søren constipated? • Has Søren had enough fluids? • Does Søren have a fever? • How mobile is Søren?";
                    BonusAnswer.text = "Ondansetron, Akynzeo, and Aloxi can cause constipation in 1-10% of cases.";
                }
                break;
            case 30:
                colorBoxLil.color = Color.cyan;
                colorBoxBig.color = Color.cyan;
                if (lang)
                {

                    Category.text = "Cases 4";
                    Question.text = "Karl ringer ind til afdelingen 5 dage efter behandlingen og har kvalme\r\nHvad vil du vide?";
                    BonusQuestion.text = "Hvad kan hjælpen til Karl bestå af?";
                    Answer.text = "• Hvilken medicinsk kræftbehandling har Karl fået? • Hvilken antiemetika er der anvendt? • Hvornår har patienten taget sin antiemetika taget? • Har Karl fået væske og mad nok? • Er der andre sygdomme i spil? • Har Karl obstipation? • Har Karl feber?";
                    BonusAnswer.text = "• Vejledning i p.n-medicin • Anbefalinger i forhold til kost, drikke og motion • Brug din viden og erfaring – du kan godt :) De andre kort kan eventuelt hjælpe dig videre";
                }
                else
                {
                    Category.text = "Cases 4";
                    Question.text = "Karl calls the department 5 days after the treatment and has nausea.\r\nWhat do you want to know?";
                    BonusQuestion.text = "What assistance can be provided to Karl?";
                    Answer.text = "• What type of medical cancer treatment has Karl received? • What antiemetic has been used? • When has the patient taken his antiemetic? • Has Karl had enough fluids and food? • Are there other diseases involved? • Does Karl have constipation? • Does Karl have a fever?";
                    BonusAnswer.text = "• Guidance on as-needed medication • Recommendations regarding diet, drink, and exercise • Use your knowledge and experience – you can do it :) The other cards may potentially help you further.";
                }
                break;
            case 31:
                colorBoxLil.color = Color.cyan;
                colorBoxBig.color = Color.cyan;
                if (lang)
                {

                    Category.text = "Cases 5";
                    Question.text = "Dorthe henvender sig i afdelingen. Hun oplever ufrivillige bevægelser, kæben kører rundt, tungen er stor og hun føler at ansigtet er mærkeligt. Dette gør hende bange.\r\nHvad vil du vide og hvilke tanker gør du dig?";
                    BonusQuestion.text = "Hvilke antiemetika kan give ekstrapyramidale bivirkninger?";
                    Answer.text = "• Hvilken PN antiemetika har Dorthe taget? • Kan det være ekstrapyramidale bivirkninger (EPS) forårsaget af medicinen?";
                    BonusAnswer.text = "• Metoclopramid • Domperidon (går kun sjældent over blodhjernebarrieren) • Overvej skift af PN antiemetika";
                }
                else
                {
                    Category.text = "Cases 5";
                    Question.text = "Dorthe approaches the department. She experiences involuntary movements, her jaw is moving around, her tongue is large, and she feels that her face is strange. This makes her scared.\r\nWhat would you like to know and what thoughts do you have?";
                    BonusQuestion.text = "Which antiemetics can cause extrapyramidal side effects?";
                    Answer.text = "• What PN antiemetic has Dorthe taken? • Could it be extrapyramidal side effects (EPS) caused by the medication?";
                    BonusAnswer.text = "• Metoclopramide • Domperidone (rarely crosses the blood-brain barrier) • Consider switching the PN antiemetic.";
                }
                break;
            case 32:
                colorBoxLil.color = Color.cyan;
                colorBoxBig.color = Color.cyan;
                if (lang)
                {

                    Category.text = "Cases 6";
                    Question.text = "Bente har i forbindelse med sin medicinske kræftbehandling fået høj emetogen antiemetika. Hun ringer til afdelingen og fortæller hun har voldsom kvalme og ligger i sengen det meste af dagen, for nedrullede gardiner.\r\nHvilke yderligere informationer ønsker du at få fra Bente?";
                    BonusQuestion.text = "Hvilke overvejelser gør du dig inden næste behandlingsserie?";
                    Answer.text = "• Hvornår har Bente sidst fået medicinsk kræftbehandling og hvornår skal hun have næste behandling? • Afdæk om det er akut eller senkvalme • Hvilken antiemetika har Bente brugt og hvordan har hun taget den? • Hvor meget væske og føde har Bente indtaget, er det nok? • Har Bente obstipation? • Har Bente feber? • Har Bente hovedpine/migræne?";
                    BonusAnswer.text = "• Hvis patienten har hovedpine, kan det være en bivirknin til den antiemetiske behandling. Både Palonosetron samt Akynzeo kan give hovedpine. • Er patienten kendt med migræne • Lav en kvalmeanamnese • Tal med patienten om forventnings kvalme.";
                }
                else
                {
                    Category.text = "Cases 6";
                    Question.text = "Bente has received highly emetogenic antiemetics in connection with her medical cancer treatment. She calls the department and reports that she has severe nausea and spends most of the day in bed with the curtains drawn. What additional information would you like to get from Bente?";
                    BonusQuestion.text = "What considerations do you make before the next treatment series?";
                    Answer.text = "• When did Bente last receive medical cancer treatment and when is her next treatment scheduled? • Determine whether it is acute or delayed nausea. • Which antiemetic has Bente used and how has she taken it? • How much fluid and food has Bente consumed, is it enough? • Does Bente have constipation? • Does Bente have a fever? • Does Bente have a headache/migraine?";
                    BonusAnswer.text = "• If the patient has a headache, it may be a side effect of the antiemetic treatment. Both Palonosetron and Akynzeo can cause headaches. • Is the patient known to have migraines? • Conduct a nausea history. • Discuss expectation-related nausea with the patient.";
                }
                break;
            case 33:
                colorBoxLil.color = Color.cyan;
                colorBoxBig.color = Color.cyan;
                if (lang)
                {

                    Category.text = "Cases 7";
                    Question.text = "Mette ringer til afdelingen. Hun fortæller at hun har fået medicinsk kræftbehandling og har kastet op siden behandlingsdagen.\r\nHvilke yderligere informationer vil du spørge indtil, hos Mette?";
                    BonusQuestion.text = "Mette får behandling der har moderat-emetogenpotentiale. Ved sidste behandling havde hun svært ved at få drukket og spist, regelmæssigt og tilstrækkeligt. Hvilke tiltag vil du gøre ved kommende behandling?";
                    Answer.text = "• Hvor mange dage er det siden det var sidste behandlingsdag? • Hvornår skal Mette have næste behandling? • Hvilken behandling får Mette? (få viden om det emetogene potentiale) • Hvor mange gange har Mette kastet op og hvornår? • Har Mette taget p.n. antiemetika (compliance)? • Hvor meget væske og mad har Mette fået? • Hvad har Mette selv gjort for at afhjælpe dette?";
                    BonusAnswer.text = "• Opgradere kvalmebehandling svarende til behandling med høj-emetogenpotentiale • Undervise Mette i brugen af PN og understrege, at tage denne inden kvalmen bliver for voldsom • Undervise i Mette i at få små hyppige måltider, rigelig væske, motion osv. • Lav en kvalmeanamnese for at afdække eventuelle risikofaktorer";
                }
                else
                {
                    Category.text = "Cases 7";
                    Question.text = "Mette calls the department. She reports that she has received medical cancer treatment and has been vomiting since the treatment day.\r\nWhat additional information would you ask Mette about?";
                    BonusQuestion.text = "Mette is receiving treatment that has moderate emetogenic potential. During her last treatment, she had difficulty drinking and eating regularly and sufficiently. What measures would you take for the upcoming treatment?";
                    Answer.text = "• How many days has it been since the last treatment day? • When is Mette scheduled for her next treatment? • What treatment is Mette receiving? (to gain knowledge about its emetogenic potential) • How many times has Mette vomited and when? • Has Mette taken any p.r.n. antiemetics (compliance)? • How much fluid and food has Mette consumed? • What has Mette done herself to alleviate this?";
                    BonusAnswer.text = "• Upgrade nausea treatment corresponding to high emetogenic potential treatment. • Educate Mette on the use of p.r.n. and emphasize taking it before nausea becomes too severe. • Teach Mette to have small frequent meals, plenty of fluids, exercise, etc. • Create a nausea history to identify any risk factors.";
                }
                break;
            case 34:
                colorBoxLil.color = Color.cyan;
                colorBoxBig.color = Color.cyan;
                if (lang)
                {

                    Category.text = "Cases 8";
                    Question.text = "Jan kommer i afdelingen til 2.serie af sin medicinske kræftbehandling. Han har ikke spist noget i ugen efter 1. behandling grundet madlede. Da Jan kommer til behandling, afleverer han prednisolon som han skulle have taget dagene efter behandling mod senkvalme.\r\nHvilke overvejelser gør du dig?";
                    BonusQuestion.text = "Hvordan hjælper vi Jan gennem behandlingen, så han undgår en lignende situation?";
                    Answer.text = "• Hvorfor har Jan ikke anvendt antiemetika? (compliance) • Hvordan er Jans forhold til at tage piller generelt, hvad er hans forståelse af hvordan pillerne virker og vigtigheden i at tage dem? • Er der andre forhold, som evt. kan have indvirkning, hukommelsesbesvær, svært ved at læse, dårlig forståelse af patientinformation.";
                    BonusAnswer.text = "• Evt. alarm på telefonen – hvad passer til Jan? • Er der behov for at inddrage pårørende og/eller hjemmepleje, for at støtte op om at antiemetika tages korrekt? • Yderligere patientundervisning (tale om at madlede også er kvalme og at det er vigtig at tage den ordinerede antiemetiske behandling for at kunne spise)";
                }
                else
                {
                    Category.text = "Cases 8";
                    Question.text = "Jan comes to the department for the second series of his medical cancer treatment. He has not eaten anything in the week following the first treatment due to loss of appetite. When Jan arrives for treatment, he hands over the prednisolone he was supposed to take in the days after treatment to prevent delayed nausea. \r\nWhat considerations do you have?";
                    BonusQuestion.text = "How do we help Jan through the treatment so he avoids a similar situation?";
                    Answer.text = "• Why has Jan not used antiemetics? (compliance) • What is Jan's general attitude towards taking pills, what is his understanding of how the pills work and the importance of taking them? • Are there other factors that may have an impact, such as memory issues, difficulty reading, poor understanding of patient information?";
                    BonusAnswer.text = "• Possibly an alarm on the phone – what suits Jan? • Is there a need to involve relatives and/or home care to support the correct intake of antiemetics? • Additional patient education (discussing that loss of appetite is also nausea and that it is important to take the prescribed antiemetic treatment in order to be able to eat)";
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
            colorBoxBig = colorBoxBig2;
            colorBoxLil = colorBoxLil2;
        }
        else
        {
            Category = Category1;
            Question = Question1;
            BonusQuestion = BonusQuestion1;
            Answer = Answer1;
            BonusAnswer = BonusAnswer1;
            colorBoxBig = colorBoxBig1;
            colorBoxLil = colorBoxLil1;
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
