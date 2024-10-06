using Programm;

namespace StringAssert.Test
{
    [TestClass]
    public class StringAssertTests
    {
        [TestMethod]
        public void CountWord_sentence_true()
        {
            bool msgsend;
            string input = "Think gura";
            int expected = 1;
            StringAsserts word = new StringAsserts();
            int actual = word.CountWord(input);
            if (actual == expected)
            {
                msgsend = true;
            }
            else
            {
                msgsend = false;
            }
            Assert.IsFalse(msgsend, "True");

        }

        [TestMethod]
        public void CountCharacters_sentence_false()
        {

            string input = "Think Gura";
            int expected = 9;
            StringAsserts word = new StringAsserts();
            int actual = word.CountCharacter(input);
            Assert.AreNotEqual(actual, expected);

        }

        [TestMethod]
        public void FindNinhCharacter_longsentence_fail()
        {
            string input = "Think Gura, you  or you will be in the box";
            string expected = ",";
            StringAsserts word = new StringAsserts();
            string actual = word.ShortestWord(input);
            Assert.Fail("Failed test");

        }
        [TestMethod]
        public void CountDigt_longsentence_Notnull()
        {
            string input = "Think Gura33, you  or you will be in the box";
            int expected = 0;
            StringAsserts word = new StringAsserts();
            int actual = word.CountDigits(input);
            Assert.IsNull(expected, "Not null");
        }

        [TestMethod]
        public void LongestNumbers_longsentence_true()
        {
            string input = "Think2342546 Gura4325, you  or4334 you will be in the box";
            int expected = 7;
            StringAsserts word = new StringAsserts();
            int actual = word.LongestNumbers(input);
            Assert.IsNotNull(expected, "Null");
        }

        [TestMethod]
        public void CountSubstrings_longsentence_skip()
        {
            string input = "amama";
            int expected = 2;
            StringAsserts word = new StringAsserts();
            int actual = word.LongestNumbers(input);
            Assert.Inconclusive("Inconclusive");
        }
        [TestMethod]
        public void ShortestWord_sentence_true()
        {
            string input = "rik morty";
            string expected = "i4k";
            StringAsserts word = new StringAsserts();
            string actual = word.ShortestWord(input);
            Assert.AreNotEqual(expected, actual);
        }
    }
}