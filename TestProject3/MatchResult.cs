using System.Runtime.InteropServices.JavaScript;

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
        _result += "H";
        return this;
    }


    public MatchResult AwayGoal()
    {
        _result += "A";
        return this;
    }

    public MatchResult ChangeField()
    {
        _result += ";";
        return this;
    }

    public MatchResult RemoveGoal()
    {
        //賽局陣列
        // 檢查最後一場，非空直接刪除最後一個；若為空找前一場的最後一個分數
        //HH;AA; ==> [HH][AA][]
        //AA;H   ==> [AA][H]
        var goalHasBeenRemoved = false;
        
        for (var i = _result.Length - 1; i >= 0; i--)
        {
            if (i == _result.Length - 1 && _result[i] == ';')
            {
                continue;
            }
            if (!goalHasBeenRemoved)
            {
                _result = _result.Remove(i,1);
                goalHasBeenRemoved = true;
            }
        }
        return this;
    }
}