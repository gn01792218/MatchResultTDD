namespace TestProject3;

public class Tests
{
    [SetUp]
    public void SetUp()
    {
        _matchResult = new MatchResult("");
    }

    private MatchResult _matchResult;

    [Test]
    public void Home_Goal()
    {
        GivenHomeGoalTime(1);
        ResultShouldBe("H");
    }

    [Test]
    public void HH_Goal_Chain()
    {
        _matchResult.HomeGoal().HomeGoal();
        ResultShouldBe("HH");
    }

    [Test]
    public void HH_Goal()
    {
        GivenHomeGoalTime(2);
        ResultShouldBe("HH");
    }


    [Test]
    public void Away_Goal()
    {
        _matchResult.AwayGoal();
        ResultShouldBe("A");
    }

    [Test]
    public void AA_Goal()
    {
        GivenAwayGoalTime(2);
        ResultShouldBe("AA");
    }

    [Test]
    public void AA_Goal_Chain()
    {
        _matchResult.AwayGoal().AwayGoal();
        ResultShouldBe("AA");
    }

    [Test]
    public void HA_Goal()
    {
        GivenHomeGoalTime(1);
        GivenAwayGoalTime(1);
        ResultShouldBe("HA");
    }

    [Test]
    public void Change_Field()
    {
        GivenChangeFiled();
        ResultShouldBe(";");
    }

    [Test]
    public void HHChangeAA()
    {
        GivenHomeGoalTime(2);
        GivenChangeFiled();
        GivenAwayGoalTime(2);
        ResultShouldBe("HH;AA");
    }

    [Test]
    public void HHChangeAA_Chain()
    {
        _matchResult.HomeGoal().HomeGoal().ChangeField().AwayGoal().AwayGoal();
        ResultShouldBe("HH;AA");
    }


    private void GivenChangeFiled()
    {
        _matchResult.ChangeField();
    }


    private void GivenAwayGoalTime(int time)
    {
        for (int i = 0; i < time; i++)
        {
            _matchResult.AwayGoal();
        }
    }

    private void GivenHomeGoalTime(int time)
    {
        for (int i = 0; i < time; i++)
        {
            _matchResult.HomeGoal();
        }
    }

    private void ResultShouldBe(string result)
    {
        Assert.AreEqual(result, _matchResult.GetResult());
    }
}