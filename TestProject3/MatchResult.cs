namespace TestProject3;

public class MatchResult
{
    private string _result;

    public MatchResult(string result)
    {
        _result = result;
    }
    public string GetResult()
    {
        return _result;
    }
    public MatchResult HomeGoal()
    {
        _result+="H";
        return this;
    }


    public MatchResult AwayGoal()
    {
        _result+="A";
        return this;
    }

    public MatchResult ChangeField()
    {
        _result+=";";
        return this;
    }
}