namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Salut ! Moi c'est Enzo et mon jeux préféré c'est The last of us part 2!");
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("C'est quoi ton prénom?");
        String name = Console.ReadLine();
        Console.WriteLine("Et ton âge?");
        int age = Convert.ToInt32(Console.ReadLine());
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        if (age >= 18)
        {
            Console.WriteLine("Tu es donc majeur.");
        }
        else
        {
            Console.WriteLine("Tu es donc mineur.");
        }
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Ho je vois que tu as de l'argent sur toi ! Combien d'euro possèdes-tu?");
        int money = Convert.ToInt32(Console.ReadLine());
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("Eh bien regarde ce que j'ai pour toi :");
        Console.WriteLine("1. Couteau de chasse : 5 euros");
        Console.WriteLine("2. Coutelas : 10 euros");
        Console.WriteLine("3. Fusil à canon scié : 20 euros");
        Console.WriteLine("4. Carabine à répétition : 35 euros");
        int price1 = 5;
        int price2 = 10;
        int price3 = 20;
        int price4 = 35;
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.WriteLine("Alors, quelquechose te fais envie ? Si oui choisis l'arme que tu souhaites en indiquant le numéro de celle-ci!");
        Console.WriteLine("Alors, quelque-chose te fais envie ? Si oui choisis l'arme que tu souhaites en indiquant le numéro de celle-ci!");
        int selectedWeapon = Convert.ToInt32(Console.ReadLine());
        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        if (selectedWeapon == 1)
        {
            if(money >= price1)
            {
                Console.WriteLine("c'est bon ! Le couteau est à toi !");
            }
            else
            {
                Console.WriteLine("Désolé " + name + " mais ce ne sera pas possible.");
            }
        }
        else
        {
            if (selectedWeapon == 2)
            {
                if (money >= price2)
                {
                    Console.WriteLine("c'est bon ! Le coutelas est à toi !");

                }
                else
                {
                    Console.WriteLine("Désolé " + name + " mais ce ne sera pas possible.");
                   
                }
            }
            if (selectedWeapon == 3)
            {
                if (money >= price3)
                {
                    Console.WriteLine("c'est bon ! Le fusil à canon scié est à toi !");

                }
                else
                {
                    Console.WriteLine("Désolé " + name + " mais ce ne sera pas possible.");
                    
                }
            }
            if (selectedWeapon == 4)
            {
                if (money >= price4)
                {
                    Console.WriteLine("c'est bon ! La carabine à répétition est à toi !");

                }
                else
                {
                    Console.WriteLine("Désolé " + name + " mais ce ne sera pas possible.");
                }
            }
        }
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}