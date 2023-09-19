using DUPUIS_JAYSON_TD1;
using System;
using System.Collections.Generic;

namespace testLibrary
{
    [TestClass]
    public class UnitTest1
    {
        Library test_library = new Library();
        Media test_media = new Media("livre", 1, 1);


        [TestMethod]
        public void TestAddMedia()
        {
            test_library.AddMedia(test_media);

            /*test_library.Count()
            Assert.IsTrue()*/
        }
    }
}