using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace appInsperity.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SortingOperationsTestCaseInput2Examples()
        {
            // Arrange
            List<string> inputs = new()
            {
                "abaccadcc",
                "xyzxy"
            };

            List<string> expectedOutputs = new()
            {
                "ccccaaabd",
                "xxyyz"
            };

            // Act
            List<string> actualOutputs = Program.PerfomOperations(inputs);

            // Assert
            for (int i = 0; i < actualOutputs.Count; i++)
            {
                Assert.AreEqual(expectedOutputs[i], actualOutputs[i]);
            }
        }

        [TestMethod()]
        public void SortingOperationsTestCaseInput10ExamplesV1()
        {
            // Arrange
            List<string> inputs = new()
            {
                "dulgvgzwqg",
                "gxtjtmtywr",
                "hnlnxiupgt",
                "gzjotckivp",
                "dpwwsdptae",
                "pcscpilknb",
                "btvyhhmflf",
                "artrtnqxcr",
                "nrtcmcoadn",
                "fkdsgnekft"
            };

            List<string> expectedOutputs = new()
            {
                "gggdlquvwz",
                "tttgjmrwxy",
                "nnghilptux",
                "cgijkoptvz",
                "ddppwwaest",
                "ccppbiklns",
                "ffhhblmtvy",
                "rrrttacnqx",
                "ccnnadmort",
                "ffkkdegnst"
            };

            // Act
            List<string> actualOutputs = Program.PerfomOperations(inputs);

            // Assert
            for (int i = 0; i < actualOutputs.Count; i++)
            {
                Assert.AreEqual(expectedOutputs[i], actualOutputs[i]);
            }
        }

        [TestMethod()]
        public void SortingOperationsTestCaseInput5ExamplesV1()
        {
            // Arrange
            List<string> inputs = new()
            {
                "wzenwebuau",
                "vokfxzynwl",
                "neldfeyrxk",
                "wqadfiodgs",
                "ykiuvzfcbc"
            };

            List<string> expectedOutputs = new()
            {
                "eeuuwwabnz",
                "fklnovwxyz",
                "eedfklnrxy",
                "ddafgioqsw",
                "ccbfikuvyz"
            };

            // Act
            List<string> actualOutputs = Program.PerfomOperations(inputs);

            // Assert
            for (int i = 0; i < actualOutputs.Count; i++)
            {
                Assert.AreEqual(expectedOutputs[i], actualOutputs[i]);
            }
        }

        [TestMethod()]
        public void SortingOperationsTestCaseInput10ExamplesV2()
        {
            // Arrange
            List<string> inputs = new()
            {
                "qakmc",
                "rrtbk",
                "vaixn",
                "wmpnj",
                "uproi",
                "btska",
                "ejqwr",
                "elwlg",
                "oaoiy",
                "hrqkn"
            };

            List<string> expectedOutputs = new()
            {
                "ackmq",
                "rrbkt",
                "ainvx",
                "jmnpw",
                "iopru",
                "abkst",
                "ejqrw",
                "llegw",
                "ooaiy",
                "hknqr"
            };

            // Act
            List<string> actualOutputs = Program.PerfomOperations(inputs);

            // Assert
            for (int i = 0; i < actualOutputs.Count; i++)
            {
                Assert.AreEqual(expectedOutputs[i], actualOutputs[i]);
            }
        }

        [TestMethod()]
        public void SortingOperationsTestCaseInput3Examples()
        {
            // Arrange
            List<string> inputs = new()
            {
                "pzjim",
                "njnfq",
                "xyohs"
            };

            List<string> expectedOutputs = new()
            {
                "ijmpz",
                "nnfjq",
                "hosxy"
            };

            // Act
            List<string> actualOutputs = Program.PerfomOperations(inputs);

            // Assert
            for (int i = 0; i < actualOutputs.Count; i++)
            {
                Assert.AreEqual(expectedOutputs[i], actualOutputs[i]);
            }
        }

        [TestMethod()]
        public void SortingOperationsTestCaseInput5ExamplesV2()
        {
            // Arrange
            List<string> inputs = new()
            {
                "xqycs",
                "beoax",
                "afkso",
                "bldit",
                "gwrys"
            };

            List<string> expectedOutputs = new()
            {
                "cqsxy",
                "abeox",
                "afkos",
                "bdilt",
                "grswy"
            };

            // Act
            List<string> actualOutputs = Program.PerfomOperations(inputs);

            // Assert
            for (int i = 0; i < actualOutputs.Count; i++)
            {
                Assert.AreEqual(expectedOutputs[i], actualOutputs[i]);
            }
        }
    }
}