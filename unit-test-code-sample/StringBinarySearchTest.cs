using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.IO;
using code_sample;

namespace unit_test_code_sample
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void OrderedWordsBinarySearch()
        {
            var words = File
                .ReadAllLines(@"../../../test-data/string-words.csv")
                .ToList();
            var found = StringSearch.BinarySearch(words, "Jword");
            var didNotFind = !StringSearch.BinarySearch(words, "Anonexistingword");

            Assert.IsTrue(found);
            Assert.IsTrue(didNotFind);
        }
        [TestMethod]
        public void OrderedSpecialCharacterWordsBinarySearch()
        {
            var specialCharacterStrings = File
                .ReadAllLines(@"../../../test-data/string-special-characters.csv")
                .ToList();
            var found = StringSearch.BinarySearch(specialCharacterStrings, "!Y");
            var didNotFind = !StringSearch.BinarySearch(specialCharacterStrings, "%$#");

            Assert.IsTrue(found);
            Assert.IsTrue(didNotFind);
        }
        [TestMethod]
        public void OrderedMixedWordsBinarySearch()
        {
            var mixedStrings = File
                .ReadAllLines(@"../../../test-data/string-mixed.csv")
                .ToList();
            var found = StringSearch.BinarySearch(mixedStrings, "LN750");
            var didNotFind = !StringSearch.BinarySearch(mixedStrings, "wordsmith");

            Assert.IsTrue(found);
            Assert.IsTrue(didNotFind);
        }
    }
}