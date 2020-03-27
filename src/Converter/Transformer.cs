using System;
using System.Collections.Generic;
using System.Linq;

namespace Converter {
	public static class Transformer {

		public static IEnumerable<string> TransformLines(
			IEnumerable<string> inputLines
		) {
			return inputLines.Select( TransformLine );
		}

		private static string TransformLine( string inputLine ) {
			(string name, int count) = ReadLineData( inputLine );

			return $"{name} has {count} items";
		}

		private static (string name, int count) ReadLineData( string inputLine ) {
			string[] items = inputLine.Split( ',' );

			if( items.Length != 2 ) {
				throw new ArgumentException( $"Line contains unexpected number of items: \"{inputLine}\"" );
			}

			string name = items[0];
			int count = int.Parse( items[1] );

			return ( name, count );
		}
	}
}
