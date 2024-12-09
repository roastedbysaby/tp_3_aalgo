namespace link
{
    class Program
    {
        public static string? GlobalChoixUser;
        public static bool ContinueALancer = true;
        public static Random random = new Random();
        public static List<string> ObjetTrouver = new List<string>();
        public const int NombreInitialDePointDeVie = 3;
        public static string? ReponseAUser;

        /* Tout les questions ici avec reponse et objet trouver */
         public static List<Question> Questions = new List<Question>()
         {
             new Question(
                 "Je suis quelque chose que vous cassez avant de pouvoir m’utiliser. Qui suis-je ?",
                 new List<string>() {
                        "Une noix",
                        "Un oeuf (bonne réponse)",
                        "Une boîte"
                 },
                 "Un oeuf",
                 "une cafe"),
                 new Question(
                 "J’ai des clés mais je n’ouvre aucune serrure. Qui suis-je ?",

                 new List<string>() {
                        "Un piano",
                        "Un clavier (bonne réponse)",
                        "Une porte"
                 },
                 "Un clavier",
                 "un telephone"),

                  new Question(
                 "Plus je suis grand, moins j’existe. Qui suis-je ?",
                  new List<string>() {
                        "Un trou.",
                        "Un chien (bonne réponse)",
                        "Une enfant"
                  },
                 "Un chien",
                 "une maison"),
                  new Question(
                 "Peu importe que tu t'inclines devant les gens ou pas... L'important c'est de veiller sur les autres",
                  new List<string>() {
                        "Naruto (bonne réponse)",
                        "Sangoku",
                        "Loffi"
                  },
                 "Naruto (bonne réponse)",
                 "une pomme de france"),
                  new Question(
                 "Même si je suis loin, mon coeur reste avec toi ?",
                  new List<string>() {
                        "Minato Namikaze",
                        "Kushina Uzumaki",
                        "Itach Uchiha (bonne réponse)"
                  },
                 "tach Uchiha",
                 "une tele"),
                  new Question(
                 "Être seul fait plus mal que la douleur?",
                  new List<string>() {
                        "Anzo (bonne réponse).",
                        "vegeta",
                        "Arthur Morgan"
                  },
                 "Anzo",
                 "une maison"),
                  new Question(
                 "Vivre n'est pas un crime ?",
                  new List<string>() {
                        "Sammy (bonne réponse).",
                        "Togo Lando",
                        "Eve smartty"
                  },
                 "Sammy",
                 "une ecole"),
                  new Question(
                 "Le seul qui peut me battre, c'est moi ?",
                  new List<string>() {
                        "Uchiha Sasuke",
                        "Naruto",
                        "Sarada Uchiha"
                  },
                 "Uchiha Sarada",
                 "une maison"),
                  new Question(
                 "Mes ordres sont absolus ?",
                  new List<string>() {
                        "Akashi",
                        "Kuroko ",
                        "Kagami"
                  },
                 "Akashi",
                 "une maison"),
                                    new Question(
                 "Le roi des pirates, ce sera moi ?",
                  new List<string>() {
                        "Luffi (bonne réponse)",
                        "Un chien",
                        "Une enfant"
                  },
                 "Luffi",
                 "un laptop gamer zone"),
         };
         public static List<string> ObjetTrouvers = new List<string>();
        /* Tout les questions ici avec reponse et objet trouver */



        static void Main(string[] args)
        {

            do
            {
                ManuelUser();
                Console.WriteLine("Entrer L'option ici [ A, B, Q ] :".ToUpper());
                GlobalChoixUser = Console.ReadLine();

                switch (GlobalChoixUser)
                {
                    case "A":
                    case "a":
                        ResolutionEnigmes();
                        break;
                    case "B":
                        Console.WriteLine();
                        break;
                    case "Q":
                        ContinueALancer = false;
                        break;
                    default:
                        Console.WriteLine($"Desoler mais le choix [{GlobalChoixUser}] n'existe pas..");
                        break;
                }


            } while (ContinueALancer != false);



        }



        /* Résolution d’énigmes : @SOH TAGNE ACHILLE IVES ET SIM FREDERICK*/

        public static void ResolutionEnigmes()
        {
            /* Ok travaillions avec les questions et les reponse ici */
            int Index = -1;
            string? StateReponse = "";

            

            do
            {
                Index = Index + 1;
                var radomize = random.Next(0, Index);
                //Console.WriteLine(Index);
                //Console.WriteLine(radomize);
                var question = Questions[radomize].QuestionName;
                Console.WriteLine(question);
                /*  --- possibilities abswers ----  */
                var Reponses = Questions[radomize].Answers;

                for(int i = 0; i < Reponses.Count(); i ++)
                {
                    Console.WriteLine($"[** {Reponses[i]} **]");
                    StateReponse = Reponses[i];
                }
                ReponseAUser =  Console.ReadLine();
                //Console.WriteLine(" Should be correct " + Questions[radomize].CorrectAnswers);
                

                
                if (ReponseAUser?.ToLower() == Questions[radomize].CorrectAnswers.ToLower())
                {
                    Console.WriteLine(" The correct anser is " + Questions[radomize].CorrectAnswers);
                }
                else
                {
                    Console.WriteLine("Reponse Erreur");
                }

                

            } while ( Index < Questions.Count());


        }

        public static void Inventaire()
        {

        }

        public static void ManuelUser()
        {
            Console.WriteLine("Welcome to [ **** ] application ".ToUpper());
            Console.WriteLine(" ");
            Console.WriteLine("[ A ] POUR RESOUDRE UNE EGNIME");
            Console.WriteLine("[ B ] POUR VOIR LES OBJETS TROUVERS");
            Console.WriteLine("[ Q ] POUR QUITTER LE PROGRAMME");
            Console.WriteLine(" ");
        }
    }
}


/*  j'ai cree cette class pour pourvoir bien gerer la creations des questions */
/* Developpeur Soh Tagne Achille Et Sim Frederick */
class Question
{
    public string QuestionName { get; private set; }
    public List<string> Answers { get; private set; }
    public string CorrectAnswers { get; private set; }
    public string Objets { get; private set; }

    

    public Question(string questionName,List<string> answers, string correctAnswer,
            string objet_)
    {
        QuestionName = questionName;
        Answers = answers;
        CorrectAnswers = correctAnswer;
        Objets = objet_;
    }


}
