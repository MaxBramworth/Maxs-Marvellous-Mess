namespace MaxsMarvellousMess
{
    public class CastleWall
    {
        public List<Visitor> visitors = new()
        {
            
        };

        static void Main()
        {
            CastleWall castleWall = new();
            castleWall.visitors.Add(new Visitor()
            {
                VisitorName = "repeating name ronnie",
                HeightFt = 5.5f,
                StatedReason = "Work"
            });

            castleWall.DecideVisitorAccess();
        }

        public void DecideVisitorAccess()
        {
            List<Visitor> allowedVisitors = new();
            for (int i = 0; i < visitors.Count; i++)
            {
                if (visitors[i].VisitorName == null)
                {
                    return;
                }
                bool hasARepeatingLetter = false;
                List<char> lettersContaining = new();
                for (int j = 0; j < visitors[i].VisitorName.Length; j++)
                {
                    if (lettersContaining.Contains(visitors[i].VisitorName[j]))
                    {
                        hasARepeatingLetter = true;
                    } else
                    {
                        lettersContaining.Add(visitors[i].VisitorName[j]);
                    }
                }
                if (hasARepeatingLetter == false)
                {
                    if (!(visitors[i].HeightFt > 6.5f || visitors[i].HeightFt == 6.5f))
                    {
                        if (visitors[i].StatedReason == "Work" || visitors[i].StatedReason == "Holiday" ||
                            visitors[i].StatedReason == "Returning Home")
                        {
                            allowedVisitors.Add(visitors[i]);
                        }
                    }
                }
                if (hasARepeatingLetter == true)
                {
                    if (visitors[i].HeightFt > 6.5f || visitors[i].HeightFt == 6.5f)
                    {
                        if (visitors[i].StatedReason != "Work" && visitors[i].StatedReason != "Holiday" &&
                            visitors[i].StatedReason != "Returning Home")
                        {
                            allowedVisitors.Add(visitors[i]);
                        }
                    }
                }
                if (hasARepeatingLetter == false)
                {
                    string firstFourLetters = visitors[i].VisitorName.Substring(0, 4);
                    if (firstFourLetters == "Sir ")
                    {
                        string inServiceBit;
                        if (visitors[i].StatedReason.Length > 35)
                        {
                            inServiceBit = visitors[i].StatedReason.Substring(visitors[i].StatedReason.Length - 35);
                            if (inServiceBit == " in service of his majesty the king")
                            {
                                allowedVisitors.Add(visitors[i]);
                            }
                        }
                    }
                }
            }
            visitors = allowedVisitors;
        }
    }

    public class Visitor
    {
        public string? VisitorName;
        public float HeightFt;
        public string? StatedReason;
    }
}
