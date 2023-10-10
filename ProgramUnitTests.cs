namespace MaxsMarvellousMess.Tests
{
    [TestClass]
    public class ProgramUnitTests
    {
        readonly Visitor AlwaysAllowedVisitor = new Visitor()
        {
            VisitorName = "fine",
            HeightFt = 5.5f,
            StatedReason = "Work"
        };

        [TestMethod]
        public void VisitorsWithRepeatedLetterNames_AreDeniedEntry()
        {
            CastleWall castleWall = new();
            castleWall.visitors.Add(new Visitor()
            {
                VisitorName = "repeating name ronnie",
                HeightFt = 5.5f,
                StatedReason = "Work"
            });
            castleWall.visitors.Add(AlwaysAllowedVisitor);

            castleWall.DecideVisitorAccess();

            CollectionAssert.AreEqual(castleWall.visitors, new List<Visitor>() { AlwaysAllowedVisitor });
        }

        [TestMethod]
        public void Visitors10ftTallAndOver_AreDeniedEntry()
        {
            CastleWall castleWall = new();
            castleWall.visitors.Add(new Visitor()
            {
                VisitorName = "lanky rob",
                HeightFt = 7f,
                StatedReason = "Holiday"
            });
            castleWall.visitors.Add(AlwaysAllowedVisitor);

            castleWall.DecideVisitorAccess();

            CollectionAssert.AreEqual(castleWall.visitors, new List<Visitor>() { AlwaysAllowedVisitor });
        }

        [TestMethod]
        public void VisitorsWithInvalidReason_AreDeniedEntry()
        {
            CastleWall castleWall = new();
            castleWall.visitors.Add(new Visitor()
            {
                VisitorName = "lost jim",
                HeightFt = 5.9f,
                StatedReason = "I'm lost"
            });
            castleWall.visitors.Add(AlwaysAllowedVisitor);

            castleWall.DecideVisitorAccess();

            CollectionAssert.AreEqual(castleWall.visitors, new List<Visitor>() { AlwaysAllowedVisitor });
        }

        [TestMethod]
        public void VisitorsViolatingEveryRule_AreApprovedEntry()
        {
            CastleWall castleWall = new();
            Visitor renegadeRonald = new Visitor()
            {
                VisitorName = "renegade ronald",
                HeightFt = 16f,
                StatedReason = "let me in"
            };
            castleWall.visitors.Add(renegadeRonald);

            castleWall.DecideVisitorAccess();

            CollectionAssert.AreEqual(castleWall.visitors, new List<Visitor>() { renegadeRonald });
        }

        [TestMethod]
        public void Knights_AreApprovedEntry()
        {
            CastleWall castleWall = new();
            Visitor Knight = new Visitor()
            {
                VisitorName = "Sir Jack",
                HeightFt = 6.6f,
                StatedReason = "buying groceries in service of his majesty the king"
            };
            castleWall.visitors.Add(Knight);

            castleWall.DecideVisitorAccess();

            CollectionAssert.AreEqual(castleWall.visitors, new List<Visitor>() { Knight });
        }
    }
}
