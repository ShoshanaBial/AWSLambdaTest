using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambdaTest;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(string input, ILambdaContext context)
    {
        return input.ToUpper();
    }

     public string MainPermuteFunction( ILambdaContext context)
    {

        var result = ResultInPosition(Permute(3), 2);
        return result.ToString();
    }
    public  IList<string> Permute(int num)
    {
        string numsChar = "";
        for (int i = 0; i < num; i++)
            numsChar += i + 1;

        var list = new List<string>();
        return DoPermute(numsChar, "", list);

    }

    static IList<string> DoPermute(String s, String answer, IList<string> list)
    {
        if (s.Length == 0)
        {
            list.Add(answer);
        }
        else
        {

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                String left_substr = s.Substring(0, i);
                String right_substr = s.Substring(i + 1);
                String rest = left_substr + right_substr;
                DoPermute(rest, answer + ch, list);
            }

        }

        return list;

    }

    public string ResultInPosition(IList<string> list, int position)
    {
        return list[position - 1];

    }
}
