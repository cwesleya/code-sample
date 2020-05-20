using Microsoft.VisualStudio.TestTools.UnitTesting;
using code_sample;
using System;

namespace unit_test_code_sample
{
    [TestClass]
    public class UniqueCharactersTests
    {
        private readonly string _strDupe = "SomeDuplicates";
        private readonly string _strUniq = "NoDuplicates";

        [TestMethod]
        public void UniqueChars()
        {
            var hasDupe = UniqueCharacters.UniqueChars(_strDupe);
            var isUniq = UniqueCharacters.UniqueChars(_strUniq);

            Assert.IsFalse(hasDupe);
            Assert.IsTrue(isUniq);
        }
    }
}