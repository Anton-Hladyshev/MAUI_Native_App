namespace AntonLeoApp.Services;

public static class HolocronService
{
    private static readonly List<string> _quotes = new()
    {
        "Fais-le ou ne le fais pas. Il n'y a pas d'essai. - Yoda",
        "La peur est le chemin vers le côté obscur. - Yoda",
        "Que la Force soit avec toi. - Obi-Wan Kenobi",
        "J'ai un mauvais pressentiment à ce sujet. - Han Solo",
        "Je trouve votre manque de foi dérangeant. - Darth Vader",
        "C'est ainsi que meurt la liberté, sous des tonnerres d'applaudissements. - Padmé Amidala",
        "Personne ne disparaît vraiment tout à fait. - Luke Skywalker",
        "Le plus grand maître est l'échec. - Yoda",
        "Chewie, on est à la maison. - Han Solo",
        "Toujours par deux ils vont. Ni plus, ni moins. - Yoda",
        "Tes yeux peuvent te tromper, ne leur fais pas confiance. - Obi-Wan Kenobi",
        "La Force n'est pas un pouvoir que tu possèdes. C'est l'énergie entre les choses. - Luke Skywalker",
        "Je suis un Jedi, comme mon père l'était avant moi. - Luke Skywalker",
        "Beaucoup de vérités auxquelles nous tenons dépendent de notre point de vue. - Obi-Wan Kenobi",
        "L'attachement mène à la jalousie. L'ombre de la cupidité, cela est. - Yoda",
        "La capacité de parler ne témoigne pas d'une grande intelligence. - Qui-Gon Jinn",
        "L'espoir est comme le soleil. Si vous n'y croyez que quand vous le voyez... - Leia Organa",
        "Dans mon expérience, la chance n'existe pas. - Obi-Wan Kenobi",
        "Ta volonté de fer ne viendra pas à bout de mon pouvoir. - Palpatine",
        "Il y a toujours un plus gros poisson. - Qui-Gon Jinn",
        "Sois patient, jeune Padawan. - Obi-Wan Kenobi",
        "La peur de la perte est un chemin vers le côté obscur. - Yoda",
        "Laisse le passé mourir. Tue-le s'il le faut. - Kylo Ren",
        "Nous sommes ce qu'ils dépassent. C'est le fardeau de tous les maîtres. - Yoda",
        "C'est un piège ! - Amiral Ackbar",
        "Le côté obscur n'est pas plus fort, il est plus rapide, plus facile, plus séduisant. - Yoda"
    };

    public static string GetRandomQuote()
    {
        var rand = new Random();
        return _quotes[rand.Next(_quotes.Count)];
    }
}