﻿using Xunit;

namespace Facility.Definition.UnitTests
{
	public class ServiceDtoInfoTests
	{
		[Fact]
		public void InvalidNameThrows()
		{
			var position = new ServiceTextPosition("source");
			TestUtility.ThrowsServiceDefinitionException(() => new ServiceDtoInfo(name: "4u", position: position), position);
		}

		[Fact]
		public void DuplicateFieldThrows()
		{
			var fields = new[]
			{
				new ServiceFieldInfo("why", "int32", position: new ServiceTextPosition("source", 1)),
				new ServiceFieldInfo("Why", "int32", position: new ServiceTextPosition("source", 2)),
			};
			TestUtility.ThrowsServiceDefinitionException(() => new ServiceDtoInfo(name: "x", fields: fields), fields[1].Position);
		}
	}
}
