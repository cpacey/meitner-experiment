using System.Collections.Generic;
using Converter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace ConverterTests {
	public class Tests {

		public static IEnumerable<ITestCaseData> TransformLines_TestCases() {
			yield return
				new TestCaseData(
					arg: new[] {"carl,19"}
				).Returns(
					new[] {"carl has 19 items"}
				);

			yield return
				new TestCaseData(
					arg: new[] { "lawrence,19" }
				).Returns(
					new[] { "lawrence has 19 items" }
				);
		}

		[TestCaseSource(nameof(TransformLines_TestCases))]
		public IEnumerable<string> TransformLines( string[] inputLine ) {
			IEnumerable<string> result = Transformer.TransformLines( inputLine );
			return result;
		}
	}
}
