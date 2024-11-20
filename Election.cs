class Election {
    List<Nominee> nominees;
    List<Vote> castVotes;

    public Election(List<string> nomineeNames)
    {
        nominees = new List<Nominee>();
        castVotes = new List<Vote>();

        foreach (var name in nomineeNames)
        {
            Nominee nominee = new Nominee(name);
            nominees.Add(nominee);
        }
    }

    public List<Nominee> ListNominees()
    {
        return nominees;
    }
}


class Nominee 
{
    public string Name { get; set; }

    public Nominee(string name)
    {
        Name = name;
    }
}


class Vote 
{
    public DateTime CastAt;
    public Nominee CastFor;

    public Vote(Nominee nominee)
    {
        CastFor = nominee;
        CastAt = DateTime.Now;
    }
}