using System;

namespace empty_space_bug
{
    class Program
    {
        static void Main(string[] args)
        {
            var tester = new Tests();
            tester.TestNoSpacesBeforeLineBreak();
            tester.TestSpaceBeforeLineBreak();
            tester.TestMoreSpacesBeforeLineBreak();
        }
    }
}
