using System.Collections.Generic;

public class Bubble : BaseSort
{
    private List<int> _input = new List<int>();
    public Bubble(List<int> input)
    {
        _input = input;
    }

    public override List<int> Sort()
    {
        // Sort the Array

        for (int i = 0; i < _input.Count; i++)
        {
            for (int j = 0; j < _input.Count; j++)
            {
                if(_input[i] < _input[j])
                {
                    var temp = _input[j];
                    _input[j] = _input[i];
                    _input[i] = temp;
                }
            }
        }

        return _input;
    }
}