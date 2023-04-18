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
    public string HomeGoal()
    {
        return _result+="H";
    }


    public string AwayGoal()
    {
        return _result+="A";
    }

    public string ChangeField()
    {
        return _result+=";";
    }
}