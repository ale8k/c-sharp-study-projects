using System.Collections.Generic;

namespace NortAndCrosses_2._0.Validators
{
    /*  123 456 789 
     *  147 258 369
     *  357     159
     *  Sequences
     */
    public class SequenceValidator
    {
        public bool ValidateSequence(List<int> list)
        {
            if(ContainsHorizontalSequence(list) 
              || ContainsVerticalSequence(list)  
              || ContainsDiagonalSequence(list))
                return true;
            else
                return false;
        }   

        private bool ContainsHorizontalSequence(List<int> list)
        {
            if (list.Contains(1) && list.Contains(2) && list.Contains(3) 
               || list.Contains(4) && list.Contains(5) && list.Contains(6)
               || list.Contains(7) && list.Contains(8) && list.Contains(9))
                return true;
            else
                return false;
        }

        private bool ContainsVerticalSequence(List<int> list)
        {
            if (list.Contains(1) && list.Contains(4) && list.Contains(7)
               || list.Contains(2) && list.Contains(5) && list.Contains(8)
               || list.Contains(3) && list.Contains(6) && list.Contains(8))
                return true;
            else
                return false;
        }

        private bool ContainsDiagonalSequence(List<int> list)
        {
            if (list.Contains(1) && list.Contains(5) && list.Contains(9)
               || list.Contains(3) && list.Contains(5) && list.Contains(7))
                return true;
            else
                return false;
        }

    }

}
