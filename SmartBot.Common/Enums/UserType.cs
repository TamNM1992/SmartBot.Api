using System.ComponentModel;

namespace NhaDat24h.Common.Enums
{
	public enum UserType
	{
		[Description("Admin")]
		Admin = 1,
		[Description("Teacher")]
		Teacher = 2,
		[Description("User")]
		User = 3
	}
}
